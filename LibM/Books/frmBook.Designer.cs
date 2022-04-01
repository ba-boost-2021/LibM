namespace LibM.Books
{
    partial class frmBook
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
            this.dgvBooksInformation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooksInformation
            // 
            this.dgvBooksInformation.AllowUserToAddRows = false;
            this.dgvBooksInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksInformation.Location = new System.Drawing.Point(12, 12);
            this.dgvBooksInformation.Name = "dgvBooksInformation";
            this.dgvBooksInformation.RowTemplate.Height = 25;
            this.dgvBooksInformation.Size = new System.Drawing.Size(659, 398);
            this.dgvBooksInformation.TabIndex = 0;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 422);
            this.Controls.Add(this.dgvBooksInformation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Page";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvBooksInformation;
    }
}