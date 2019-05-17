using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ВС._4.Рецепт
{
    public partial class Form1 : Form
    {
        Recipe recipe;

        // путь к базе
        string connectionString;

        // подключение к базе
        SqlConnection connection;

        DataSet ds;

        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            getRecipies();
        }

        public void getRecipies()
        {
            string sql = "SELECT * FROM Recipies";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void clearBox(object sender, EventArgs e)
        {
            clearBox();
        }

        private void clearBox()
        {
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxDoctor.Text = "";
            txtBoxNumber.Text = "";
            txtBoxCure.Text = "";
            txtBoxCost.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchForObject(txtBoxIDSearch.Text.ToString());
        }

        public void searchForObject(string id)
        {
            recipe = new RecipeProxy(this);
            try
            {
                recipe.State = new SearchSTATE();
                recipe.operation(id);
                recipe.State = new WaitSTATE();
            }
            catch (Exception f)
            {
                recipe.State = new WaitSTATE();

                UpdateButton.Enabled = false;
                ClearResultsButton.Enabled = false;
                txtBoxIDSearch.Text = "";
                MessageBox.Show($"{f.Message}");
                getRecipies();
            }
        }
        
        private void ClearResultsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new object();
            txtBoxIDSearch.Text = "";
            UpdateButton.Enabled = false;
            getRecipies();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            txtBoxID.Text = recipe.Id.ToString();
            txtBoxName.Text = recipe.PharmacyName;
            txtBoxAddress.Text = recipe.PharmacyAddress;
            txtBoxDoctor.Text = recipe.Doctor;
            txtBoxNumber.Text = recipe.PhoneNumber.ToString();
            txtBoxCure.Text = recipe.Cure;
            txtBoxCost.Text = recipe.Cost.ToString();
            dateTimePicker.Value = recipe.Date;

            txtBoxIDSearch.Text = "";

            txtBoxID.Enabled = false;
            UpdateButton.Enabled = false;
            ClearInsertButton.Enabled = false;
        }

        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            txtBoxID.Enabled = true;
            recipe = new RecipeProxy(this);
            if (txtBoxID.Text == "Задается автоматически")
            {
                recipe.Id = 0;
                recipe.PharmacyName = txtBoxName.Text;
                recipe.PharmacyAddress = txtBoxAddress.Text;
                recipe.Doctor = txtBoxDoctor.Text;
                recipe.PhoneNumber = Int32.Parse(txtBoxNumber.Text);
                recipe.Cure = txtBoxCure.Text;
                recipe.Cost = Int32.Parse(txtBoxCost.Text);
                recipe.Date = dateTimePicker.Value;

                recipe.State = new CreateSTATE();
                recipe.operation("0");
                recipe.State = new WaitSTATE();

                clearBox();
                getRecipies();
                UpdateButton.Enabled = false;
            }
            else if (txtBoxID.Text != "")
            {
                recipe.Id = Int32.Parse(txtBoxID.Text);
                recipe.PharmacyName = txtBoxName.Text;
                recipe.PharmacyAddress = txtBoxAddress.Text;
                recipe.Doctor = txtBoxDoctor.Text;
                recipe.PhoneNumber = Int32.Parse(txtBoxNumber.Text);
                recipe.Cure = txtBoxCure.Text;
                recipe.Cost = Int32.Parse(txtBoxCost.Text);
                recipe.Date = dateTimePicker.Value;

                recipe.State = new UPDATESTATE();
                recipe.operation(recipe.Id.ToString());
                recipe.State = new WaitSTATE();

                clearBox();
                getRecipies();
                UpdateButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Отсутствуют данные");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (txtBoxIDDelete.Text == "")
            {
                MessageBox.Show("Введите ID");
                return;
            }
            else
            {
                recipe = new RecipeProxy(this);
                try
                {
                    recipe.State = new DeleteSTATE();
                    recipe.operation(txtBoxIDDelete.Text.ToString());
                    recipe.State = new WaitSTATE();

                    dataGridView1.DataSource = new object();
                    txtBoxIDSearch.Text = "";
                    txtBoxIDDelete.Text = "";
                    MessageBox.Show("Запись ID:" + txtBoxIDDelete.Text + " удалена");
                    getRecipies();
                }
                catch (Exception f)
                {
                    recipe.State = new WaitSTATE();
                    MessageBox.Show($"{f.Message}");
                }
            }
        }

        private void txtBoxID_Click(object sender, EventArgs e)
        {
            txtBoxID.Text = "Задается автоматически";
            txtBoxID.Enabled = false;
        }
    }
}
