using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using API.Interface;
using API.Business;
using API.Model;
using API_Test.Helper;

namespace API_Test
{

    public partial class UsrRequestControl : UserControl
    {
        private readonly IWebRequest webRequest;
        private readonly Guid Id;

        public Action<Guid, string> SaveNode;

        public UsrRequestControl(IWebRequest webRequest, Guid Id)
        {
            InitializeComponent();
            this.webRequest = webRequest;
            this.Id = Id;
        }

        private void cmbRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBody.Enabled = cmbRequestType.Text == "POST";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            RequestParam requestModel = GetRquestModel();

            var result = webRequest.ProcessRequest(requestModel, "");
            txtResult.Text = result.Result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RequestParam requestModel = GetRquestModel();

            webRequest.SaveRequest(requestModel);

            SaveNode?.Invoke(requestModel.Guid, requestModel.Title);
        }

        private void btnGloabalVariables_Click(object sender, EventArgs e)
        {
            FrmGlobalVariables globalVariables = new FrmGlobalVariables();
            globalVariables.ShowDialog();
        }

        internal void UpdateForm(string name, Guid guid)
        {
            var request = webRequest.GetSavedRequest(guid);
            if (request != null)
            {
                txtTextName.Text = name;
                SetRquestModel(request);
            }
        }

        private void SetRquestModel(RequestParam requestParam)
        {
            txtRequestUrl.Text = requestParam.Url;
            cmbRequestType.Text = requestParam.RequestType;
            txtBody.Text = requestParam.RequestBody;

            gridHeaders.Rows.Clear();

            foreach (var headers in requestParam.Parameters)
            {
                gridHeaders.Rows.Add(headers.Key, headers.Value);
            }
        }

        private RequestParam GetRquestModel()
        {
            var url = txtRequestUrl.Text;
            var requestType = cmbRequestType.Text;
            var body = txtBody.Text;
            var textName = txtTextName.Text == "" ? "Sample Request" : txtTextName.Text;

            var headers = new Dictionary<string, string>();
            for (int rowCount = 0; rowCount < gridHeaders.RowCount; rowCount++)
            {
                var key = Convert.ToString(gridHeaders[0, rowCount].Value);
                var data = Convert.ToString(gridHeaders[1, rowCount].Value);

                if (!string.IsNullOrWhiteSpace(key) || !string.IsNullOrWhiteSpace(data))
                {
                    headers.Add(key, data);
                }
            }

            var requestModel = new RequestParam()
            {
                Guid = Id,
                Url = url,
                RequestType = requestType,
                Parameters = headers,
                RequestBody = body,
                Title = textName
            };

            return requestModel;
        }


    }
}
