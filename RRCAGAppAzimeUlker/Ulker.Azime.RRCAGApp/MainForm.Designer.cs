namespace Ulker.Azime.RRCAGApp
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
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpenCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msData = new System.Windows.Forms.ToolStripMenuItem();
            this.msDataVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileOpen,
            this.exitToolStripMenuItem,
            this.msFileExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(46, 24);
            this.msFile.Text = "&File";
            // 
            // msFileOpen
            // 
            this.msFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileOpenSalesQuote,
            this.msFileOpenCarWash});
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.ShowShortcutKeys = false;
            this.msFileOpen.Size = new System.Drawing.Size(169, 26);
            this.msFileOpen.Text = "&Open";
            // 
            // msFileOpenSalesQuote
            // 
            this.msFileOpenSalesQuote.Name = "msFileOpenSalesQuote";
            this.msFileOpenSalesQuote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.msFileOpenSalesQuote.Size = new System.Drawing.Size(221, 26);
            this.msFileOpenSalesQuote.Text = "&Sales Quote";
            // 
            // msFileOpenCarWash
            // 
            this.msFileOpenCarWash.Name = "msFileOpenCarWash";
            this.msFileOpenCarWash.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.msFileOpenCarWash.Size = new System.Drawing.Size(221, 26);
            this.msFileOpenCarWash.Text = "&Car Wash";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 6);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.msFileExit.Size = new System.Drawing.Size(169, 26);
            this.msFileExit.Text = "E&xit";
            // 
            // msData
            // 
            this.msData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDataVehicles});
            this.msData.Name = "msData";
            this.msData.Size = new System.Drawing.Size(55, 24);
            this.msData.Text = "&Data";
            // 
            // msDataVehicles
            // 
            this.msDataVehicles.Name = "msDataVehicles";
            this.msDataVehicles.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.msDataVehicles.Size = new System.Drawing.Size(236, 26);
            this.msDataVehicles.Text = "&Vehicles";
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(55, 24);
            this.msHelp.Text = "&Help";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.Size = new System.Drawing.Size(142, 26);
            this.msHelpAbout.Text = "&About...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msData,
            this.msHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 652);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "RRC Automotive Group";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileOpenSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem msFileOpenCarWash;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msData;
        private System.Windows.Forms.ToolStripMenuItem msDataVehicles;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

