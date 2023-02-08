namespace Project_Management_System
{
    partial class Form_KapsamProjectTask
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrNnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(178)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrNnumber,
            this.PrName,
            this.PrManager,
            this.PrPurpose,
            this.PrStatus,
            this.PrStartDate,
            this.PrEndDate,
            this.PrPayment,
            this.PaymentType,
            this.PrTeam,
            this.ProjectType});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // PrNnumber
            // 
            this.PrNnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrNnumber.HeaderText = "Number";
            this.PrNnumber.Name = "PrNnumber";
            this.PrNnumber.Width = 69;
            // 
            // PrName
            // 
            this.PrName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrName.HeaderText = "Name";
            this.PrName.Name = "PrName";
            this.PrName.Width = 60;
            // 
            // PrManager
            // 
            this.PrManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrManager.HeaderText = "Manager";
            this.PrManager.Name = "PrManager";
            this.PrManager.Width = 74;
            // 
            // PrPurpose
            // 
            this.PrPurpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrPurpose.HeaderText = "Purpose";
            this.PrPurpose.Name = "PrPurpose";
            this.PrPurpose.Width = 71;
            // 
            // PrStatus
            // 
            this.PrStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrStatus.HeaderText = "Status";
            this.PrStatus.Name = "PrStatus";
            this.PrStatus.Width = 62;
            // 
            // PrStartDate
            // 
            this.PrStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrStartDate.HeaderText = "StartDate";
            this.PrStartDate.Name = "PrStartDate";
            this.PrStartDate.Width = 77;
            // 
            // PrEndDate
            // 
            this.PrEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrEndDate.HeaderText = "EndDate";
            this.PrEndDate.Name = "PrEndDate";
            this.PrEndDate.Width = 74;
            // 
            // PrPayment
            // 
            this.PrPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrPayment.HeaderText = "Payment";
            this.PrPayment.Name = "PrPayment";
            this.PrPayment.Width = 73;
            // 
            // PaymentType
            // 
            this.PaymentType.HeaderText = "PaymentType";
            this.PaymentType.Name = "PaymentType";
            // 
            // PrTeam
            // 
            this.PrTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrTeam.HeaderText = "Team\'s amount";
            this.PrTeam.Name = "PrTeam";
            this.PrTeam.Width = 96;
            // 
            // ProjectType
            // 
            this.ProjectType.HeaderText = "ProjectType";
            this.ProjectType.Name = "ProjectType";
            // 
            // Form_KapsamProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_KapsamProjectTask";
            this.Text = "Form_KapsamProjectTask";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn PrNnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectType;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}