namespace koneksi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textnamabarang = new TextBox();
            textMerek = new TextBox();
            textStok = new TextBox();
            textHarga = new TextBox();
            textboxname = new TextBox();
            textboxmerek = new TextBox();
            textboxstock = new TextBox();
            textboxharga = new TextBox();
            textboxid = new TextBox();
            textupdel = new TextBox();
            dataGridView = new DataGridView();
            pictureWP = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            buttonSave_Input = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureWP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // textnamabarang
            // 
            textnamabarang.BackColor = SystemColors.ActiveCaption;
            textnamabarang.BorderStyle = BorderStyle.None;
            textnamabarang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textnamabarang.Location = new Point(81, 126);
            textnamabarang.Name = "textnamabarang";
            textnamabarang.Size = new Size(100, 20);
            textnamabarang.TabIndex = 4;
            textnamabarang.Text = "Nama Barang";
            // 
            // textMerek
            // 
            textMerek.BackColor = SystemColors.ActiveCaption;
            textMerek.BorderStyle = BorderStyle.None;
            textMerek.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textMerek.Location = new Point(81, 181);
            textMerek.Name = "textMerek";
            textMerek.Size = new Size(100, 20);
            textMerek.TabIndex = 5;
            textMerek.Text = "Merek";
            // 
            // textStok
            // 
            textStok.BackColor = SystemColors.ActiveCaption;
            textStok.BorderStyle = BorderStyle.None;
            textStok.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textStok.Location = new Point(81, 236);
            textStok.Name = "textStok";
            textStok.Size = new Size(100, 20);
            textStok.TabIndex = 6;
            textStok.Text = "Stok";
            // 
            // textHarga
            // 
            textHarga.BackColor = SystemColors.ActiveCaption;
            textHarga.BorderStyle = BorderStyle.None;
            textHarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textHarga.Location = new Point(81, 291);
            textHarga.Name = "textHarga";
            textHarga.Size = new Size(100, 20);
            textHarga.TabIndex = 7;
            textHarga.Text = "Harga";
            // 
            // textboxname
            // 
            textboxname.Location = new Point(81, 152);
            textboxname.Name = "textboxname";
            textboxname.Size = new Size(204, 23);
            textboxname.TabIndex = 9;
            // 
            // textboxmerek
            // 
            textboxmerek.Location = new Point(81, 207);
            textboxmerek.Name = "textboxmerek";
            textboxmerek.Size = new Size(204, 23);
            textboxmerek.TabIndex = 10;
            // 
            // textboxstock
            // 
            textboxstock.Location = new Point(81, 262);
            textboxstock.Name = "textboxstock";
            textboxstock.Size = new Size(204, 23);
            textboxstock.TabIndex = 11;
            // 
            // textboxharga
            // 
            textboxharga.Location = new Point(81, 317);
            textboxharga.Name = "textboxharga";
            textboxharga.Size = new Size(204, 23);
            textboxharga.TabIndex = 12;
            // 
            // textboxid
            // 
            textboxid.Location = new Point(81, 97);
            textboxid.Name = "textboxid";
            textboxid.Size = new Size(204, 23);
            textboxid.TabIndex = 16;
            // 
            // textupdel
            // 
            textupdel.BackColor = SystemColors.ActiveCaption;
            textupdel.BorderStyle = BorderStyle.None;
            textupdel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textupdel.Location = new Point(81, 71);
            textupdel.Name = "textupdel";
            textupdel.Size = new Size(153, 20);
            textupdel.TabIndex = 17;
            textupdel.Text = "Update/Delete by ID";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.LightGray;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.Black;
            dataGridView.Location = new Point(301, 13);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(745, 455);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // pictureWP
            // 
            pictureWP.ImageLocation = "D:\\WestPoint.jpeg";
            pictureWP.Location = new Point(12, 12);
            pictureWP.Margin = new Padding(0);
            pictureWP.Name = "pictureWP";
            pictureWP.Size = new Size(273, 56);
            pictureWP.SizeMode = PictureBoxSizeMode.Zoom;
            pictureWP.TabIndex = 21;
            pictureWP.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\price-tag.png";
            pictureBox1.Location = new Point(12, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "D:\\searchicon.png";
            pictureBox2.Location = new Point(12, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.ImageLocation = "D:\\brandicon.png";
            pictureBox3.Location = new Point(12, 181);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "D:\\stockicon.png";
            pictureBox4.Location = new Point(12, 236);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.ImageLocation = "D:\\nameicon.png";
            pictureBox5.Location = new Point(12, 126);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // buttonSave_Input
            // 
            buttonSave_Input.BackColor = Color.LawnGreen;
            buttonSave_Input.FlatStyle = FlatStyle.Flat;
            buttonSave_Input.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave_Input.ForeColor = Color.Black;
            buttonSave_Input.Location = new Point(189, 357);
            buttonSave_Input.Name = "buttonSave_Input";
            buttonSave_Input.Size = new Size(96, 40);
            buttonSave_Input.TabIndex = 27;
            buttonSave_Input.Text = "Save";
            buttonSave_Input.UseVisualStyleBackColor = false;
            buttonSave_Input.Click += buttonSave_Input_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.RoyalBlue;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.Black;
            buttonEdit.Location = new Point(189, 417);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(96, 40);
            buttonEdit.TabIndex = 28;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1058, 480);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSave_Input);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureWP);
            Controls.Add(textupdel);
            Controls.Add(textboxid);
            Controls.Add(textboxharga);
            Controls.Add(textboxstock);
            Controls.Add(textboxmerek);
            Controls.Add(textboxname);
            Controls.Add(textHarga);
            Controls.Add(textStok);
            Controls.Add(textMerek);
            Controls.Add(textnamabarang);
            Controls.Add(dataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "West Point";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureWP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textnamabarang;
        private TextBox textMerek;
        private TextBox textStok;
        private TextBox textHarga;
        private TextBox textboxname;
        private TextBox textboxmerek;
        private TextBox textboxstock;
        private TextBox textboxharga;
        private TextBox textboxid;
        private TextBox textupdel;
        private DataGridView dataGridView;
        private PictureBox pictureWP;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonSave_Input;
        private Button buttonEdit;
    }
}