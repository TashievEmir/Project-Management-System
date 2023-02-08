namespace Project_Management_System
{
    partial class Form_CreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateProject));
            this.lbC_ProjectName = new DevExpress.XtraEditors.LabelControl();
            this.lbC_prPurpose = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbC_status = new DevExpress.XtraEditors.LabelControl();
            this.lbC_startDate = new DevExpress.XtraEditors.LabelControl();
            this.lbC_EndDate = new DevExpress.XtraEditors.LabelControl();
            this.lbC_Payment = new DevExpress.XtraEditors.LabelControl();
            this.lbC_teamAmount = new DevExpress.XtraEditors.LabelControl();
            this.tEdit_projectName = new DevExpress.XtraEditors.TextEdit();
            this.tEd_prPurpose = new DevExpress.XtraEditors.TextEdit();
            this.tEd_payment = new DevExpress.XtraEditors.TextEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.cLB_projectStatus = new System.Windows.Forms.CheckedListBox();
            this.nUD_teamAmount = new System.Windows.Forms.NumericUpDown();
            this.lC_projectType = new DevExpress.XtraEditors.LabelControl();
            this.grB = new System.Windows.Forms.GroupBox();
            this.rBt_yearly = new System.Windows.Forms.RadioButton();
            this.rBt_monthly = new System.Windows.Forms.RadioButton();
            this.rBt_weekly = new System.Windows.Forms.RadioButton();
            this.lC_forCreatePr = new DevExpress.XtraEditors.LabelControl();
            this.cB_managers = new System.Windows.Forms.ComboBox();
            this.cB_prTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tEdit_projectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_prPurpose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_payment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_teamAmount)).BeginInit();
            this.grB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbC_ProjectName
            // 
            this.lbC_ProjectName.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_ProjectName.Appearance.Options.UseFont = true;
            this.lbC_ProjectName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_ProjectName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_ProjectName.ImageOptions.Image")));
            this.lbC_ProjectName.Location = new System.Drawing.Point(21, 77);
            this.lbC_ProjectName.Name = "lbC_ProjectName";
            this.lbC_ProjectName.Size = new System.Drawing.Size(150, 36);
            this.lbC_ProjectName.TabIndex = 0;
            this.lbC_ProjectName.Text = "Project Name:";
            // 
            // lbC_prPurpose
            // 
            this.lbC_prPurpose.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_prPurpose.Appearance.Options.UseFont = true;
            this.lbC_prPurpose.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_prPurpose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_prPurpose.ImageOptions.Image")));
            this.lbC_prPurpose.Location = new System.Drawing.Point(6, 134);
            this.lbC_prPurpose.Name = "lbC_prPurpose";
            this.lbC_prPurpose.Size = new System.Drawing.Size(166, 36);
            this.lbC_prPurpose.TabIndex = 2;
            this.lbC_prPurpose.Text = "Project Purpose:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.ImageOptions.Image")));
            this.labelControl3.Location = new System.Drawing.Point(-1, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 36);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Project Manager:";
            // 
            // lbC_status
            // 
            this.lbC_status.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_status.Appearance.Options.UseFont = true;
            this.lbC_status.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_status.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_status.ImageOptions.Image")));
            this.lbC_status.Location = new System.Drawing.Point(13, 246);
            this.lbC_status.Name = "lbC_status";
            this.lbC_status.Size = new System.Drawing.Size(159, 36);
            this.lbC_status.TabIndex = 4;
            this.lbC_status.Text = "Project Status:";
            // 
            // lbC_startDate
            // 
            this.lbC_startDate.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_startDate.Appearance.Options.UseFont = true;
            this.lbC_startDate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_startDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_startDate.ImageOptions.Image")));
            this.lbC_startDate.Location = new System.Drawing.Point(347, 77);
            this.lbC_startDate.Name = "lbC_startDate";
            this.lbC_startDate.Size = new System.Drawing.Size(189, 36);
            this.lbC_startDate.TabIndex = 5;
            this.lbC_startDate.Text = "Project StartDate:";
            // 
            // lbC_EndDate
            // 
            this.lbC_EndDate.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_EndDate.Appearance.Options.UseFont = true;
            this.lbC_EndDate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_EndDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_EndDate.ImageOptions.Image")));
            this.lbC_EndDate.Location = new System.Drawing.Point(364, 134);
            this.lbC_EndDate.Name = "lbC_EndDate";
            this.lbC_EndDate.Size = new System.Drawing.Size(172, 36);
            this.lbC_EndDate.TabIndex = 6;
            this.lbC_EndDate.Text = "Project EndDate:";
            // 
            // lbC_Payment
            // 
            this.lbC_Payment.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_Payment.Appearance.Options.UseFont = true;
            this.lbC_Payment.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_Payment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_Payment.ImageOptions.Image")));
            this.lbC_Payment.Location = new System.Drawing.Point(428, 187);
            this.lbC_Payment.Name = "lbC_Payment";
            this.lbC_Payment.Size = new System.Drawing.Size(108, 36);
            this.lbC_Payment.TabIndex = 7;
            this.lbC_Payment.Text = "Payment:";
            // 
            // lbC_teamAmount
            // 
            this.lbC_teamAmount.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_teamAmount.Appearance.Options.UseFont = true;
            this.lbC_teamAmount.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbC_teamAmount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_teamAmount.ImageOptions.Image")));
            this.lbC_teamAmount.Location = new System.Drawing.Point(11, 292);
            this.lbC_teamAmount.Name = "lbC_teamAmount";
            this.lbC_teamAmount.Size = new System.Drawing.Size(160, 36);
            this.lbC_teamAmount.TabIndex = 8;
            this.lbC_teamAmount.Text = "Team\'s amount:";
            // 
            // tEdit_projectName
            // 
            this.tEdit_projectName.CausesValidation = false;
            this.tEdit_projectName.Location = new System.Drawing.Point(177, 80);
            this.tEdit_projectName.Name = "tEdit_projectName";
            this.tEdit_projectName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.tEdit_projectName.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEdit_projectName.Properties.Appearance.Options.UseFont = true;
            this.tEdit_projectName.Properties.HideSelection = false;
            this.tEdit_projectName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tEdit_projectName.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tEdit_projectName.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.tEdit_projectName.Properties.MaskSettings.Set("placeholder", '\0');
            this.tEdit_projectName.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tEdit_projectName.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly;
            this.tEdit_projectName.Properties.ValidateOnEnterKey = true;
            this.tEdit_projectName.Size = new System.Drawing.Size(151, 30);
            this.tEdit_projectName.TabIndex = 10;
            // 
            // tEd_prPurpose
            // 
            this.tEd_prPurpose.CausesValidation = false;
            this.tEd_prPurpose.Location = new System.Drawing.Point(178, 137);
            this.tEd_prPurpose.Name = "tEd_prPurpose";
            this.tEd_prPurpose.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEd_prPurpose.Properties.Appearance.Options.UseFont = true;
            this.tEd_prPurpose.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tEd_prPurpose.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tEd_prPurpose.Properties.MaskSettings.Set("mask", ".+");
            this.tEd_prPurpose.Properties.MaskSettings.Set("placeholder", '\0');
            this.tEd_prPurpose.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tEd_prPurpose.Size = new System.Drawing.Size(150, 30);
            this.tEd_prPurpose.TabIndex = 12;
            // 
            // tEd_payment
            // 
            this.tEd_payment.CausesValidation = false;
            this.tEd_payment.Location = new System.Drawing.Point(547, 193);
            this.tEd_payment.Name = "tEd_payment";
            this.tEd_payment.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEd_payment.Properties.Appearance.Options.UseFont = true;
            this.tEd_payment.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tEd_payment.Properties.MaskSettings.Set("mask", "c");
            this.tEd_payment.Size = new System.Drawing.Size(160, 30);
            this.tEd_payment.TabIndex = 13;
            // 
            // startDate
            // 
            this.startDate.CausesValidation = false;
            this.startDate.EditValue = null;
            this.startDate.Location = new System.Drawing.Point(547, 80);
            this.startDate.Name = "startDate";
            this.startDate.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Properties.Appearance.Options.UseFont = true;
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Properties.MaskSettings.Set("mask", "d");
            this.startDate.Size = new System.Drawing.Size(160, 30);
            this.startDate.TabIndex = 14;
            // 
            // endDate
            // 
            this.endDate.CausesValidation = false;
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(547, 137);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Properties.Appearance.Options.UseFont = true;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.MaskSettings.Set("mask", "d");
            this.endDate.Size = new System.Drawing.Size(160, 30);
            this.endDate.TabIndex = 15;
            // 
            // cLB_projectStatus
            // 
            this.cLB_projectStatus.CausesValidation = false;
            this.cLB_projectStatus.CheckOnClick = true;
            this.cLB_projectStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLB_projectStatus.FormattingEnabled = true;
            this.cLB_projectStatus.Items.AddRange(new object[] {
            "not started",
            "in process",
            "completed"});
            this.cLB_projectStatus.Location = new System.Drawing.Point(178, 248);
            this.cLB_projectStatus.Name = "cLB_projectStatus";
            this.cLB_projectStatus.ScrollAlwaysVisible = true;
            this.cLB_projectStatus.Size = new System.Drawing.Size(150, 29);
            this.cLB_projectStatus.TabIndex = 16;
            // 
            // nUD_teamAmount
            // 
            this.nUD_teamAmount.CausesValidation = false;
            this.nUD_teamAmount.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUD_teamAmount.Location = new System.Drawing.Point(178, 296);
            this.nUD_teamAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_teamAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_teamAmount.Name = "nUD_teamAmount";
            this.nUD_teamAmount.Size = new System.Drawing.Size(150, 30);
            this.nUD_teamAmount.TabIndex = 17;
            this.nUD_teamAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lC_projectType
            // 
            this.lC_projectType.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lC_projectType.Appearance.Options.UseFont = true;
            this.lC_projectType.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lC_projectType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lC_projectType.ImageOptions.Image")));
            this.lC_projectType.Location = new System.Drawing.Point(30, 336);
            this.lC_projectType.Name = "lC_projectType";
            this.lC_projectType.Size = new System.Drawing.Size(142, 36);
            this.lC_projectType.TabIndex = 19;
            this.lC_projectType.Text = "Project type:";
            // 
            // grB
            // 
            this.grB.Controls.Add(this.rBt_yearly);
            this.grB.Controls.Add(this.rBt_monthly);
            this.grB.Controls.Add(this.rBt_weekly);
            this.grB.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grB.Location = new System.Drawing.Point(412, 248);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(237, 130);
            this.grB.TabIndex = 22;
            this.grB.TabStop = false;
            this.grB.Text = "Payment type:";
            // 
            // rBt_yearly
            // 
            this.rBt_yearly.AutoSize = true;
            this.rBt_yearly.CausesValidation = false;
            this.rBt_yearly.Location = new System.Drawing.Point(148, 94);
            this.rBt_yearly.Name = "rBt_yearly";
            this.rBt_yearly.Size = new System.Drawing.Size(76, 27);
            this.rBt_yearly.TabIndex = 2;
            this.rBt_yearly.Text = "yearly";
            this.rBt_yearly.UseVisualStyleBackColor = true;
            // 
            // rBt_monthly
            // 
            this.rBt_monthly.AutoSize = true;
            this.rBt_monthly.CausesValidation = false;
            this.rBt_monthly.Location = new System.Drawing.Point(148, 48);
            this.rBt_monthly.Name = "rBt_monthly";
            this.rBt_monthly.Size = new System.Drawing.Size(86, 27);
            this.rBt_monthly.TabIndex = 1;
            this.rBt_monthly.Text = "monthly";
            this.rBt_monthly.UseVisualStyleBackColor = true;
            // 
            // rBt_weekly
            // 
            this.rBt_weekly.AutoSize = true;
            this.rBt_weekly.CausesValidation = false;
            this.rBt_weekly.Location = new System.Drawing.Point(148, 2);
            this.rBt_weekly.Name = "rBt_weekly";
            this.rBt_weekly.Size = new System.Drawing.Size(79, 27);
            this.rBt_weekly.TabIndex = 0;
            this.rBt_weekly.Text = "weekly";
            this.rBt_weekly.UseVisualStyleBackColor = true;
            // 
            // lC_forCreatePr
            // 
            this.lC_forCreatePr.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lC_forCreatePr.Appearance.Options.UseFont = true;
            this.lC_forCreatePr.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lC_forCreatePr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lC_forCreatePr.ImageOptions.Image")));
            this.lC_forCreatePr.Location = new System.Drawing.Point(183, 25);
            this.lC_forCreatePr.Name = "lC_forCreatePr";
            this.lC_forCreatePr.Size = new System.Drawing.Size(390, 36);
            this.lC_forCreatePr.TabIndex = 23;
            this.lC_forCreatePr.Text = "For create project fill all blanket!";
            // 
            // cB_managers
            // 
            this.cB_managers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_managers.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_managers.FormattingEnabled = true;
            this.cB_managers.Location = new System.Drawing.Point(177, 190);
            this.cB_managers.Name = "cB_managers";
            this.cB_managers.Size = new System.Drawing.Size(151, 31);
            this.cB_managers.TabIndex = 24;
            // 
            // cB_prTypes
            // 
            this.cB_prTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_prTypes.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_prTypes.FormattingEnabled = true;
            this.cB_prTypes.Location = new System.Drawing.Point(177, 339);
            this.cB_prTypes.Name = "cB_prTypes";
            this.cB_prTypes.Size = new System.Drawing.Size(150, 31);
            this.cB_prTypes.TabIndex = 25;
            // 
            // Form_CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(744, 401);
            this.Controls.Add(this.cB_prTypes);
            this.Controls.Add(this.cB_managers);
            this.Controls.Add(this.lC_forCreatePr);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.lC_projectType);
            this.Controls.Add(this.nUD_teamAmount);
            this.Controls.Add(this.cLB_projectStatus);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.tEd_payment);
            this.Controls.Add(this.tEd_prPurpose);
            this.Controls.Add(this.tEdit_projectName);
            this.Controls.Add(this.lbC_teamAmount);
            this.Controls.Add(this.lbC_Payment);
            this.Controls.Add(this.lbC_EndDate);
            this.Controls.Add(this.lbC_startDate);
            this.Controls.Add(this.lbC_status);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbC_prPurpose);
            this.Controls.Add(this.lbC_ProjectName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.Name = "Form_CreateProject";
            this.Text = "Form_CreateProject";
            ((System.ComponentModel.ISupportInitialize)(this.tEdit_projectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_prPurpose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_payment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_teamAmount)).EndInit();
            this.grB.ResumeLayout(false);
            this.grB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbC_ProjectName;
        private DevExpress.XtraEditors.LabelControl lbC_prPurpose;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbC_status;
        private DevExpress.XtraEditors.LabelControl lbC_startDate;
        private DevExpress.XtraEditors.LabelControl lbC_EndDate;
        private DevExpress.XtraEditors.LabelControl lbC_Payment;
        private DevExpress.XtraEditors.LabelControl lbC_teamAmount;
        private DevExpress.XtraEditors.LabelControl lC_projectType;
        public System.Windows.Forms.GroupBox grB;
        private DevExpress.XtraEditors.LabelControl lC_forCreatePr;
        public DevExpress.XtraEditors.TextEdit tEdit_projectName;
        public DevExpress.XtraEditors.TextEdit tEd_prPurpose;
        public System.Windows.Forms.CheckedListBox cLB_projectStatus;
        public System.Windows.Forms.NumericUpDown nUD_teamAmount;
        public DevExpress.XtraEditors.TextEdit tEd_payment;
        public DevExpress.XtraEditors.DateEdit startDate;
        public DevExpress.XtraEditors.DateEdit endDate;
        public System.Windows.Forms.RadioButton rBt_yearly;
        public System.Windows.Forms.RadioButton rBt_monthly;
        public System.Windows.Forms.RadioButton rBt_weekly;
        public System.Windows.Forms.ComboBox cB_managers;
        public System.Windows.Forms.ComboBox cB_prTypes;
    }
}