namespace PA6_clkraft
{
    partial class frmEdit
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.txtCover = new System.Windows.Forms.TextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(40, 639);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(364, 61);
            this.txtLength.TabIndex = 23;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(40, 517);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(364, 61);
            this.txtISBN.TabIndex = 22;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(40, 406);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(364, 61);
            this.txtCopies.TabIndex = 21;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(40, 284);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(364, 61);
            this.txtGenre.TabIndex = 20;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(40, 173);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(364, 61);
            this.txtAuthor.TabIndex = 19;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(30, 581);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(172, 55);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "Length";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(30, 470);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(136, 55);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ISBN";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(30, 348);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(381, 55);
            this.lblCopies.TabIndex = 16;
            this.lblCopies.Text = "Copies Available";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(30, 125);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(166, 55);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(30, 237);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(158, 55);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Genre";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(40, 70);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(364, 61);
            this.txtTitleData.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 55);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(30, 712);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(250, 55);
            this.lblCover.TabIndex = 24;
            this.lblCover.Text = "CoverURL";
            this.lblCover.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // txtCover
            // 
            this.txtCover.Location = new System.Drawing.Point(40, 770);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(364, 61);
            this.txtCover.TabIndex = 25;
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(522, 40);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(490, 576);
            this.pbCover.TabIndex = 26;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 696);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(336, 125);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(982, 696);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(336, 125);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 1007);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.txtCover);
            this.Controls.Add(this.lblCover);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.TextBox txtCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}