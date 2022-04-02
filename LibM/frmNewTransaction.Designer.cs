namespace LibM
{
    partial class frmNewTransaction
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
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kitap = new System.Windows.Forms.Label();
            this.Yazar = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(29, 42);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(200, 23);
            this.cmbStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBorrowingDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStudents);
            this.groupBox1.Location = new System.Drawing.Point(357, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.Location = new System.Drawing.Point(29, 115);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBorrowingDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kitap);
            this.groupBox2.Controls.Add(this.Yazar);
            this.groupBox2.Controls.Add(this.lbltype);
            this.groupBox2.Controls.Add(this.cmbBook);
            this.groupBox2.Controls.Add(this.cmbAuthor);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Location = new System.Drawing.Point(39, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seçimi";
            // 
            // Kitap
            // 
            this.Kitap.AutoSize = true;
            this.Kitap.Location = new System.Drawing.Point(129, 190);
            this.Kitap.Name = "Kitap";
            this.Kitap.Size = new System.Drawing.Size(34, 15);
            this.Kitap.TabIndex = 1;
            this.Kitap.Text = "Kitap";
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(129, 99);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(34, 15);
            this.Yazar.TabIndex = 1;
            this.Yazar.Text = "Yazar";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(129, 19);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(25, 15);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "Tür";
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(49, 215);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(200, 23);
            this.cmbBook.TabIndex = 0;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(49, 127);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(200, 23);
            this.cmbAuthor.TabIndex = 0;
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(49, 42);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İşlem Ekranı";
            this.Load += new System.EventHandler(this.frmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbStudents;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbBook;
        private ComboBox cmbAuthor;
        private ComboBox cmbType;
        private DateTimePicker dtpBorrowingDate;
        private Label Kitap;
        private Label Yazar;
        private Label lbltype;
        private Button button1;
        private Label label1;
    }
}