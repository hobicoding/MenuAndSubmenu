namespace ContohLogin
{
    partial class Form2
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasterSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESDELIVERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuItemStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuItemNonStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 212);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERToolStripMenuItem,
            this.tRANSACTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mASTERToolStripMenuItem
            // 
            this.mASTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMasterItem,
            this.menuMasterSupplier});
            this.mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            this.mASTERToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mASTERToolStripMenuItem.Text = "MASTER";
            // 
            // menuMasterItem
            // 
            this.menuMasterItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuItemStandard,
            this.submenuItemNonStandard});
            this.menuMasterItem.Name = "menuMasterItem";
            this.menuMasterItem.Size = new System.Drawing.Size(180, 22);
            this.menuMasterItem.Text = "MASTER ITEM";
            this.menuMasterItem.Click += new System.EventHandler(this.menuMasterItem_Click);
            // 
            // menuMasterSupplier
            // 
            this.menuMasterSupplier.Name = "menuMasterSupplier";
            this.menuMasterSupplier.Size = new System.Drawing.Size(180, 22);
            this.menuMasterSupplier.Text = "MASTER SUPPLIER";
            this.menuMasterSupplier.Click += new System.EventHandler(this.menuMasterSupplier_Click);
            // 
            // tRANSACTIONToolStripMenuItem
            // 
            this.tRANSACTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALESORDERToolStripMenuItem,
            this.sALESDELIVERYToolStripMenuItem,
            this.sALESToolStripMenuItem});
            this.tRANSACTIONToolStripMenuItem.Name = "tRANSACTIONToolStripMenuItem";
            this.tRANSACTIONToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.tRANSACTIONToolStripMenuItem.Text = "TRANSACTION";
            // 
            // sALESORDERToolStripMenuItem
            // 
            this.sALESORDERToolStripMenuItem.Name = "sALESORDERToolStripMenuItem";
            this.sALESORDERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALESORDERToolStripMenuItem.Text = "SALES ORDER";
            // 
            // sALESDELIVERYToolStripMenuItem
            // 
            this.sALESDELIVERYToolStripMenuItem.Name = "sALESDELIVERYToolStripMenuItem";
            this.sALESDELIVERYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALESDELIVERYToolStripMenuItem.Text = "SALES DELIVERY";
            // 
            // sALESToolStripMenuItem
            // 
            this.sALESToolStripMenuItem.Name = "sALESToolStripMenuItem";
            this.sALESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALESToolStripMenuItem.Text = "SALES";
            // 
            // subMenuItemStandard
            // 
            this.subMenuItemStandard.Name = "subMenuItemStandard";
            this.subMenuItemStandard.Size = new System.Drawing.Size(195, 22);
            this.subMenuItemStandard.Text = "ITEM STANDARD";
            this.subMenuItemStandard.Click += new System.EventHandler(this.subMenuItemStandard_Click);
            // 
            // submenuItemNonStandard
            // 
            this.submenuItemNonStandard.Name = "submenuItemNonStandard";
            this.submenuItemNonStandard.Size = new System.Drawing.Size(195, 22);
            this.submenuItemNonStandard.Text = "ITEM NON STANDARD";
            this.submenuItemNonStandard.Click += new System.EventHandler(this.submenuItemNonStandard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMasterItem;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemStandard;
        private System.Windows.Forms.ToolStripMenuItem submenuItemNonStandard;
        private System.Windows.Forms.ToolStripMenuItem menuMasterSupplier;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALESORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALESDELIVERYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALESToolStripMenuItem;
    }
}