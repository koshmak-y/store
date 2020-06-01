using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Forms;
using Store.DataModel;
using System.Configuration;
using System.Collections.Specialized;

namespace Store.Forms
{
    public partial class CheckingOrderForm : Form
    {
        public CheckingOrderForm()
        {
            InitializeComponent();
        }

        private void CheckingOrderForm_Load(object sender, EventArgs e)
        {
            NameValueCollection LoadFromConfig = ConfigurationManager.AppSettings;
            if (LoadFromConfig["backgroundColor"] != null)
            {
                CheckingOrderDataGrid.BackColor = Color.FromName(LoadFromConfig["backgroundColor"]);
                CheckingOrderDataGrid.DefaultCellStyle.BackColor = Color.FromName(LoadFromConfig["backgroundColor"]);
            }
            if (LoadFromConfig["textColor"] != null)
                CheckingOrderDataGrid.DefaultCellStyle.ForeColor = Color.FromName(LoadFromConfig["textColor"]);

            using (StoreDB db = new StoreDB())
            {
                CheckingOrderDataGrid.DataSource = GlobalVars.CurrentProductsList;
            }
            
            CheckingOrderDataGrid.Columns[0].ReadOnly = false;
            CheckingOrderDataGrid.Columns[1].ReadOnly = false;
            CheckingOrderDataGrid.Columns[2].ReadOnly = false;
            CheckingOrderDataGrid.Columns["ProductId"].Visible = false;
            CheckingOrderDataGrid.Columns["CategoryId"].Visible = false;
            CheckingOrderDataGrid.Columns["Category"].Visible = false;
            CheckingOrderDataGrid.Columns["Orders"].Visible = false;
            if (!GlobalVars.CurrentUser.IsManager)
            {
                try
                {
                    CheckingOrderDataGrid.Columns["IsChecked"].Visible = false;
                }
                catch (NullReferenceException) { }
            }
        }
    }
}
