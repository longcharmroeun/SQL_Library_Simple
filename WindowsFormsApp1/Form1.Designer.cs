namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WindowsFormsApp1.LibraryDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picturesTableAdapter = new WindowsFormsApp1.LibraryDataSetTableAdapters.PicturesTableAdapter();
            this.findBookIdByTitleTableAdapter1 = new WindowsFormsApp1.LibraryDataSetTableAdapters.FindBookIdByTitleTableAdapter();
            this.booksTableAdapter1 = new WindowsFormsApp1.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.viewByPictureIdTableAdapter1 = new WindowsFormsApp1.LibraryDataSetTableAdapters.ViewByPictureIdTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.BookTilte_Label = new System.Windows.Forms.Label();
            this.AuthorName_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.picturesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 407);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pictureDataGridViewImageColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.DividerWidth = 5;
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 51;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "Pictures";
            this.picturesBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(413, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 303);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(872, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "BookTitle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "LoadPicture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(802, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(802, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Comfirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // findBookIdByTitleTableAdapter1
            // 
            this.findBookIdByTitleTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // viewByPictureIdTableAdapter1
            // 
            this.viewByPictureIdTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "BookTitle:";
            // 
            // BookTilte_Label
            // 
            this.BookTilte_Label.AutoSize = true;
            this.BookTilte_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTilte_Label.Location = new System.Drawing.Point(486, 317);
            this.BookTilte_Label.Name = "BookTilte_Label";
            this.BookTilte_Label.Size = new System.Drawing.Size(42, 17);
            this.BookTilte_Label.TabIndex = 9;
            this.BookTilte_Label.Text = "None";
            // 
            // AuthorName_Label
            // 
            this.AuthorName_Label.AutoSize = true;
            this.AuthorName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName_Label.Location = new System.Drawing.Point(514, 345);
            this.AuthorName_Label.Name = "AuthorName_Label";
            this.AuthorName_Label.Size = new System.Drawing.Size(42, 17);
            this.AuthorName_Label.TabIndex = 11;
            this.AuthorName_Label.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Author Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.AuthorName_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookTilte_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private LibraryDataSetTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private LibraryDataSetTableAdapters.FindBookIdByTitleTableAdapter findBookIdByTitleTableAdapter1;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
        private LibraryDataSetTableAdapters.ViewByPictureIdTableAdapter viewByPictureIdTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookTilte_Label;
        private System.Windows.Forms.Label AuthorName_Label;
        private System.Windows.Forms.Label label4;
    }
}

