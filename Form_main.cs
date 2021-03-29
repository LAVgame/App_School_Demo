using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_aprDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.demo_aprDataSet.Client);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sChoolDataSet.Client". При необходимости она может быть перемещена или удалена.
            //this.clientTableAdapter.Fill(this.sChoolDataSet.Client);

            UPgrid();


        }

        private void UPgrid()
        {
            connection.Open();
            string query = $@"Select * From Client ";

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
            string LIMIT = "";
            switch (comboBoxLIMIT.Text)
            {
                case "Все":
                    LIMIT = "1000";
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
            query += $@" Where GenderCode = '{textCount}', ";

            // IF
            if (lastNameTextBox.Text != "")
            {
                query += " AND LastName Like '%{lastNameTextBox.Text}%' ";
            }
            if (firstNameTextBox.Text != "")
            {
                query += "AND  FirstName  Like '%{firstNameTextBox.Text}%' ";
            }
            if (patronymicTextBox.Text != "")
            {
                query += "AND Patronymic Like '%{patronymicTextBox.Text}%'";
            }
            if (emailTextBox.Text != "")
            {
                query += "AND  Email Like '%{emailTextBox.Text}%'";
            }
            if (phoneTextBox.Text != "")
            {
                query += "AND Phone Like '%{phoneTextBox.Text}%' ";
            }
            query += $@"AND Limit {LIMIT}";

            MessageBox.Show(query, "Запрос");
            //Update Grid
            /* string query = $@" Select * From Client Where  GenderCode = '{textCount}' and
            LastName Like '%{lastNameTextBox.Text}%' and  FirstName  Like '%{firstNameTextBox.Text}%' 
            and Patronymic Like '%{patronymicTextBox.Text}%' and  Email Like '%{emailTextBox.Text}%' 
            and Phone Like '%{phoneTextBox.Text}%' "; //LIMIT {LIMIT} */
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, "Client");
            clientDataGridView.DataSource = ds.Tables["Client"];
            connection.Close();
        }

        private void genderCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        //private void UpdateGrid()
        //{   

        //    string LIMIT = "";
        //    switch (comboBoxLIMIT.Text)
        //    {
        //        case "Все" :
        //            LIMIT = "1000";
        //            break;
        //        case "50":
        //            LIMIT = "50";
        //            break;
        //        case "200":
        //            LIMIT = "200";
        //            break;
        //        case "10":
        //            LIMIT = "10";
        //            break;
        //        default:
        //            break;
        //    }
        //    int counter = 0;
        //    string allCount = "";
        //    connection.Open();
        //    string textCount = "";
        //    switch (genderCodeComboBox.Text)
        //    {
        //        case "Все":
        //            textCount = "";
        //            break;
        //        case "М - мужской":
        //            textCount = "м";
        //            break;
        //        case "Ж- женский":
        //            textCount = "ж";
        //            break;
        //        default:
        //            break;
        //    }
        //    DataSet ds = new DataSet();
        //    clientDataGridView.DataSource = null; 
        //    string query = $@" Select * From Client Where  GenderCode = '{textCount}' and
        //    LastName Like '%{lastNameTextBox.Text}%' and  FirstName  Like '%{firstNameTextBox.Text}%' 
        //    and Patronymic Like '%{patronymicTextBox.Text}%' and  Email Like '%{emailTextBox.Text}%' 
        //    and Phone Like '%{phoneTextBox.Text}%' "; //LIMIT {LIMIT}
        //    string query_count = $@" Select * From Client";
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(query, connection);
        //        da.Fill(ds, "Client");
        //        MessageBox.Show(query);
        //        clientDataGridView.DataSource = ds.Tables["Client"];
        //        SqlCommand command = new SqlCommand(query_count, connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            counter++;
        //            allCount = reader["ID"].ToString();
        //        }
        //        label_count.Text = counter.ToString() + " из " + allCount;
        //        reader.Close();

        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Errore UpdateGrid: \n" + ex.Message, ex.Source);
        //    }
        //}

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

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
