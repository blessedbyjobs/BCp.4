using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ВС._4.Рецепт
{
    public abstract class Recipe
    {
        public Form1 Form;

        public IRecipeState State { get; set; }

        public int Id { get; set; }

        public string PharmacyName { get; set; }
        public string PharmacyAddress { get; set; }

        public string Doctor { get; set; }
        public int PhoneNumber { get; set; }

        public string Cure { get; set; }

        public int Cost { get; set; }

        public DateTime Date { get; set; }

        public abstract Recipe getInstance(Form1 form);

        public void operation(string id)
        {
            State.operation(this, id);
        }
    }

    public class RealRecipe : Recipe
    {
        Recipe recipe;

        public override Recipe getInstance(Form1 form)
        {
            if (recipe == null)
                recipe = new RealRecipe();
            return recipe;
        }
    }

    public class RecipeProxy : Recipe
    {
        private static Recipe instance;

        public RecipeProxy(int id, string name, string address, string doctor, int phone, string cure, int cost, DateTime date)
        {
            Id = id;
            PharmacyName = name;
            PharmacyAddress = address;
            Doctor = doctor;
            PhoneNumber = phone;
            Cure = cure;
            Cost = cost;
            Date = date;

            State = new WaitSTATE();
        }

        public RecipeProxy(Form1 parentForm)
        {
            Form = parentForm;
        }

        public override Recipe getInstance(Form1 form)
        {
            if (instance == null)
                instance = new RecipeProxy(form);
            return instance;
        }
    }

    public interface IRecipeState
    {
        void operation(Recipe recipe, string id);
    }

    class WaitSTATE : IRecipeState
    {
        public void operation(Recipe recipe, string id)
        {
            string s = "do nothing";
        }
    }

    class SearchSTATE : IRecipeState
    {
        public void operation(Recipe recipe, string id)
        {
            string sql = "SELECT * FROM Recipies WHERE id = '" + id + "'";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);

                if (ds.Tables[0].Rows[0]["id"].ToString() == "")
                {
                    throw new Exception(" не найдена");
                }

                recipe.Id = Int32.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                recipe.PharmacyName = ds.Tables[0].Rows[0]["name"].ToString();
                recipe.PharmacyAddress = ds.Tables[0].Rows[0]["address"].ToString();
                recipe.Doctor = ds.Tables[0].Rows[0]["doctor"].ToString();
                recipe.PhoneNumber = Int32.Parse(ds.Tables[0].Rows[0]["number"].ToString());
                recipe.Cure = ds.Tables[0].Rows[0]["cure"].ToString();
                recipe.Cost = Int32.Parse(ds.Tables[0].Rows[0]["cost"].ToString());
                recipe.Date = DateTime.Parse(ds.Tables[0].Rows[0]["date"].ToString());

                // Отображаем данные
                recipe.Form.dataGridView1.DataSource = ds.Tables[0];
                recipe.Form.UpdateButton.Enabled = true;
                recipe.Form.ClearResultsButton.Enabled = true;
            }
        }
    }

    class CreateSTATE : IRecipeState
    {
        public void operation(Recipe recipe, string id)
        {
            string sql = "SELECT * FROM Recipies";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                // добавим новую строку
                DataRow newRow = dt.NewRow();
                newRow["id"] = recipe.Id;
                newRow["name"] = recipe.PharmacyName;
                newRow["address"] = recipe.PharmacyAddress;
                newRow["doctor"] = recipe.Doctor;
                newRow["number"] = recipe.PhoneNumber;
                newRow["cure"] = recipe.Cure;
                newRow["cost"] = recipe.Cost;
                newRow["date"] = recipe.Date;
                dt.Rows.Add(newRow);

                // создаем объект SqlCommandBuilder
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);

                // заново получаем данные из бд
                // очищаем полностью DataSet
                ds.Clear();
                // перезагружаем данные
                adapter.Fill(ds);
            }
        }
    }

    class DeleteSTATE : IRecipeState
    {
        public void operation(Recipe recipe, string id)
        {
            recipe.Form.searchForObject(id);
            string sql = "DELETE FROM Recipies WHERE id = '" + id + "'";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
            }
        }
    }

    class UPDATESTATE : IRecipeState
    {
        public void operation(Recipe recipe, string id)
        {
            string sql = "UPDATE Recipies SET [name] = '" + recipe.PharmacyName + "', [address] = '" + recipe.PharmacyAddress + "', [doctor] = '" + recipe.Doctor + "', [number] = '" + recipe.PhoneNumber + "', [cure] = '" + recipe.Cure + "', [cost] = '" + recipe.Cost + "', [date] = '" + recipe.Date + "' WHERE id = '" + id + "'";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }
        }
    }
}
