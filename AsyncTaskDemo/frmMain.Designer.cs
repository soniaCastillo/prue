namespace AsyncTaskDemo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSyncOperation = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDataEntry = new System.Windows.Forms.Label();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSyncOperation
            // 
            this.btnSyncOperation.Location = new System.Drawing.Point(22, 26);
            this.btnSyncOperation.Name = "btnSyncOperation";
            this.btnSyncOperation.Size = new System.Drawing.Size(182, 39);
            this.btnSyncOperation.TabIndex = 0;
            this.btnSyncOperation.Text = "Synchronous Operation";
            this.btnSyncOperation.UseVisualStyleBackColor = true;
            this.btnSyncOperation.Click += new System.EventHandler(this.btnSyncOperation_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(22, 84);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(182, 39);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "Async Operation";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 15;
            this.lstData.Location = new System.Drawing.Point(369, 77);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(412, 349);
            this.lstData.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(369, 38);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(106, 25);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Status Log";
            // 
            // lblDataEntry
            // 
            this.lblDataEntry.AutoSize = true;
            this.lblDataEntry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataEntry.Location = new System.Drawing.Point(22, 178);
            this.lblDataEntry.Name = "lblDataEntry";
            this.lblDataEntry.Size = new System.Drawing.Size(177, 25);
            this.lblDataEntry.TabIndex = 4;
            this.lblDataEntry.Text = "Data Entry Section";
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(22, 252);
            this.txtOne.Multiline = true;
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(288, 85);
            this.txtOne.TabIndex = 5;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(22, 388);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(288, 23);
            this.txtTwo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Section 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Section 2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lblDataEntry);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSyncOperation);
            this.Name = "frmMain";
            this.Text = "My Super Responsive UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSyncOperation;
        private Button btnAsync;
        private ListBox lstData;
        private Label lblData;
        private Label lblDataEntry;
        private TextBox txtOne;
        private TextBox txtTwo;
        private Label label1;
        private Label label2;
    }
}