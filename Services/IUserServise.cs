using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    interface IUserServise
    {
        public List<User> GetAllUsers();
        public User GetUserForId(string id);
        public User GetFirstUserForName(string nameUser);
        public List<User> GetUsersForName(string nameUser);
        public void AddUser(string nameUser, string login, string password, string dateOfBrith);
        public void UpdateUser(string id, string nameUser, string login, string password, string dateOfBrith);
        public void DeleteUser(string id);

    }
}
