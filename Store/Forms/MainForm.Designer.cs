namespace Store.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CategoriesStrip = new System.Windows.Forms.MenuStrip();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.marketButton = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingHistoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccauntButton = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.findOrderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOrdersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckedOrdersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultColorsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuShoppingCart = new System.Windows.Forms.MenuStrip();
            this.deleteFromCartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuShoppingHistory = new System.Windows.Forms.MenuStrip();
            this.checkProductsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.makeInvoiceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byOrderIdButton = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bySumButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMarket = new System.Windows.Forms.MenuStrip();
            this.addToCartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrator = new System.Windows.Forms.MenuStrip();
            this.checkProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.isCheckedButton = new System.Windows.Forms.ToolStripMenuItem();
            this.isUncheckedButton = new System.Windows.Forms.ToolStripMenuItem();
            this.isManagerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.isNotManagerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuShoppingHistory.SuspendLayout();
            this.menuMarket.SuspendLayout();
            this.menuAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesStrip
            // 
            this.CategoriesStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CategoriesStrip.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CategoriesStrip.Location = new System.Drawing.Point(0, 28);
            this.CategoriesStrip.Name = "CategoriesStrip";
            this.CategoriesStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.CategoriesStrip.Size = new System.Drawing.Size(781, 24);
            this.CategoriesStrip.TabIndex = 1;
            this.CategoriesStrip.Text = "CategoriesStrip";
            // 
            // MainStrip
            // 
            this.MainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketButton,
            this.shoppingCartButton,
            this.shoppingHistoryButton,
            this.administratorMenuButton,
            this.settingsToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainStrip.Size = new System.Drawing.Size(781, 28);
            this.MainStrip.TabIndex = 4;
            this.MainStrip.Text = "MainStrip";
            // 
            // marketButton
            // 
            this.marketButton.Name = "marketButton";
            this.marketButton.Size = new System.Drawing.Size(69, 24);
            this.marketButton.Text = "Market";
            this.marketButton.Click += new System.EventHandler(this.marketButton_Click);
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(118, 24);
            this.shoppingCartButton.Text = "Shopping Cart";
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // shoppingHistoryButton
            // 
            this.shoppingHistoryButton.Name = "shoppingHistoryButton";
            this.shoppingHistoryButton.Size = new System.Drawing.Size(138, 24);
            this.shoppingHistoryButton.Text = "Shopping History";
            this.shoppingHistoryButton.Click += new System.EventHandler(this.shoppingHistoryButton_Click);
            // 
            // administratorMenuButton
            // 
            this.administratorMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsersButton,
            this.allOrdersButton});
            this.administratorMenuButton.Name = "administratorMenuButton";
            this.administratorMenuButton.Size = new System.Drawing.Size(155, 24);
            this.administratorMenuButton.Text = "Administrator Menu";
            // 
            // allUsersButton
            // 
            this.allUsersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccauntButton,
            this.findUserButton});
            this.allUsersButton.Name = "allUsersButton";
            this.allUsersButton.Size = new System.Drawing.Size(224, 26);
            this.allUsersButton.Text = "All users";
            this.allUsersButton.Click += new System.EventHandler(this.allUsersButton_Click);
            // 
            // createAccauntButton
            // 
            this.createAccauntButton.Name = "createAccauntButton";
            this.createAccauntButton.Size = new System.Drawing.Size(224, 26);
            this.createAccauntButton.Text = "Create accaunt";
            this.createAccauntButton.Click += new System.EventHandler(this.createAccauntButton_Click);
            // 
            // findUserButton
            // 
            this.findUserButton.Name = "findUserButton";
            this.findUserButton.Size = new System.Drawing.Size(224, 26);
            this.findUserButton.Text = "Find user";
            this.findUserButton.Click += new System.EventHandler(this.findUserButton_Click);
            // 
            // allOrdersButton
            // 
            this.allOrdersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findOrderButton,
            this.checkedOrdersButton,
            this.uncheckedOrdersButton});
            this.allOrdersButton.Name = "allOrdersButton";
            this.allOrdersButton.Size = new System.Drawing.Size(224, 26);
            this.allOrdersButton.Text = "All orders";
            this.allOrdersButton.Click += new System.EventHandler(this.allOrdersButton_Click);
            // 
            // findOrderButton
            // 
            this.findOrderButton.Name = "findOrderButton";
            this.findOrderButton.Size = new System.Drawing.Size(224, 26);
            this.findOrderButton.Text = "Find order";
            this.findOrderButton.Click += new System.EventHandler(this.findOrderButton_Click);
            // 
            // checkedOrdersButton
            // 
            this.checkedOrdersButton.Name = "checkedOrdersButton";
            this.checkedOrdersButton.Size = new System.Drawing.Size(224, 26);
            this.checkedOrdersButton.Text = "Checked orders";
            this.checkedOrdersButton.Click += new System.EventHandler(this.checkedOrdersButton_Click);
            // 
            // uncheckedOrdersButton
            // 
            this.uncheckedOrdersButton.Name = "uncheckedOrdersButton";
            this.uncheckedOrdersButton.Size = new System.Drawing.Size(224, 26);
            this.uncheckedOrdersButton.Text = "Unchecked orders";
            this.uncheckedOrdersButton.Click += new System.EventHandler(this.uncheckedOrdersButton_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorButton,
            this.textColorButton,
            this.defaultColorsButton});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(224, 26);
            this.backgroundColorButton.Text = "Background color";
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // textColorButton
            // 
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(224, 26);
            this.textColorButton.Text = "Text color";
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // defaultColorsButton
            // 
            this.defaultColorsButton.Name = "defaultColorsButton";
            this.defaultColorsButton.Size = new System.Drawing.Size(224, 26);
            this.defaultColorsButton.Text = "Default colors";
            this.defaultColorsButton.Click += new System.EventHandler(this.defaultColorsButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 52);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(781, 289);
            this.dataGridView.TabIndex = 5;
            // 
            // menuShoppingCart
            // 
            this.menuShoppingCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuShoppingCart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuShoppingCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFromCartButton,
            this.createOrderButton});
            this.menuShoppingCart.Location = new System.Drawing.Point(0, 341);
            this.menuShoppingCart.Name = "menuShoppingCart";
            this.menuShoppingCart.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuShoppingCart.Size = new System.Drawing.Size(781, 28);
            this.menuShoppingCart.TabIndex = 6;
            this.menuShoppingCart.Text = "ControlStrip";
            // 
            // deleteFromCartButton
            // 
            this.deleteFromCartButton.Name = "deleteFromCartButton";
            this.deleteFromCartButton.Size = new System.Drawing.Size(132, 24);
            this.deleteFromCartButton.Text = "Delete from cart";
            this.deleteFromCartButton.Click += new System.EventHandler(this.deleteFromCartButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(106, 24);
            this.createOrderButton.Text = "Create order";
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // menuShoppingHistory
            // 
            this.menuShoppingHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuShoppingHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuShoppingHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkProductsButton,
            this.makeInvoiceButton,
            this.sortToolStripMenuItem});
            this.menuShoppingHistory.Location = new System.Drawing.Point(0, 369);
            this.menuShoppingHistory.Name = "menuShoppingHistory";
            this.menuShoppingHistory.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuShoppingHistory.Size = new System.Drawing.Size(781, 28);
            this.menuShoppingHistory.TabIndex = 7;
            this.menuShoppingHistory.Text = "menuShoppingHistory";
            // 
            // checkProductsButton
            // 
            this.checkProductsButton.Name = "checkProductsButton";
            this.checkProductsButton.Size = new System.Drawing.Size(124, 24);
            this.checkProductsButton.Text = "Check products";
            this.checkProductsButton.Click += new System.EventHandler(this.checkProductsButton_Click);
            // 
            // makeInvoiceButton
            // 
            this.makeInvoiceButton.Name = "makeInvoiceButton";
            this.makeInvoiceButton.Size = new System.Drawing.Size(110, 24);
            this.makeInvoiceButton.Text = "Make invoice";
            this.makeInvoiceButton.Click += new System.EventHandler(this.makeInvoiceButton_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byOrderIdButton,
            this.byDateButton,
            this.bySumButton});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sortToolStripMenuItem.Text = "Sorting";
            // 
            // byOrderIdButton
            // 
            this.byOrderIdButton.Name = "byOrderIdButton";
            this.byOrderIdButton.Size = new System.Drawing.Size(165, 26);
            this.byOrderIdButton.Text = "By order id";
            this.byOrderIdButton.Click += new System.EventHandler(this.byOrderIdButton_Click);
            // 
            // byDateButton
            // 
            this.byDateButton.Name = "byDateButton";
            this.byDateButton.Size = new System.Drawing.Size(165, 26);
            this.byDateButton.Text = "By date";
            this.byDateButton.Click += new System.EventHandler(this.byDateButton_Click);
            // 
            // bySumButton
            // 
            this.bySumButton.Name = "bySumButton";
            this.bySumButton.Size = new System.Drawing.Size(165, 26);
            this.bySumButton.Text = "By sum";
            this.bySumButton.Click += new System.EventHandler(this.bySumButton_Click);
            // 
            // menuMarket
            // 
            this.menuMarket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuMarket.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMarket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToCartButton});
            this.menuMarket.Location = new System.Drawing.Point(0, 397);
            this.menuMarket.Name = "menuMarket";
            this.menuMarket.Size = new System.Drawing.Size(781, 28);
            this.menuMarket.TabIndex = 8;
            this.menuMarket.Text = "menuMarket";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(98, 24);
            this.addToCartButton.Text = "Add to cart";
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // menuAdministrator
            // 
            this.menuAdministrator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuAdministrator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkProducts,
            this.isCheckedButton,
            this.isUncheckedButton,
            this.isManagerButton,
            this.isNotManagerButton});
            this.menuAdministrator.Location = new System.Drawing.Point(0, 425);
            this.menuAdministrator.Name = "menuAdministrator";
            this.menuAdministrator.Size = new System.Drawing.Size(781, 28);
            this.menuAdministrator.TabIndex = 9;
            this.menuAdministrator.Text = "menuStrip1";
            // 
            // checkProducts
            // 
            this.checkProducts.Name = "checkProducts";
            this.checkProducts.Size = new System.Drawing.Size(124, 24);
            this.checkProducts.Text = "Check products";
            this.checkProducts.Click += new System.EventHandler(this.checkProductsButton_Click);
            // 
            // isCheckedButton
            // 
            this.isCheckedButton.Name = "isCheckedButton";
            this.isCheckedButton.Size = new System.Drawing.Size(91, 24);
            this.isCheckedButton.Text = "Is checked";
            this.isCheckedButton.Click += new System.EventHandler(this.isCheckedButton_Click);
            // 
            // isUncheckedButton
            // 
            this.isUncheckedButton.Name = "isUncheckedButton";
            this.isUncheckedButton.Size = new System.Drawing.Size(107, 24);
            this.isUncheckedButton.Text = "Is unchecked";
            this.isUncheckedButton.Click += new System.EventHandler(this.isUncheckedButton_Click);
            // 
            // isManagerButton
            // 
            this.isManagerButton.Name = "isManagerButton";
            this.isManagerButton.Size = new System.Drawing.Size(96, 24);
            this.isManagerButton.Text = "Is manager";
            this.isManagerButton.Click += new System.EventHandler(this.isManagerButton_Click);
            // 
            // isNotManagerButton
            // 
            this.isNotManagerButton.Name = "isNotManagerButton";
            this.isNotManagerButton.Size = new System.Drawing.Size(122, 24);
            this.isNotManagerButton.Text = "Is not manager";
            this.isNotManagerButton.Click += new System.EventHandler(this.isNotManagerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CategoriesStrip);
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.menuShoppingCart);
            this.Controls.Add(this.menuShoppingHistory);
            this.Controls.Add(this.menuMarket);
            this.Controls.Add(this.menuAdministrator);
            this.MainMenuStrip = this.CategoriesStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuShoppingCart.ResumeLayout(false);
            this.menuShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuShoppingHistory.ResumeLayout(false);
            this.menuShoppingHistory.PerformLayout();
            this.menuMarket.ResumeLayout(false);
            this.menuMarket.PerformLayout();
            this.menuAdministrator.ResumeLayout(false);
            this.menuAdministrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.MenuStrip CategoriesStrip;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem marketButton;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartButton;
        private System.Windows.Forms.ToolStripMenuItem shoppingHistoryButton;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuShoppingCart;
        private System.Windows.Forms.ToolStripMenuItem deleteFromCartButton;
        private System.Windows.Forms.ToolStripMenuItem createOrderButton;
        private System.Windows.Forms.MenuStrip menuShoppingHistory;
        private System.Windows.Forms.ToolStripMenuItem checkProductsButton;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byOrderIdButton;
        private System.Windows.Forms.ToolStripMenuItem byDateButton;
        private System.Windows.Forms.ToolStripMenuItem bySumButton;
        private System.Windows.Forms.ToolStripMenuItem administratorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem allUsersButton;
        private System.Windows.Forms.ToolStripMenuItem allOrdersButton;
        private System.Windows.Forms.ToolStripMenuItem createAccauntButton;
        private System.Windows.Forms.MenuStrip menuMarket;
        private System.Windows.Forms.ToolStripMenuItem addToCartButton;
        private System.Windows.Forms.ToolStripMenuItem findUserButton;
        private System.Windows.Forms.ToolStripMenuItem findOrderButton;
        private System.Windows.Forms.ToolStripMenuItem checkedOrdersButton;
        private System.Windows.Forms.ToolStripMenuItem uncheckedOrdersButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorButton;
        private System.Windows.Forms.ToolStripMenuItem textColorButton;
        private System.Windows.Forms.ToolStripMenuItem defaultColorsButton;
        private System.Windows.Forms.ToolStripMenuItem makeInvoiceButton;
        private System.Windows.Forms.MenuStrip menuAdministrator;
        private System.Windows.Forms.ToolStripMenuItem checkProducts;
        private System.Windows.Forms.ToolStripMenuItem isCheckedButton;
        private System.Windows.Forms.ToolStripMenuItem isUncheckedButton;
        private System.Windows.Forms.ToolStripMenuItem isManagerButton;
        private System.Windows.Forms.ToolStripMenuItem isNotManagerButton;
    }
}