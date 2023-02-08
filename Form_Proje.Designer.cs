using System.Windows.Forms;

namespace Project_Management_System
{
    partial class Form_Proje
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
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Proje));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tSBtn_Back = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Forward = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_New = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Save = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Milestones = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_NewMilestones = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sBtn_Employee = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_ProjectTask = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_Project = new DevExpress.XtraEditors.SimpleButton();
            this.lbC_PLanning = new DevExpress.XtraEditors.LabelControl();
            this.fLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.tSBtn_PhoneNumber = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.fLPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(178)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtn_Back,
            this.tSBtn_Forward,
            this.tSBtn_New,
            this.tSBtn_Save,
            this.tSBtn_Delete,
            this.tSBtn_Milestones,
            this.tSBtn_Refresh,
            this.tSBtn_NewMilestones,
            this.tSBtn_PhoneNumber});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1079, 81);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tSBtn_Back
            // 
            this.tSBtn_Back.AutoToolTip = false;
            this.tSBtn_Back.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_Back.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Back.Image")));
            this.tSBtn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Back.Name = "tSBtn_Back";
            this.tSBtn_Back.Size = new System.Drawing.Size(50, 78);
            this.tSBtn_Back.Text = "Back";
            this.tSBtn_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_Back.ToolTipText = "back";
            this.tSBtn_Back.Click += new System.EventHandler(this.tSBtn_Back_Click);
            // 
            // tSBtn_Forward
            // 
            this.tSBtn_Forward.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_Forward.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Forward.Image")));
            this.tSBtn_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Forward.Name = "tSBtn_Forward";
            this.tSBtn_Forward.Size = new System.Drawing.Size(77, 78);
            this.tSBtn_Forward.Text = "Forward";
            this.tSBtn_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Forward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tSBtn_New
            // 
            this.tSBtn_New.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_New.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_New.Image")));
            this.tSBtn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_New.Name = "tSBtn_New";
            this.tSBtn_New.Size = new System.Drawing.Size(47, 78);
            this.tSBtn_New.Text = "New";
            this.tSBtn_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_New.Click += new System.EventHandler(this.tSBtn_New_Click);
            // 
            // tSBtn_Save
            // 
            this.tSBtn_Save.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSBtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Save.Image")));
            this.tSBtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Save.Name = "tSBtn_Save";
            this.tSBtn_Save.Size = new System.Drawing.Size(51, 78);
            this.tSBtn_Save.Text = "Save";
            this.tSBtn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_Save.Click += new System.EventHandler(this.tSBtn_Save_Click);
            // 
            // tSBtn_Delete
            // 
            this.tSBtn_Delete.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Delete.Image")));
            this.tSBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Delete.Name = "tSBtn_Delete";
            this.tSBtn_Delete.Size = new System.Drawing.Size(65, 78);
            this.tSBtn_Delete.Text = "Delete";
            this.tSBtn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_Delete.Click += new System.EventHandler(this.tSBtn_Delete_Click);
            // 
            // tSBtn_Milestones
            // 
            this.tSBtn_Milestones.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_Milestones.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Milestones.Image")));
            this.tSBtn_Milestones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Milestones.Name = "tSBtn_Milestones";
            this.tSBtn_Milestones.Size = new System.Drawing.Size(94, 78);
            this.tSBtn_Milestones.Text = "Milestones";
            this.tSBtn_Milestones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Milestones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_Milestones.Click += new System.EventHandler(this.tSBtn_Cancel_Click);
            // 
            // tSBtn_Refresh
            // 
            this.tSBtn_Refresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Refresh.Image")));
            this.tSBtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Refresh.Name = "tSBtn_Refresh";
            this.tSBtn_Refresh.Size = new System.Drawing.Size(75, 78);
            this.tSBtn_Refresh.Text = "Refresh";
            this.tSBtn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_Refresh.Click += new System.EventHandler(this.tSBtn_Refresh_Click);
            // 
            // tSBtn_NewMilestones
            // 
            this.tSBtn_NewMilestones.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_NewMilestones.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_NewMilestones.Image")));
            this.tSBtn_NewMilestones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_NewMilestones.Name = "tSBtn_NewMilestones";
            this.tSBtn_NewMilestones.Size = new System.Drawing.Size(125, 78);
            this.tSBtn_NewMilestones.Text = "New Milestones";
            this.tSBtn_NewMilestones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_NewMilestones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_NewMilestones.ToolTipText = "Previous Record\r\n";
            this.tSBtn_NewMilestones.Click += new System.EventHandler(this.tSBtn_NewMilestones_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // sBtn_Employee
            // 
            this.sBtn_Employee.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sBtn_Employee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.sBtn_Employee.Appearance.Options.UseFont = true;
            this.sBtn_Employee.Appearance.Options.UseForeColor = true;
            this.sBtn_Employee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sBtn_Employee.ImageOptions.Image")));
            this.sBtn_Employee.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sBtn_Employee.Location = new System.Drawing.Point(3, 227);
            this.sBtn_Employee.Name = "sBtn_Employee";
            this.sBtn_Employee.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sBtn_Employee.Size = new System.Drawing.Size(197, 65);
            this.sBtn_Employee.TabIndex = 3;
            this.sBtn_Employee.Text = "Employee";
            this.sBtn_Employee.Click += new System.EventHandler(this.sBtn_Employee_Click);
            // 
            // sBtn_ProjectTask
            // 
            this.sBtn_ProjectTask.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sBtn_ProjectTask.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.sBtn_ProjectTask.Appearance.Options.UseFont = true;
            this.sBtn_ProjectTask.Appearance.Options.UseForeColor = true;
            this.sBtn_ProjectTask.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sBtn_ProjectTask.ImageOptions.Image")));
            this.sBtn_ProjectTask.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sBtn_ProjectTask.Location = new System.Drawing.Point(3, 159);
            this.sBtn_ProjectTask.Name = "sBtn_ProjectTask";
            this.sBtn_ProjectTask.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sBtn_ProjectTask.Size = new System.Drawing.Size(197, 62);
            this.sBtn_ProjectTask.TabIndex = 2;
            this.sBtn_ProjectTask.Text = "Project Task";
            this.sBtn_ProjectTask.Click += new System.EventHandler(this.sBtn_ProjectTask_Click);
            // 
            // sBtn_Project
            // 
            this.sBtn_Project.AllowDrop = true;
            this.sBtn_Project.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sBtn_Project.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.sBtn_Project.Appearance.Options.UseFont = true;
            this.sBtn_Project.Appearance.Options.UseForeColor = true;
            this.sBtn_Project.AutoWidthInLayoutControl = true;
            this.sBtn_Project.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sBtn_Project.ImageOptions.Image")));
            this.sBtn_Project.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sBtn_Project.Location = new System.Drawing.Point(3, 89);
            this.sBtn_Project.Name = "sBtn_Project";
            this.sBtn_Project.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sBtn_Project.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sBtn_Project.Size = new System.Drawing.Size(197, 64);
            this.sBtn_Project.TabIndex = 1;
            this.sBtn_Project.Text = "Project";
            this.sBtn_Project.Click += new System.EventHandler(this.sBtn_Project_Click);
            // 
            // lbC_PLanning
            // 
            this.lbC_PLanning.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_PLanning.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.lbC_PLanning.Appearance.Options.UseFont = true;
            this.lbC_PLanning.Appearance.Options.UseForeColor = true;
            this.lbC_PLanning.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_PLanning.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_PLanning.ImageOptions.Image")));
            this.lbC_PLanning.Location = new System.Drawing.Point(9, 18);
            this.lbC_PLanning.Name = "lbC_PLanning";
            this.lbC_PLanning.Size = new System.Drawing.Size(117, 36);
            this.lbC_PLanning.TabIndex = 0;
            this.lbC_PLanning.Text = "Planning";
            this.lbC_PLanning.Click += new System.EventHandler(this.lbC_PLanning_Click);
            // 
            // fLPanel
            // 
            this.fLPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.fLPanel.Controls.Add(this.panel1);
            this.fLPanel.Controls.Add(this.sBtn_Project);
            this.fLPanel.Controls.Add(this.sBtn_ProjectTask);
            this.fLPanel.Controls.Add(this.sBtn_Employee);
            this.fLPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanel.Location = new System.Drawing.Point(0, 109);
            this.fLPanel.MaximumSize = new System.Drawing.Size(200, 0);
            this.fLPanel.MinimumSize = new System.Drawing.Size(50, 0);
            this.fLPanel.Name = "fLPanel";
            this.fLPanel.Size = new System.Drawing.Size(200, 489);
            this.fLPanel.TabIndex = 5;
            this.fLPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbC_PLanning);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 80);
            this.panel1.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.OnMouseUp;
            this.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // tSBtn_PhoneNumber
            // 
            this.tSBtn_PhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtn_PhoneNumber.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_PhoneNumber.Image")));
            this.tSBtn_PhoneNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_PhoneNumber.Name = "tSBtn_PhoneNumber";
            this.tSBtn_PhoneNumber.Size = new System.Drawing.Size(125, 78);
            this.tSBtn_PhoneNumber.Text = "PhoneNumbers";
            this.tSBtn_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tSBtn_PhoneNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBtn_PhoneNumber.Click += new System.EventHandler(this.tSBtn_PhoneNumber_Click);
            // 
            // Form_Proje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 598);
            this.Controls.Add(this.fLPanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Proje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Management System";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fLPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tSBtn_Back;
        private System.Windows.Forms.ToolStripButton tSBtn_Forward;
        private System.Windows.Forms.ToolStripButton tSBtn_New;
        private System.Windows.Forms.ToolStripButton tSBtn_Save;
        private System.Windows.Forms.ToolStripButton tSBtn_Delete;
        private System.Windows.Forms.ToolStripButton tSBtn_Milestones;
        private System.Windows.Forms.ToolStripButton tSBtn_Refresh;
        private System.Windows.Forms.ToolStripButton tSBtn_NewMilestones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton sBtn_Project;
        private DevExpress.XtraEditors.LabelControl lbC_PLanning;
        private DevExpress.XtraEditors.SimpleButton sBtn_Employee;
        private DevExpress.XtraEditors.SimpleButton sBtn_ProjectTask;
        private System.Windows.Forms.FlowLayoutPanel fLPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private ToolStripButton tSBtn_PhoneNumber;
    }
}