using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace app_School
{
    public partial class Form_main : Form
    {
        SqlConnection connection = new SqlConnection($@"Data Source=DESKTOP-KVTPRR0\MSSQLSERVER01;Initial Catalog=SChool;Integrated Security=True");
        public Form_main()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sChoolDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sChoolDataSet.Client". При необходимости она может быть перемещена или удалена.
            //this.clientTableAdapter.Fill(this.sChoolDataSet.Client);
            UpdateGrid();
            UPgrid();


        }

        private void UPgrid()
        {
            connection.Open();
            string query = $@"Select * From Client ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, "Client");
            string textCount = "";
            switch (genderCodeComboBox.Text)
            {
                case "Все":
                    textCount = "";
                    break;
                case "М - мужской":
                    textCount = "м";
                    break;
                case "Ж- женский":
                    textCount = "ж";
                    break;
                default:
                    break;
            }
            clientDataGridView.DataSource = ds.Tables["Client"];
            if (lastNameTextBox.Text != "" 
                && firstNameTextBox.Text != "" 
                && patronymicTextBox.Text != ""
                && emailTextBox.Text != ""
                && phoneTextBox.Text != ""
                )
            {
                query += " Where ";
                if (firstNameTextBox.Text != "")
                {

                }
            } 
            connection.Close();
        }

        private void genderCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateGrid();

        }
        
        private void UpdateGrid()
        {   
            
            string LIMIT = "";
            switch (comboBoxLIMIT.Text)
            {
                case "Все" :
                    LIMIT = "10000";
                    break;
                case "50":
                    LIMIT = "50";
                    break;
                case "200":
                    LIMIT = "200";
                    break;
                case "10":
                    LIMIT = "10";
                    break;
                default:
                    break;
            }
            int counter = 0;
            string allCount = "";
            connection.Open();
            string textCount = "";
            switch (genderCodeComboBox.Text)
            {
                case "Все":
                    textCount = "";
                    break;
                case "М - мужской":
                    textCount = "м";
                    break;
                case "Ж- женский":
                    textCount = "ж";
                    break;
                default:
                    break;
            }
            DataSet ds = new DataSet();
            clientDataGridView.DataSource = null; 
            string query = $@" Select * From Client Where  GenderCode = '{textCount}' and
            LastName Like '%{lastNameTextBox.Text}%' and  FirstName  Like '%{firstNameTextBox.Text}%' 
            and Patronymic Like '%{patronymicTextBox.Text}%' and  Email Like '%{emailTextBox.Text}%' 
            and Phone Like '%{phoneTextBox.Text}%' "; //LIMIT {LIMIT}
            string query_count = $@" Select * From Client";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(ds, "Client");
                MessageBox.Show(query);
                clientDataGridView.DataSource = ds.Tables["Client"];
                SqlCommand command = new SqlCommand(query_count, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                    allCount = reader["ID"].ToString();
                }
                label_count.Text = counter.ToString() + " из " + allCount;
                reader.Close();
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore UpdateGrid: \n" + ex.Message, ex.Source);
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientDataGridView.DataSource = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenRedactor_Click(object sender, EventArgs e)
        {

        }
    }
}
