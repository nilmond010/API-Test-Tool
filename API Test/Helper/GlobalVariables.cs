using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Test.Helper
{
    public partial class FrmGlobalVariables : Form
    {
        private string _FileName = "GloabalVars.json";

        public FrmGlobalVariables()
        {
            InitializeComponent();
            Load += GlobalVariables_Load;
            FormClosing += GlobalVariables_FormClosing;
        }

        private void GlobalVariables_Load(object sender, EventArgs e)
        {

        }

        private void GlobalVariables_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


    }
}
