using Microsoft.EntityFrameworkCore;
using System;
using Task.DAL.EF;
using Task.DAL.Entities;
using Task.DAL.Repositories.Interfaces;

namespace Task.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AvtoContext db;

        public UserRepository (AvtoContext context)
        {
            this.db = context;
        }
        public void AddUser(UserEntity user)
        {
            if (user != null)
            {
                db.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteUserById(int id)
        {
            UserEntity toDelete = db.Find(id);
            if (toDelete != null)
            {
                db.Remove(toDelete);
                db.SaveChanges();
            }
        }

        public UserEntity GetUserId(int id)
        {
            return db.Find(id);
        }

        public void UpdateUser(UserEntity user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
