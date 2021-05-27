using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizMahasiswa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=ALI;Initial Catalog=QuizMahasiswa;Integrated Security=True;");
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int IDBarang = int.Parse(textBox5.Text);
            string NamaBarang = textBox1.Text;
            int Harga = int.Parse(textBox2.Text);
            int Stok = int.Parse(textBox3.Text);
            string NamaSupplier = textBox4.Text;

            var data = new tbl_barang
            {
                id_barang = IDBarang,
                nama_barang = NamaBarang,
                harga = Harga,
                stok = Stok,
                nama_supplier = NamaSupplier,
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            LoadData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            var data = from tb in db.tbl_barangs select tb;
            dataGridView1.DataSource = data;
        }
    }
}
