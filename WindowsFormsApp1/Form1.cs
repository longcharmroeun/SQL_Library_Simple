using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        private string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.libraryDataSet.Pictures);
            conn = new SqlConnection();
            conn.ConnectionString = @"Server=(local); Database=Library; Integrated Security=SSPI;";
        }

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = ofd.FileName;
                LoadPicture();
            }
        }

        private void LoadPicture()
        {
            try
            {
                byte[] bytes;
                bytes = ImageToByteArray(Image.FromFile(fileName));
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Pictures(bookid,name, picture) values(@bookid, @name, @picture); ",conn);
                comm.Parameters.Add("@bookid",
                SqlDbType.Int).Value = 1;
                comm.Parameters.Add("@name",
                SqlDbType.NVarChar, 255).
                Value = fileName;
                comm.Parameters.Add("@picture",
                SqlDbType.Image, bytes.Length).
                Value = bytes;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByeteToImage(Byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes,0,bytes.Length))
            {
                ms.Write(bytes, 0, bytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value) - 1;
            if (index < libraryDataSet.Tables[0].Columns.Count && index >= 0)
            {
                //pictureBox1.Image = ByeteToImage((byte[])libraryDataSet.Tables[0].Rows[index]["picture"]);
                pictureBox1.Image = ByeteToImage((byte[])picturesTableAdapter.GetData().Rows[index]["picture"]);
            }
        }
    }
}
