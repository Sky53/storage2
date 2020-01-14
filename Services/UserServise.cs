using Microsoft.EntityFrameworkCore;
using storage2.Models;
using storage2.Services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    public class UserServise : IUserServise
    {
        public void AddUser(string nameUser, string login, string password, string dateOfBrith)
        {
            using (StorageContext storageConrext = new StorageContext()) {
                User addUser = new User();
                addUser.Id = Guid.NewGuid();
                addUser.NameUser = nameUser;
                addUser.Login = login;
                addUser.Password = password;
                //TODO
                //user.DateOfBrith = Created Parse method for date;
                addUser.DateOfBrith = DateTime.Now;
                addUser.IsDeleted = false;
                storageConrext.users.Add(addUser);
            }
        }

        public void DeleteUser(string id)
        {
            using (StorageContext storageConrext = new StorageContext())
            {
                User removeUser = storageConrext.users.FirstOrDefault(ent => ent.Id == new Guid(id));
                if(removeUser != null)
                {
                    storageConrext.users.Remove(removeUser);
               //     removeUser.IsDeleted = true;
                    storageConrext.SaveChanges();
                }
            }
               
        }

        public List<User> GetAllUsers()
        {
            using (StorageContext storageConrext = new StorageContext())
            {
                var users = storageConrext.users.Include(c => c.NameUser).ToList();
                return users;
            }
                throw new NotImplementedException();
        }

        public User GetFirstUserForName(string nameUser)
        {
            throw new NotImplementedException();
        }

        public User GetUserForId(string id)
        {
            using (StorageContext storageConrext = new StorageContext())
            {
                User findUser = storageConrext.users.FirstOrDefault(ent => ent.Id == new Guid(id));
                if (findUser != null)
                {
                    return findUser;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<User> GetUsersForName(string nameUser)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string id ,string nameUser, string login, string password, string dateOfBrith)
        {
            using (StorageContext storageConrext = new StorageContext())
            {
                User updateUser = storageConrext.users.FirstOrDefault(ent => ent.Id == new Guid(id));
                updateUser.Id = Guid.NewGuid();
                updateUser.NameUser = nameUser;
                updateUser.Login = login;
                updateUser.Password = password;
                //TODO
                //user.DateOfBrith = Created Parse method for date;
                updateUser.DateOfBrith = DateTime.Now;
                storageConrext.SaveChanges();
            }
        }
    }
}
