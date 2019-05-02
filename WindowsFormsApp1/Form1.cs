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
        private string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.libraryDataSet.Pictures);
            for (int i = 0; i < booksTableAdapter1.GetData().Count; i++)
            {
                comboBox1.Items.Add(booksTableAdapter1.GetData().Rows[i][2]);
            }
        }

        private void LoadPicture(int BookID)
        {
            try
            {
                byte[] bytes;
                bytes = ImageToByteArray(Image.FromFile(fileName));
                picturesTableAdapter.Insert(BookID, fileName, bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index < picturesTableAdapter.GetData().Rows.Count && index >= 0)
            {
                pictureBox1.Image = ByeteToImage((byte[])picturesTableAdapter.GetData().Rows[index][3]);
                int pictureId = (int)picturesTableAdapter.GetData().Rows[index][0];
                BookTilte_Label.Text = viewByPictureIdTableAdapter1.GetData(pictureId).Rows[0][2].ToString();
                AuthorName_Label.Text = $"{viewByPictureIdTableAdapter1.GetData(pictureId).Rows[0][1]} {viewByPictureIdTableAdapter1.GetData(pictureId).Rows[0][2]}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = ofd.FileName;
                pictureBox2.Image = Image.FromFile(fileName);
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BookId = (int)findBookIdByTitleTableAdapter1.GetData((string)comboBox1.SelectedItem).Rows[0][0];
            LoadPicture(BookId);
            this.picturesTableAdapter.Fill(this.libraryDataSet.Pictures);
            button2.Enabled = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            picturesTableAdapter.Delete((int)picturesTableAdapter.GetData().Rows[index][0], (int)picturesTableAdapter.GetData().Rows[index]["BookId"], (string)picturesTableAdapter.GetData().Rows[index]["Name"]);
            this.picturesTableAdapter.Fill(this.libraryDataSet.Pictures);
        }
    }
}
