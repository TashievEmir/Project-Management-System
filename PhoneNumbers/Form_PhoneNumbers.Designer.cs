namespace Project_Management_System.PhoneNumbers
{
    partial class Form_PhoneNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.tView_PhoneNumber = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Numbers of employess";
            // 
            // tView_PhoneNumber
            // 
            this.tView_PhoneNumber.AllowDrop = true;
            this.tView_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.tView_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tView_PhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tView_PhoneNumber.HideSelection = false;
            this.tView_PhoneNumber.Location = new System.Drawing.Point(27, 71);
            this.tView_PhoneNumber.Name = "tView_PhoneNumber";
            this.tView_PhoneNumber.Size = new System.Drawing.Size(302, 297);
            this.tView_PhoneNumber.TabIndex = 1;
            // 
            // Form_PhoneNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(357, 380);
            this.Controls.Add(this.tView_PhoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form_PhoneNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_PhoneNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView tView_PhoneNumber;
    }
}