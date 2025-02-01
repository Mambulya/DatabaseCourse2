namespace DatabaseCourse2
{
    partial class AltForm
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
            this.btnProductionN = new System.Windows.Forms.Button();
            this.btnWorkerExp = new System.Windows.Forms.Button();
            this.btnWorkerInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductionN
            // 
            this.btnProductionN.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProductionN.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnProductionN.Location = new System.Drawing.Point(84, 295);
            this.btnProductionN.Name = "btnProductionN";
            this.btnProductionN.Size = new System.Drawing.Size(120, 23);
            this.btnProductionN.TabIndex = 0;
            this.btnProductionN.Text = "production_normas";
            this.btnProductionN.UseVisualStyleBackColor = false;
            this.btnProductionN.Click += new System.EventHandler(this.btnProductionN_Click);
            // 
            // btnWorkerExp
            // 
            this.btnWorkerExp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWorkerExp.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnWorkerExp.Location = new System.Drawing.Point(330, 295);
            this.btnWorkerExp.Name = "btnWorkerExp";
            this.btnWorkerExp.Size = new System.Drawing.Size(120, 23);
            this.btnWorkerExp.TabIndex = 1;
            this.btnWorkerExp.Text = "worker_experience";
            this.btnWorkerExp.UseVisualStyleBackColor = false;
            this.btnWorkerExp.Click += new System.EventHandler(this.btnWorkerExp_Click);
            // 
            // btnWorkerInfo
            // 
            this.btnWorkerInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWorkerInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnWorkerInfo.Location = new System.Drawing.Point(566, 295);
            this.btnWorkerInfo.Name = "btnWorkerInfo";
            this.btnWorkerInfo.Size = new System.Drawing.Size(120, 23);
            this.btnWorkerInfo.TabIndex = 2;
            this.btnWorkerInfo.Text = "worker_info";
            this.btnWorkerInfo.UseVisualStyleBackColor = false;
            this.btnWorkerInfo.Click += new System.EventHandler(this.btnWorkerInf_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(354, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.Location = new System.Drawing.Point(34, 36);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.Size = new System.Drawing.Size(731, 170);
            this.MaindataGridView.TabIndex = 4;
            // 
            // AltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaindataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWorkerInfo);
            this.Controls.Add(this.btnWorkerExp);
            this.Controls.Add(this.btnProductionN);
            this.Name = "AltForm";
            this.Text = "AltForm";
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductionN;
        private System.Windows.Forms.Button btnWorkerExp;
        private System.Windows.Forms.Button btnWorkerInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView MaindataGridView;
    }
}