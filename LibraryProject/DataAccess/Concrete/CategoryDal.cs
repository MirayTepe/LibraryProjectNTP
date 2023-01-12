using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    { 
        SqlConnBase conn=new SqlConnBase();
        public void Add(Category category)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Insert into Categories (CategoryId,CategoryName) values ('{category.CategoryId }','{category.CategoryName}')", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public void Delete(Category category)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Delete from Categories where CategoryId={category.CategoryId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public List<Category> GetAll()
        {
            conn.sqlConnect();

            SqlCommand command = new SqlCommand("Select * from Categories", conn.sqlConnect());
            List<Category> categories = new List<Category>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                category.CategoryName = Convert.ToString(reader["CategoryName"]);
               
                categories.Add(category);   
            }
            conn.sqlConnect().Close();
            return categories;
        }


        public void Update(Category category)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Update Categories  set CategoryName='{category.CategoryName}'where CategoryId={category.CategoryId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
    }
}
