namespace Project_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.tB_Nickname = new System.Windows.Forms.TextBox();
            this.lb_NicknameSignInPage = new System.Windows.Forms.Label();
            this.lb_PasswordSignInPage = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lbC_inform = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(178)))));
            this.btn_SignIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_SignIn.Location = new System.Drawing.Point(235, 412);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(120, 39);
            this.btn_SignIn.TabIndex = 8;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // tB_Password
            // 
            this.tB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Password.Location = new System.Drawing.Point(328, 340);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(233, 30);
            this.tB_Password.TabIndex = 9;
            this.tB_Password.UseSystemPasswordChar = true;
            // 
            // tB_Nickname
            // 
            this.tB_Nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Nickname.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Nickname.Location = new System.Drawing.Point(329, 257);
            this.tB_Nickname.Name = "tB_Nickname";
            this.tB_Nickname.Size = new System.Drawing.Size(232, 30);
            this.tB_Nickname.TabIndex = 10;
            // 
            // lb_NicknameSignInPage
            // 
            this.lb_NicknameSignInPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NicknameSignInPage.AutoSize = true;
            this.lb_NicknameSignInPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.lb_NicknameSignInPage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NicknameSignInPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.lb_NicknameSignInPage.Location = new System.Drawing.Point(220, 257);
            this.lb_NicknameSignInPage.Name = "lb_NicknameSignInPage";
            this.lb_NicknameSignInPage.Size = new System.Drawing.Size(107, 27);
            this.lb_NicknameSignInPage.TabIndex = 11;
            this.lb_NicknameSignInPage.Text = "Nickname:";
            // 
            // lb_PasswordSignInPage
            // 
            this.lb_PasswordSignInPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_PasswordSignInPage.AutoSize = true;
            this.lb_PasswordSignInPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.lb_PasswordSignInPage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_PasswordSignInPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.lb_PasswordSignInPage.Location = new System.Drawing.Point(220, 340);
            this.lb_PasswordSignInPage.Name = "lb_PasswordSignInPage";
            this.lb_PasswordSignInPage.Size = new System.Drawing.Size(102, 27);
            this.lb_PasswordSignInPage.TabIndex = 12;
            this.lb_PasswordSignInPage.Text = "Password:";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.lb_Welcome.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.lb_Welcome.Location = new System.Drawing.Point(49, 100);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(482, 29);
            this.lb_Welcome.TabIndex = 13;
            this.lb_Welcome.Text = "Welcome to the Project Management System!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(269, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please sign in to your account";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(40, 201);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(163, 169);
            this.pictureEdit1.TabIndex = 16;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(246, 26);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(61, 56);
            this.pictureEdit2.TabIndex = 17;
            // 
            // lbC_inform
            // 
            this.lbC_inform.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC_inform.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.lbC_inform.Appearance.Options.UseFont = true;
            this.lbC_inform.Appearance.Options.UseForeColor = true;
            this.lbC_inform.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lbC_inform.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbC_inform.ImageOptions.Image")));
            this.lbC_inform.Location = new System.Drawing.Point(99, 487);
            this.lbC_inform.Name = "lbC_inform";
            this.lbC_inform.Size = new System.Drawing.Size(410, 36);
            this.lbC_inform.TabIndex = 18;
            this.lbC_inform.Text = "If you don\'t have account inform your manager!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lbC_inform);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.lb_PasswordSignInPage);
            this.Controls.Add(this.lb_NicknameSignInPage);
            this.Controls.Add(this.tB_Nickname);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.btn_SignIn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB_Nickname;
        private System.Windows.Forms.Label lb_NicknameSignInPage;
        private System.Windows.Forms.Label lb_PasswordSignInPage;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl lbC_inform;
    }
}

