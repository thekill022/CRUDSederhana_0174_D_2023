using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {

        /*Membuat koneksi ke database OrganisasiMahasiswa*/
        private String connection = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER; Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*Membuat fungsi untuk mengosongkan value dari setiap input di form*/
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtAlamat.Clear();
            txtTelepon.Clear();

            txtNIM.Focus();
        }


    }
}
