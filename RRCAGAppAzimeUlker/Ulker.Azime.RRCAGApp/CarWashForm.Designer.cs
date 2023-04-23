namespace Ulker.Azime.RRCAGApp
{
    partial class CarWashForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtPST = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package:";
            // 
            // cboPackage
            // 
            this.cboPackage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(38, 81);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(187, 24);
            this.cboPackage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // cboFragrance
            // 
            this.cboFragrance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(264, 81);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(187, 24);
            this.cboFragrance.TabIndex = 3;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstInterior.ItemHeight = 16;
            this.lstInterior.Location = new System.Drawing.Point(19, 60);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.Size = new System.Drawing.Size(187, 132);
            this.lstInterior.TabIndex = 4;
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.ItemHeight = 16;
            this.lstExterior.Location = new System.Drawing.Point(245, 60);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.Size = new System.Drawing.Size(187, 132);
            this.lstExterior.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exterior:";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.lstExterior);
            this.grpSummary.Controls.Add(this.lstInterior);
            this.grpSummary.Location = new System.Drawing.Point(19, 146);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(461, 241);
            this.grpSummary.TabIndex = 8;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "PST:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "GST:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Location = new System.Drawing.Point(348, 408);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(132, 29);
            this.txtSubtotal.TabIndex = 13;
            // 
            // txtPST
            // 
            this.txtPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPST.Location = new System.Drawing.Point(348, 445);
            this.txtPST.Multiline = true;
            this.txtPST.Name = "txtPST";
            this.txtPST.Size = new System.Drawing.Size(132, 29);
            this.txtPST.TabIndex = 14;
            // 
            // txtGST
            // 
            this.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGST.Location = new System.Drawing.Point(348, 485);
            this.txtGST.Multiline = true;
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(132, 29);
            this.txtGST.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(348, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(132, 29);
            this.lblTotal.TabIndex = 16;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.mnuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.msFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(46, 24);
            this.msFile.Text = "&File";
            this.msFile.Visible = false;
            // 
            // mnuClose
            // 
            this.mnuClose.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuClose.MergeIndex = 1;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuClose.Size = new System.Drawing.Size(224, 26);
            this.mnuClose.Text = "&Close";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateInvoice});
            this.mnuTools.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuTools.MergeIndex = 2;
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(58, 24);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuGenerateInvoice
            // 
            this.mnuGenerateInvoice.Name = "mnuGenerateInvoice";
            this.mnuGenerateInvoice.Size = new System.Drawing.Size(224, 26);
            this.mnuGenerateInvoice.Text = "Generate &Invoice";
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 583);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.txtPST);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.Text = "Car Wash";
            this.Load += new System.EventHandler(this.CarWashForm_Load);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtPST;
        private System.Windows.Forms.TextBox txtGST;
        protected System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateInvoice;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
    }
}