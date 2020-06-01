namespace Store.Forms
{
    partial class CheckingOrderForm
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
            this.CheckingOrderDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CheckingOrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckingOrderDataGrid
            // 
            this.CheckingOrderDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CheckingOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckingOrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckingOrderDataGrid.Location = new System.Drawing.Point(0, 0);
            this.CheckingOrderDataGrid.Name = "CheckingOrderDataGrid";
            this.CheckingOrderDataGrid.RowHeadersWidth = 51;
            this.CheckingOrderDataGrid.RowTemplate.Height = 24;
            this.CheckingOrderDataGrid.Size = new System.Drawing.Size(800, 450);
            this.CheckingOrderDataGrid.TabIndex = 0;
            // 
            // CheckingOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckingOrderDataGrid);
            this.Name = "CheckingOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products in order";
            this.Load += new System.EventHandler(this.CheckingOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckingOrderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CheckingOrderDataGrid;
    }
}