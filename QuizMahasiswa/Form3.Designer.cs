namespace QuizMahasiswa
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.quizMahasiswaDataSet1 = new QuizMahasiswa.QuizMahasiswaDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtRp = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPcs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.Label();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quizMahasiswaDataSet1
            // 
            this.quizMahasiswaDataSet1.DataSetName = "QuizMahasiswaDataSet1";
            this.quizMahasiswaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID Barang";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(287, 133);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 22);
            this.textBox5.TabIndex = 56;
            // 
            // txtRp
            // 
            this.txtRp.AutoSize = true;
            this.txtRp.Location = new System.Drawing.Point(283, 229);
            this.txtRp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRp.Name = "txtRp";
            this.txtRp.Size = new System.Drawing.Size(26, 17);
            this.txtRp.TabIndex = 54;
            this.txtRp.Text = "Rp";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(287, 326);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 22);
            this.textBox4.TabIndex = 53;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 275);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 225);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 50;
            // 
            // txtPcs
            // 
            this.txtPcs.AutoSize = true;
            this.txtPcs.Location = new System.Drawing.Point(474, 279);
            this.txtPcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(40, 17);
            this.txtPcs.TabIndex = 55;
            this.txtPcs.Text = "buah";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 377);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 185);
            this.dataGridView1.TabIndex = 49;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 326);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.AutoSize = true;
            this.txtSupplier.Location = new System.Drawing.Point(119, 326);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(101, 17);
            this.txtSupplier.TabIndex = 47;
            this.txtSupplier.Text = "Nama Supplier";
            // 
            // txtStok
            // 
            this.txtStok.AutoSize = true;
            this.txtStok.Location = new System.Drawing.Point(119, 275);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(36, 17);
            this.txtStok.TabIndex = 46;
            this.txtStok.Text = "Stok";
            // 
            // txtHarga
            // 
            this.txtHarga.AutoSize = true;
            this.txtHarga.Location = new System.Drawing.Point(119, 225);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(47, 17);
            this.txtHarga.TabIndex = 45;
            this.txtHarga.Text = "Harga";
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(119, 175);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(95, 17);
            this.txtNama.TabIndex = 44;
            this.txtNama.Text = "Nama Barang";
            // 
            // txtJudul
            // 
            this.txtJudul.AutoSize = true;
            this.txtJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudul.Location = new System.Drawing.Point(292, 72);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(186, 24);
            this.txtJudul.TabIndex = 43;
            this.txtJudul.Text = "MASTER BARANG";
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtRp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPcs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtJudul);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuizMahasiswaDataSet1 quizMahasiswaDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtRp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPcs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtSupplier;
        private System.Windows.Forms.Label txtStok;
        private System.Windows.Forms.Label txtHarga;
        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtJudul;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
    }
}