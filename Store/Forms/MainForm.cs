using System;
using System.Collections.Specialized;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using Store.DataModel;
using System.Diagnostics;

namespace Store.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            GlobalVars.autorizationForm.ShowDialog();
            InitializeComponent();

            uploadToDB();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NameValueCollection LoadFromConfig = ConfigurationManager.AppSettings;
            if (LoadFromConfig["backgroundColor"] != null)
            {
                dataGridView.BackgroundColor = Color.FromName(LoadFromConfig["backgroundColor"]);
                dataGridView.DefaultCellStyle.BackColor = Color.FromName(LoadFromConfig["backgroundColor"]);
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromName(LoadFromConfig["backgroundColor"]);
                dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromName(LoadFromConfig["backgroundColor"]);
            }
                
            if (LoadFromConfig["textColor"] != null)
            {
                dataGridView.ForeColor = Color.FromName(LoadFromConfig["textColor"]);
            }

            using (StoreDB db = new StoreDB())
            {
                menusVisible(true, false, false, true, false);
                CategoriesStrip_Load();
                CurrentProductsList_Load();
                dgProducts(db.Products.ToList());
                if (GlobalVars.CurrentUser.IsManager)
                {
                    administratorMenuButton.Visible = true;
                }
                else
                {
                    administratorMenuButton.Visible = false;
                }
            }
            
        }

        //заполнение быза данных
        private void uploadToDB()
        {
            using (StoreDB db = new StoreDB())
            {
                if (db.Products.Count() != 0) return;
                Category mac = new Category("Mac");
                Category ipad = new Category("iPad");
                Category iphone = new Category("iPhone");
                Category watch = new Category("Watch");
                Category tv = new Category("TV");
                Category music = new Category("Music");
                db.Categories.Add(mac);
                db.Categories.Add(ipad);
                db.Categories.Add(iphone);
                db.Categories.Add(watch);
                db.Categories.Add(tv);
                db.Categories.Add(music);
                db.SaveChanges();

                db.Products.AddRange(new List<Product> { new Product("MacBook Air", 1299, mac),
                    new Product("MacBook Pro 13\"", 2399, mac),
                    new Product("MacBook Pro 16\"", 2799, mac),
                    new Product("iMac", 2299, mac),
                    new Product("iMac Pro", 4999, mac),
                    new Product("iPad Pro", 999, ipad),
                    new Product("iPad Air", 499, ipad),
                    new Product("iPad", 329, ipad),
                    new Product("iPad Mini", 399, ipad),
                    new Product("iPhone 11 Pro", 999, iphone),
                    new Product("iPhone 11", 699, iphone),
                    new Product("iPhone xR", 599, iphone),
                    new Product("iPhone 8", 449, iphone),
                    new Product("Watch Series 5", 399, watch),
                    new Product("Watch Nike", 399, watch),
                    new Product("Watch Series 3", 399, watch),
                    new Product("TV 4K", 199, tv),
                    new Product("TV HD", 149, tv),
                    new Product("Airpods Pro", 249, music),
                    new Product("Airpods", 199, music),
                    new Product("Home Pod", 299, music)});
                db.SaveChanges();
            }
        }

        /*---------------------------------------------------------------    LoadForm    ----------------------------------------------------------------*/
        private void CategoriesStrip_Load()
        {
            using (StoreDB db = new StoreDB())
            {
                int countCategories = 0;
                foreach (Category category in db.Categories)
                {
                    countCategories++;
                }

                int ItemSizeWith = (CategoriesStrip.Size.Width - 1) / countCategories;

                foreach (Category category in db.Categories.Include(t => t.ProductInCategory))
                {
                    var newCategory = new ToolStripMenuItem(category.Name);
                    newCategory.AutoSize = false;
                    newCategory.Size = new Size(ItemSizeWith, 30);
                    newCategory.ForeColor = Color.DarkSlateGray;
                    CategoriesStrip.Items.Add(newCategory);
                    newCategory.Click += Category_Click;
                    foreach (Product pl in category.ProductInCategory)
                    {
                        var newItem = newCategory.DropDownItems.Add(pl.Name);
                        newItem.Click += Product_Click;
                        newItem.ForeColor = Color.DarkSlateGray;
                    }
                }
            }
        }
        private void CurrentProductsList_Load()
        {
            using (StoreDB db = new StoreDB())
            {
                GlobalVars.CurrentProductsList = null;
                var tmp = from product in db.Products
                          select product;
                try
                {
                    foreach (var item in tmp)
                    {
                        GlobalVars.CurrentProductsList.Add(item);
                    }
                }
                catch(NullReferenceException)
                {

                }
            }
        }
        private void Product_Click(object sender, EventArgs e)
        {
            List<Product> tmpList = new List<Product>();
            var tmp = sender as ToolStripItem;
            using (StoreDB db = new StoreDB())
            {
                foreach (var Product in db.Products)
                {
                    if (Product.Name == tmp.Text)
                    {
                        tmpList.Add(Product);
                    }
                }
                if (tmpList.Count == 0)
                {
                    MessageBox.Show($"No product: {tmp.Text}");
                }
                else
                {
                    dgProducts(tmpList);
                }
            }
        }
            
        private void Category_Click(object sender, EventArgs e)
        {
            List<Product> tmpList = new List<Product>();
            var tmp = sender as ToolStripItem;
            using (StoreDB db = new StoreDB())
            {
                foreach (Category category in db.Categories.Include(t => t.ProductInCategory))
                {
                    if (category.Name == tmp.Text)
                    {
                        foreach (Product product in category.ProductInCategory)
                        {
                            tmpList.Add(product);
                        }
                    }
                }
                if (tmpList.Count == 0)
                {
                    MessageBox.Show($"No products in category: {tmp.Text}");
                }
                else
                {
                    dgProducts(tmpList);
                }
            }
        }
        /*---------------------------------------------------------------    LoadForm    ----------------------------------------------------------------*/

        /*---------------------------------------------------------------    Market    ----------------------------------------------------------------*/

        private void marketButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                menusVisible(true, false, false, true, false);
                dgProducts(db.Products.ToList());
            }
        }
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.ShoppingCartList.Add((Product)dataGridView.CurrentRow.DataBoundItem);
                MessageBox.Show($"{((Product)dataGridView.CurrentRow.DataBoundItem).Name} added to shopping cart.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("First choose the product you want to buy.");
            }
        }
        /*---------------------------------------------------------------    end_Market    ----------------------------------------------------------------*/

        /*---------------------------------------------------------------    ShoppingCart    ----------------------------------------------------------------*/
        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            if (GlobalVars.ShoppingCartList.Count != 0)
            {
                menusVisible(false, true, false, false, false);
                dgProducts(GlobalVars.ShoppingCartList);
            }
            else
            {
                MessageBox.Show("Your shooping cart is empty. At first add product in shooping cart.");
            }
        }

        private void deleteFromCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow.DataBoundItem == null && dataGridView.Rows.Count > 0)
                {
                    MessageBox.Show("First choose the product you want to remove.");
                }
                Product tmp = (Product)dataGridView.CurrentRow.DataBoundItem;
                dataGridView.DataSource = null;
                GlobalVars.ShoppingCartList.Remove(tmp);
                if (GlobalVars.ShoppingCartList.Count != 0)
                {
                    dgProducts(GlobalVars.ShoppingCartList);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Your shopping cart is empty. At first add product in shooping cart.");
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                totalCost = totalCost + (double)dataGridView.Rows[i].Cells[2].Value;
            }

            string resultString = $"Create an order of {dataGridView.Rows.Count} products with a total value - {totalCost}";

            DialogResult result = MessageBox.Show(resultString, "Accept order", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (StoreDB db = new StoreDB())
                {
                    Order order = new Order(db.Users.Find(GlobalVars.CurrentUser.userID), totalCost);
                    
                    foreach (var product in GlobalVars.ShoppingCartList)
                    {
                        order.Products.Add(db.Products.Find(product.ProductId));
                    }
                    db.Orders.Add(order);
                    db.SaveChanges();
                    MessageBox.Show("Your order is created. Waiting for moderator to check");
                }
                dataGridView.DataSource = null;
                GlobalVars.ShoppingCartList.Clear();
                shoppingHistoryButton_Click(sender, e);
            }
        }
        /*---------------------------------------------------------------    end_ShoppingCart    ----------------------------------------------------------------*/

        /*---------------------------------------------------------------    ShoppingHistory    ----------------------------------------------------------------*/
        private void shoppingHistoryButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                if (db.Orders.Where(u => u.userId == GlobalVars.CurrentUser.userID).Count() > 0)
                {
                    byDateButton_Click(sender, e);
                    menusVisible(false, false, true, false, false);

                    List<Order> userOrders = db.Orders
                        .Where(x => x.userId == GlobalVars.CurrentUser.userID)
                        .ToList();

                    dgOrders(userOrders);
                }
                else
                {
                    MessageBox.Show("You have no purchases yet.");
                }
            }
        }
        public void checkProductsButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                var products =  db.Products
                    .Include(p => p.Orders)
                    .Where(p => p.Orders.Any(c => c.orderId == ((Order)dataGridView.CurrentRow.DataBoundItem).orderId))
                    .ToList();
                GlobalVars.CurrentProductsList = products;
                GlobalVars.checkingOrderForm.ShowDialog();
            }
        }

        private async void makeInvoiceButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("D:\\");
            directoryInfo.CreateSubdirectory("Temp");
            string path = @"D:\temp\file.txt";
            Order order = (Order)dataGridView.CurrentRow.DataBoundItem;
            List<Product> productsInOrder;

            using (StoreDB db = new StoreDB())
            {
                productsInOrder = db.Products
                    .Include(p => p.Orders)
                    .Where(p => p.Orders.Any(c => c.orderId == ((Order)dataGridView.CurrentRow.DataBoundItem).orderId))
                    .ToList();
            }

            try
            {

                using (FileStream fs = File.Create(path))
                {
                    byte[] orderInfo = new UTF8Encoding(true)
                        .GetBytes($"Buyer: {order.userName}\n" +
                        $"Order number: {order.orderId}\n" +
                        $"Date: {order.timeCreatedOrder}\n\n" +
                        $"| Price\t| Product\n");
                    fs.Write(orderInfo, 0, orderInfo.Length);
                    
                    foreach (var product in productsInOrder)
                    {
                        byte[] productInfo = new UTF8Encoding(true).GetBytes($"| {product.Price}\t| {product.Name}\n");
                        await fs.WriteAsync(productInfo, 0, productInfo.Length);
                    }

                    byte[] orderSum = new UTF8Encoding(true)
                        .GetBytes($"\nTotal price: {order.sum}");
                    fs.Write(orderSum, 0, orderSum.Length);
                }
                Process.Start(path);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void byOrderIdButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                List<Order> userOrders = db.Orders
                    .Where(x => x.userId == GlobalVars.CurrentUser.userID)
                    .OrderBy(x => x.orderId)
                    .ToList();

                dgOrders(userOrders);
            }
        }
        private void byDateButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                List<Order> userOrders = db.Orders
                    .Where(x => x.userId == GlobalVars.CurrentUser.userID)
                    .OrderByDescending(x => x.timeCreatedOrder)
                    .ToList();

                dgOrders(userOrders);
            }
        }
        private void bySumButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                List<Order> userOrders = db.Orders
                    .Where(x => x.userId == GlobalVars.CurrentUser.userID)
                    .OrderBy(x => x.sum)
                    .ToList();

                dgOrders(userOrders);
            }
        }

        /*---------------------------------------------------------------    end_ShoppingHistory    ----------------------------------------------------------------*/
        /*---------------------------------------------------------------    AdministratorMenu    ----------------------------------------------------------------*/
        private void allUsersButton_Click(object sender, EventArgs e)
        {
            menusVisible(false, false, false, false, true);
            menuAdministrator.Items[0].Visible = false;
            menuAdministrator.Items[1].Visible = false;
            menuAdministrator.Items[2].Visible = false;
            menuAdministrator.Items[3].Visible = true;
            menuAdministrator.Items[4].Visible = true;
            using (StoreDB db = new StoreDB())
            {
                List<User> users = db.Users
                    .OrderBy(y => y.userID)
                    .OrderBy(x => x.IsManager)
                    .ToList();

                dataGridView.DataSource = users;
                dataGridView.Columns["password"].Visible = false;
                dataGridView.Columns["Orders"].Visible = false;
            }
        }

        private void createAccauntButton_Click(object sender, EventArgs e)
        {
            var temp = new RegistrationForm();
            temp.ShowDialog();
            allUsersButton_Click(sender, e);
            menusVisible(false, false, false, false, true);
        }
        private void findUserButton_Click(object sender, EventArgs e)
        {
            menusVisible(false, false, false, false, true);
            menuAdministrator.Items[0].Visible = false;
            menuAdministrator.Items[1].Visible = false;
            menuAdministrator.Items[2].Visible = false;
            menuAdministrator.Items[3].Visible = true;
            menuAdministrator.Items[4].Visible = true;
            using (StoreDB db = new StoreDB())
            {
                string userEmail = Interaction.InputBox("Enter user email:");
                List<User> users = db.Users
                    .Where(u => u.mail == userEmail)
                    .ToList();
                if (users.Count == 0)
                {
                    MessageBox.Show("User is not found.");
                }
                else
                {
                    dataGridView.DataSource = users;
                    dataGridView.Columns["password"].Visible = false;
                    dataGridView.Columns["Orders"].Visible = false;
                    menusVisible(false, false, false, false, true);
                }
            }
        }
        private void allOrdersButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                var allOrders = from order in db.Orders
                                select order;

                dgOrdersAdmin(allOrders.ToList());
                menusVisible(false, false, false, false, true);
                menuAdministrator.Items[0].Visible = true;
                menuAdministrator.Items[1].Visible = true;
                menuAdministrator.Items[2].Visible = true;
                menuAdministrator.Items[3].Visible = false;
                menuAdministrator.Items[4].Visible = false;
            }
        }

        private void findOrderButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                int orderId = 0;
                tryMore: try
                {
                    orderId = Convert.ToInt32(Interaction.InputBox("Enter order id:"));
                }
                catch (Exception)
                {
                    MessageBox.Show("Format id is not correct.");
                    goto tryMore;
                }

                List<Order> orders = db.Orders
                    .Where(o => o.orderId == orderId)
                    .ToList();
                if (orders.Count == 0)
                {
                    MessageBox.Show("Order does not exist.");
                }
                else
                {
                    menusVisible(false, false, false, false, true);
                    menuAdministrator.Items[0].Visible = true;
                    menuAdministrator.Items[1].Visible = true;
                    menuAdministrator.Items[2].Visible = true;
                    menuAdministrator.Items[3].Visible = false;
                    menuAdministrator.Items[4].Visible = false;
                    dgOrdersAdmin(orders);
                }
            }
        }
        private void checkedOrdersButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                var checkedOrders = from order in db.Orders
                                    where order.IsChecked == true
                                    select order;
                if (checkedOrders.ToList().Count == 0)
                {
                    MessageBox.Show("All orders are unchecked.");
                }
                else
                {
                    menusVisible(false, false, false, false, true);
                    menuAdministrator.Items[0].Visible = true;
                    menuAdministrator.Items[1].Visible = true;
                    menuAdministrator.Items[2].Visible = true;
                    menuAdministrator.Items[3].Visible = false;
                    menuAdministrator.Items[4].Visible = false;
                    dgOrdersAdmin(checkedOrders.ToList());
                }
            }
        }
        private void uncheckedOrdersButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                var uncheckedOrders = from order in db.Orders
                                      where order.IsChecked == false
                                      select order;
                if (uncheckedOrders.ToList().Count == 0)
                {
                    MessageBox.Show("All orders are checked.");
                }
                else
                {
                    menusVisible(false, false, false, false, true);
                    menuAdministrator.Items[0].Visible = true;
                    menuAdministrator.Items[1].Visible = true;
                    menuAdministrator.Items[2].Visible = true;
                    menuAdministrator.Items[3].Visible = false;
                    menuAdministrator.Items[4].Visible = false;
                    dgOrdersAdmin(uncheckedOrders.ToList());
                }
            }
        }

        private void isCheckedButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                db.Orders.First(o => o.orderId == ((Order)dataGridView.CurrentRow.DataBoundItem).orderId).IsChecked = true;
                db.SaveChanges();
                var allOrders = from order in db.Orders
                                select order;

                dgOrdersAdmin(allOrders.ToList());
            }
        }

        private void isUncheckedButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                db.Orders.First(o => o.orderId == ((Order)dataGridView.CurrentRow.DataBoundItem).orderId).IsChecked = false;
                db.SaveChanges();
                var allOrders = from order in db.Orders
                                select order;

                dgOrdersAdmin(allOrders.ToList());
            }

        }

        private void isManagerButton_Click(object sender, EventArgs e)
        {
            if (((User)dataGridView.CurrentRow.DataBoundItem).userID == GlobalVars.CurrentUser.userID)
            {
                MessageBox.Show("You can not change your status manager.");
                return;
            }
            using (StoreDB db = new StoreDB())
            {
                db.Users.First(o => o.userID == ((User)dataGridView.CurrentRow.DataBoundItem).userID).IsManager = true;
                db.SaveChanges();
                List<User> users = db.Users
                        .OrderBy(y => y.userID)
                        .OrderBy(x => x.IsManager)
                        .ToList();
                dataGridView.DataSource = users;
                dataGridView.Columns["password"].Visible = false;
                dataGridView.Columns["Orders"].Visible = false;
            }
        }

        private void isNotManagerButton_Click(object sender, EventArgs e)
        {
            if (((User)dataGridView.CurrentRow.DataBoundItem).userID == GlobalVars.CurrentUser.userID)
            {
                MessageBox.Show("You can not change your status manager.");
                return;
            }
            using (StoreDB db = new StoreDB())
            {
                db.Users.First(o => o.userID == ((User)dataGridView.CurrentRow.DataBoundItem).userID).IsManager = false;
                db.SaveChanges();
                List<User> users = db.Users
                        .OrderBy(y => y.userID)
                        .OrderBy(x => x.IsManager)
                        .ToList();
                dataGridView.DataSource = users;
                dataGridView.Columns["password"].Visible = false;
                dataGridView.Columns["Orders"].Visible = false;
            }
        }
        /*---------------------------------------------------------------    end_AdministratorMenu    ----------------------------------------------------------------*/

        private void dgProducts(List<Product> list)
        {
            dataGridView.DataSource = list;
            dataGridView.Columns["ProductId"].Visible = false;
            dataGridView.Columns["CategoryId"].Visible = false;
            dataGridView.Columns["Category"].Visible = false;
            dataGridView.Columns["Orders"].Visible = false;
            dataGridView.ReadOnly = true;
        }
        private void dgOrders(List<Order> list)
        {
            dataGridView.DataSource = list;
            dataGridView.Columns["userId"].Visible = false;
            dataGridView.Columns["user"].Visible = false;
            dataGridView.Columns["userName"].Visible = false;
            dataGridView.Columns["IsChecked"].Visible = true;
            dataGridView.Columns["Products"].Visible = false;
            dataGridView.ReadOnly = true;
        }

        private void dgOrdersAdmin(List<Order> list)
        {
            dataGridView.DataSource = list;
            dataGridView.Columns["userId"].Visible = false;
            dataGridView.Columns["user"].Visible = false;
            dataGridView.Columns["userName"].Visible = true;
            dataGridView.Columns["IsChecked"].Visible = true;
            dataGridView.Columns["Products"].Visible = false;
            dataGridView.Columns["userId"].ReadOnly = true;
            dataGridView.Columns["userName"].ReadOnly = true;
            dataGridView.Columns["IsChecked"].ReadOnly = true;
        }

        private void menusVisible(bool menuMarketVisible, bool menuShoppingCartVisible, 
            bool menuShoppingHistorVisible, bool categoryStripVisible, bool menuAdministratorVisible)
        {
            menuMarket.Visible = menuMarketVisible;
            menuShoppingCart.Visible = menuShoppingCartVisible;
            menuShoppingHistory.Visible = menuShoppingHistorVisible;
            CategoriesStrip.Visible = categoryStripVisible;
            menuAdministrator.Visible = menuAdministratorVisible;
        }

        private void colorSettings_Load() 
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            var appSettings = ConfigurationManager.AppSettings;
            try
            {
                Color textColor;
                foreach (var item in appSettings.AllKeys)
                {
                    if (appSettings[item] == "backgroundColor") { dataGridView.BackgroundColor = Color.FromName(appSettings[item]); }
                    if (appSettings[item] == "textColor") 
                    { 
                        textColor = Color.FromName(appSettings[item]);
                        MainStrip.ForeColor = textColor;
                        menuMarket.ForeColor = textColor;
                        menuShoppingCart.ForeColor = textColor;
                        menuShoppingHistory.ForeColor = textColor;
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings");
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SolidColorOnly = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["backgroundColor"] == null)
                {
                    settings.Add("backgroundColor", colorDialog.Color.ToKnownColor().ToString());
                }
                else
                {
                    settings["backgroundColor"].Value = colorDialog.Color.ToKnownColor().ToString();
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                dataGridView.BackgroundColor = colorDialog.Color;
                dataGridView.DefaultCellStyle.BackColor = colorDialog.Color;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorDialog.Color;
                dataGridView.RowHeadersDefaultCellStyle.BackColor = colorDialog.Color;
            }
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SolidColorOnly = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["textColor"] == null)
                {
                    settings.Add("textColor", colorDialog.Color.ToKnownColor().ToString());
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                dataGridView.ForeColor = colorDialog.Color;
                dataGridView.DefaultCellStyle.ForeColor = colorDialog.Color;
            }
        }

        private void defaultColorsButton_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["backgroundColor"] != null)
            {
                settings.Remove("backgroundColor");
            }
            if (settings["textColor"] != null)
            {
                settings.Remove("textColor");
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            dataGridView.ForeColor = SystemColors.ControlText;
            dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            MainStrip.ForeColor = SystemColors.ControlText;
            menuMarket.ForeColor = SystemColors.ControlText;
            menuShoppingCart.ForeColor = SystemColors.ControlText;
            menuShoppingHistory.ForeColor = SystemColors.ControlText;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.DefaultCellStyle.BackColor = SystemColors.Control;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
        }
    }
}
