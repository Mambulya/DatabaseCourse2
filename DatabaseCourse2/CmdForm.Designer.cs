namespace DatabaseCourse2
{
    partial class CmdForm
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
            this.CmddataGridView = new System.Windows.Forms.DataGridView();
            this.btnFill = new System.Windows.Forms.Button();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.cmdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CmddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CmddataGridView
            // 
            this.CmddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CmddataGridView.Location = new System.Drawing.Point(45, 103);
            this.CmddataGridView.Name = "CmddataGridView";
            this.CmddataGridView.RowHeadersWidth = 62;
            this.CmddataGridView.RowTemplate.Height = 28;
            this.CmddataGridView.Size = new System.Drawing.Size(1090, 320);
            this.CmddataGridView.TabIndex = 0;
            // 
            // btnFill
            // 
            this.btnFill.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFill.Location = new System.Drawing.Point(918, 567);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(113, 50);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(432, 579);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(325, 26);
            this.cmdTextBox.TabIndex = 2;
            this.cmdTextBox.Text = "1";
            this.cmdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdLabel.Location = new System.Drawing.Point(40, 576);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(344, 29);
            this.cmdLabel.TabIndex = 3;
            this.cmdLabel.Text = "Квалификация работника:";
            this.cmdLabel.Click += new System.EventHandler(this.cmdLabel_Click);
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cmdLabel);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.CmddataGridView);
            this.Name = "CmdForm";
            this.Text = "CmdForm";
            ((System.ComponentModel.ISupportInitialize)(this.CmddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CmddataGridView;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Label cmdLabel;
    }
}