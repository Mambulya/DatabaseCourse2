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
            ((System.ComponentModel.ISupportInitialize)(this.CmddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CmddataGridView
            // 
            this.CmddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CmddataGridView.Location = new System.Drawing.Point(22, 100);
            this.CmddataGridView.Name = "CmddataGridView";
            this.CmddataGridView.RowHeadersWidth = 62;
            this.CmddataGridView.RowTemplate.Height = 28;
            this.CmddataGridView.Size = new System.Drawing.Size(780, 341);
            this.CmddataGridView.TabIndex = 0;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(946, 329);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(113, 50);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.CmddataGridView);
            this.Name = "CmdForm";
            this.Text = "CmdForm";
            ((System.ComponentModel.ISupportInitialize)(this.CmddataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CmddataGridView;
        private System.Windows.Forms.Button btnFill;
    }
}