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

        /*Meload data dari table Mahasiswa saat form pertama kali dibuka*/
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
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

        /*Membuat fungsi untuk menguji eksistensi data berdasarkan NIM yang diberikan*/
        private int chkExistingData(String nim)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                String query = "SELECT 1 FROM Mahasiswa WHERE NIM = @NIM";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                conn.Close();
            }
        }

        /*Membuat handler apabila button tambah diclick, button ini berguna untuk tambah atau update data*/
        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    /*error handler apabila ada value input yang kosong*/
                    if (txtNIM.Text == "" || txtNama.Text == "" || txtEmail.Text == "" || txtTelepon.Text == "")
                    {
                        MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    /*mengecek eksistensi data untuk memastikan tidak ada duplikasi*/
                    int isExist = chkExistingData(txtNIM.Text.Trim());

                    /*jika data tidak ada maka akan mengembalikan nilai 0, barulah data boleh ditambah ke BD menggunakan isi dari kondisi dibawah*/
                    if (isExist == 0)
                    {

                        conn.Open();
                        String query = "INSERT INTO Mahasiswa(NIM, Nama, Email, Telepon, Alamat) VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());
                            cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Telepon", txtTelepon.Text.Trim());
                            cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());

                            int rowAffectted = cmd.ExecuteNonQuery();

                            if (rowAffectted > 0)
                            {
                                MessageBox.Show("Data berhasil ditambahkan!", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                                ClearForm();
                            }
                        }

                        conn.Close();

                    }
                    /*jika kondisi tidak memenuhi artinya NIM exist, barulah kita tanyakan apakah ingin update data*/
                    else
                    {
                        DialogResult result = MessageBox.Show("NIM Ditemukan. Apakah Anda Ingin Update Data!", "Data Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        /*jika user setuju untuk update data, maka instruksi untuk update data akan dijalankan*/
                        if (result == DialogResult.OK)
                        {
                            conn.Open();

                            String query = "UPDATE Mahasiswa SET Nama = @Nama, Email = @Email, Telepon = @Telepon, Alamat = @Alamat WHERE NIM = @NIM";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Telepon", txtTelepon.Text.Trim());
                                cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());
                                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());

                                int affectedRow = cmd.ExecuteNonQuery();

                                if (affectedRow > 0)
                                {
                                    MessageBox.Show("Data Berhasil Di Update!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                    ClearForm();
                                }
                                conn.Close();

                            }

                        }
                        else
                        {
                            return;
                        }

                    }
                }
                /*Menambah handler catch untuk button tambah*/
                catch (Exception)
                {
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data. Pastikan koneksi dan data valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
