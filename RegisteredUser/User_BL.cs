using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUser_BL
{
    public class User_BL
    {
        string conn = "Database = shop; Data Source = localhost; User Id = Адмін; Password = 1234";

        public string Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }

        public User getUserByLogPas(string login,string password) {

            UserService userService = new UserService(conn);
            List<User> usersList = userService.getAll();

            foreach (DAL.Entities.User user in usersList) {

                if (user.login.Equals(login) &&
                    user.password.Equals(password)) {

                    return user;

                }
            }
            return null;
        }

        public bool isLoginExist(string login)
        {
            UserService userService = new UserService(conn);
            List<User> usersList = userService.getAll();

            foreach (DAL.Entities.User user in usersList)
            {
                if (user.login.Equals(login))
                {
                    return true;
                }
            }
            return false;
        }

        public bool isEmailExist(string email)
        {
            UserService userService = new UserService(conn);
            List<User> usersList = userService.getAll();

            foreach (DAL.Entities.User user in usersList)
            {
                if (user.email.Equals(email))
                {
                    return true;
                }
            }
            return false;
        }

        public User createUser(User newUser) {
            UserService userService = new UserService(conn);
            if (isLoginExist(newUser.login)) return null;
            if (isEmailExist(newUser.email)) return null;

            return userService.add(newUser);
        }

    }
}
