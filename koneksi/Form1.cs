using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace koneksi
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public void filldataTable()
        {
            dataGridView.DataSource = getDataStock();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dataGridView.Columns.Add(colEdit);

            DataGridViewButtonColumn coldDelete = new DataGridViewButtonColumn();
            coldDelete.UseColumnTextForButtonValue = true;
            coldDelete.Text = "Delete";
            coldDelete.Name = "";
            dataGridView.Columns.Add(coldDelete);
        }

        private void textboxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_Click(object sender, EventArgs e)
        {

        }

        public DataTable getDataStock()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM persediaan", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textidbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update film SET id = @id := (@id+1); " +
                "ALTER TABLE film AUTO_INCREMENT = 1;");
            script.Execute();
        }
        private void buttonSave_Input_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO persediaan(nama_barang,merek,stock,price) VALUE(@nama_barang, @merek, @stock, @price)";
                cmd.Parameters.AddWithValue("@nama_barang", textboxname.Text);
                cmd.Parameters.AddWithValue("@merek", textboxmerek.Text);
                cmd.Parameters.AddWithValue("@stock", textboxstock.Text);
                cmd.Parameters.AddWithValue("@price", textboxharga.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();

                dataGridView.Columns.Clear();
                dataTable.Clear();
                filldataTable();

                resetIncrement();
            }
            catch (Exception ex) { }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView.CurrentCell.RowIndex.ToString());
                textboxid.Text = dataGridView.Rows[id].Cells[0].Value.ToString();
                textboxname.Text = dataGridView.Rows[id].Cells[1].Value.ToString();
                textboxmerek.Text = dataGridView.Rows[id].Cells[2].Value.ToString();
                textboxstock.Text = dataGridView.Rows[id].Cells[3].Value.ToString();
                textboxharga.Text = dataGridView.Rows[id].Cells[4].Value.ToString();

                textboxname.Enabled = true;
                textboxmerek.Enabled = true;
                textboxstock.Enabled = true;
                textboxharga.Enabled = true;
                buttonEdit.Enabled = true;
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dataGridView.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                //conn.Open();
                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM persediaan WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dataGridView.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data dihapus!");
                    koneksi.Close();

                    dataGridView.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                    resetIncrement();

                }
                catch (Exception ex) { }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE persediaan SET nama_barang = @nama_barang, merek=@merek,stock=@stock,price= @price WHERE id= @id";
                cmd.Parameters.AddWithValue("@id", textboxid.Text);
                cmd.Parameters.AddWithValue("@nama_barang", textboxname.Text);
                cmd.Parameters.AddWithValue("@merek", textboxmerek.Text);
                cmd.Parameters.AddWithValue("@stock", textboxstock.Text);
                cmd.Parameters.AddWithValue("@price", textboxharga.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();

                dataGridView.Columns.Clear();
                dataTable.Clear();
                filldataTable();

                resetIncrement();
            }
            catch (Exception ex) { }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}