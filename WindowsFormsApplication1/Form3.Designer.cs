namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fORMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXAMFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTDETAILSREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEDETAILSREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXAMDETAILSREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTSDETAILSREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORMSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(28, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(982, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fORMSToolStripMenuItem
            // 
            this.fORMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTFORMToolStripMenuItem,
            this.cOURSEFORMToolStripMenuItem,
            this.eXAMFORMToolStripMenuItem,
            this.rESULTFORMToolStripMenuItem});
            this.fORMSToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fORMSToolStripMenuItem.Name = "fORMSToolStripMenuItem";
            this.fORMSToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.fORMSToolStripMenuItem.Text = "FORMS";
            this.fORMSToolStripMenuItem.Click += new System.EventHandler(this.fORMSToolStripMenuItem_Click);
            // 
            // sTUDENTFORMToolStripMenuItem
            // 
            this.sTUDENTFORMToolStripMenuItem.Name = "sTUDENTFORMToolStripMenuItem";
            this.sTUDENTFORMToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.sTUDENTFORMToolStripMenuItem.Text = "STUDENT FORM";
            this.sTUDENTFORMToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTFORMToolStripMenuItem_Click);
            // 
            // cOURSEFORMToolStripMenuItem
            // 
            this.cOURSEFORMToolStripMenuItem.Name = "cOURSEFORMToolStripMenuItem";
            this.cOURSEFORMToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.cOURSEFORMToolStripMenuItem.Text = "COURSE FORM";
            this.cOURSEFORMToolStripMenuItem.Click += new System.EventHandler(this.cOURSEFORMToolStripMenuItem_Click);
            // 
            // eXAMFORMToolStripMenuItem
            // 
            this.eXAMFORMToolStripMenuItem.Name = "eXAMFORMToolStripMenuItem";
            this.eXAMFORMToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.eXAMFORMToolStripMenuItem.Text = "EXAM FORM";
            this.eXAMFORMToolStripMenuItem.Click += new System.EventHandler(this.eXAMFORMToolStripMenuItem_Click);
            // 
            // rESULTFORMToolStripMenuItem
            // 
            this.rESULTFORMToolStripMenuItem.Name = "rESULTFORMToolStripMenuItem";
            this.rESULTFORMToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.rESULTFORMToolStripMenuItem.Text = "RESULT FORM";
            this.rESULTFORMToolStripMenuItem.Click += new System.EventHandler(this.rESULTFORMToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTDETAILSREPORTToolStripMenuItem,
            this.cOURSEDETAILSREPORTSToolStripMenuItem,
            this.eXAMDETAILSREPORTSToolStripMenuItem,
            this.rESULTSDETAILSREPORTSToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // sTUDENTDETAILSREPORTToolStripMenuItem
            // 
            this.sTUDENTDETAILSREPORTToolStripMenuItem.Name = "sTUDENTDETAILSREPORTToolStripMenuItem";
            this.sTUDENTDETAILSREPORTToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.sTUDENTDETAILSREPORTToolStripMenuItem.Text = "STUDENT  REPORT";
            this.sTUDENTDETAILSREPORTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTDETAILSREPORTToolStripMenuItem_Click);
            // 
            // cOURSEDETAILSREPORTSToolStripMenuItem
            // 
            this.cOURSEDETAILSREPORTSToolStripMenuItem.Name = "cOURSEDETAILSREPORTSToolStripMenuItem";
            this.cOURSEDETAILSREPORTSToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.cOURSEDETAILSREPORTSToolStripMenuItem.Text = "COURSE  REPORTS";
            this.cOURSEDETAILSREPORTSToolStripMenuItem.Click += new System.EventHandler(this.cOURSEDETAILSREPORTSToolStripMenuItem_Click);
            // 
            // eXAMDETAILSREPORTSToolStripMenuItem
            // 
            this.eXAMDETAILSREPORTSToolStripMenuItem.Name = "eXAMDETAILSREPORTSToolStripMenuItem";
            this.eXAMDETAILSREPORTSToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.eXAMDETAILSREPORTSToolStripMenuItem.Text = "EXAM  REPORTS";
            this.eXAMDETAILSREPORTSToolStripMenuItem.Click += new System.EventHandler(this.eXAMDETAILSREPORTSToolStripMenuItem_Click);
            // 
            // rESULTSDETAILSREPORTSToolStripMenuItem
            // 
            this.rESULTSDETAILSREPORTSToolStripMenuItem.Name = "rESULTSDETAILSREPORTSToolStripMenuItem";
            this.rESULTSDETAILSREPORTSToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.rESULTSDETAILSREPORTSToolStripMenuItem.Text = "RESULT  REPORTS";
            this.rESULTSDETAILSREPORTSToolStripMenuItem.Click += new System.EventHandler(this.rESULTSDETAILSREPORTSToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(982, 610);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Examination Management System";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(36F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(14);
            this.Name = "Form3";
            this.Text = "HOME PAGE";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fORMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTFORMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEFORMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXAMFORMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTFORMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTDETAILSREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEDETAILSREPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXAMDETAILSREPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTSDETAILSREPORTSToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}