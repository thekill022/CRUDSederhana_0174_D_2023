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

        /*Membuat fungsi LoadData() untuk men-SELECT data yang ada pada tabel Mahasiswa di Database OrganisasiMahasiswa*/
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    String query = "SELECT NIM AS [NIM], Nama, Email, Telepon, Alamat FROM Mahasiswa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMahasiswa.AutoGenerateColumns = true;
                    dgvMahasiswa.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengambil data. Pastikan koneksi anda valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
