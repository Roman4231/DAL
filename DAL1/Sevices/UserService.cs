using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace Services
{
    public class UserService 
    {

        string connStr;

        public UserService(string connStr)
        {
            this.connStr = connStr;
        }

        public User getById(int id)
        {
            User user = new User();
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM user WHERE user.user_ID=@user_ID";
                command.Parameters.AddWithValue("@user_ID", id);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                user.user_ID = id;
                user.login = dataReader["login"].ToString();
                user.password = dataReader["password"].ToString();
                user.email = dataReader["email"].ToString();
                dataReader.Close();
            }
            return user;
        }

        public User add(User obj)
        {
            User res=new User();
            res.email = obj.email;
            res.login= obj.login;
            res.password = obj.password;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO user (login,password,email) VALUES(@login,@password,@email)";
                command.Parameters.AddWithValue("@login", obj.login);
                command.Parameters.AddWithValue("@password", obj.password);
                command.Parameters.AddWithValue("@email", obj.email);
                connection.Open();
                command.ExecuteNonQuery();
                res.user_ID = (int)command.LastInsertedId;
            }
            return res;
        }

        public void update(User obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE user SET login=@login,password=@password,email=@email WHERE user_ID=@user_ID";
                command.Parameters.AddWithValue("@login", obj.login);
                command.Parameters.AddWithValue("@password", obj.password);
                command.Parameters.AddWithValue("@email", obj.email);
                command.Parameters.AddWithValue("@user_ID", obj.user_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void delete(User obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM user WHERE user_ID = @user_ID";
                command.Parameters.AddWithValue("@user_ID", obj.user_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<User> getAll()
        {
            List<User> users = new List<User>();
            User user = null;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM user";
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user = new User();
                    user.login = dataReader["login"].ToString();
                    user.password = dataReader["password"].ToString();
                    user.email= dataReader["email"].ToString();
                    user.user_ID= int.Parse(dataReader["user_ID"].ToString());
                    users.Add(user);
                }
                dataReader.Close();
            }
            return users;
        }
    }
}