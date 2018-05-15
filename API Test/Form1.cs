using API.Business;
using API.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Test
{
    public partial class Form1 : Form
    {
        private readonly IWebRequest webRequest;

        public Form1()
        {
            webRequest = new WebRequest();

            InitializeComponent();
            InitTabPage();
        }

        private void InitTabPage()
        {
            SaveNodeToTree(Guid.NewGuid(), "Root");

            var tabPage = CreateRquestTabPage("Default");
            var tabPageNew = new TabPage("+");
            tabPageNew.Name = "NewTab";

            tabControl.TabPages.AddRange(new TabPage[] { tabPage, tabPageNew });

            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            treeViewTestData.NodeMouseDoubleClick += TreeViewTestData_NodeMouseDoubleClick;

            ReadExistingNodes();
        }

        private void ReadExistingNodes()
        {
            var nodeCollection = webRequest.GetAllNodes();
            if (nodeCollection != null)
            {
                foreach (var node in nodeCollection)
                {
                    SaveNodeToTree(node.Key, node.Value);
                }
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "NewTab")
            {
                TabPage tabPage = CreateRquestTabPage("Default");
                tabControl.TabPages.Insert(tabControl.TabPages.Count - 1, tabPage);
                tabControl.SelectedTab = tabPage;
            }
        }

        private TabPage CreateRquestTabPage(string tabName)
        {
            var tabPage = new TabPage(tabName);
            var usrRequestControl = new UsrRequestControl(webRequest, Guid.NewGuid());
            usrRequestControl.SaveNode += SaveNodeToTree;
            usrRequestControl.Dock = DockStyle.Fill;
            tabPage.Controls.Add(usrRequestControl);
            tabPage.Controls.Add(usrRequestControl);

            return tabPage;
        }

        private void TreeViewTestData_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Root")
            {
                return;
            }

            TabPage existingTabPage = null;
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Tag == null || e.Node.Tag == null)
                {
                    continue;
                }

                if ((Guid)tabPage.Tag == (Guid)e.Node.Tag)
                {
                    existingTabPage = tabPage;
                    break;
                }
            }

            if (existingTabPage == null)
            {
                var usrRequestControl = new UsrRequestControl(webRequest, (Guid)e.Node.Tag);
                usrRequestControl.UpdateForm(e.Node.Text, (Guid)e.Node.Tag);
                usrRequestControl.SaveNode += SaveNodeToTree;
                usrRequestControl.Dock = DockStyle.Fill;
                existingTabPage = new TabPage(e.Node.Text);
                existingTabPage.Tag = (Guid)e.Node.Tag;
                existingTabPage.Controls.Add(usrRequestControl);

                tabControl.TabPages.Insert(0, existingTabPage);
            }

            tabControl.SelectedTab = existingTabPage;
        }


        private void SaveNodeToTree(Guid obj, string testName)
        {
            var treeNode = new TreeNode();
            treeNode.Text = testName;

            treeNode.Tag = obj;
            treeViewTestData.Nodes.Add(treeNode);
        }
    }
}
