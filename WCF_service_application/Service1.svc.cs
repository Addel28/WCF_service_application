using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WCF_service_application.Data;
using WCF_service_application.Models;

namespace WCF_service_application
{
    public class Service1 : IService1
    {
        public List<UserModel> Services = new List<UserModel>();
        public List<UserModel> Users = new List<UserModel>();

        public void DeleteDB(int id)
        {

            UserModel user = Users.FirstOrDefault(u => u.Id == id); 
            Users.Remove(user);
            //using (WCFDbContext UData = new WCFDbContext())
            //{
            //    UserModel user = UData.UserModel.FirstOrDefault(u => u.Id == id);
            //    if (user != null)
            //    {
            //        UData.UserModel.Remove(user);
            //        UData.SaveChanges();
            //    }
            //}
        }

        public string GetLine()
        {

            //using (WCFDbContext UData = new WCFDbContext())
            //{
            //    Users = UData.UserModel.ToList();
            //}
            string line = "";
            for(int i = 0;i<Users.Count;i++)
            {
                line += $"{Users[i].Id}"+ $"{Users[i].Name}"+ $"{Users[i].Password}";
            }
            return line;

        }

        public void FirstStartDB()
        {
            using (WCFDbContext UData = new WCFDbContext())
            {

            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string Push(int id)
        {
            UserModel UserName = Users.Find(find => find.Id == id);

            return UserName.Name;
        }

        public void SecondStartDB()
        {
            // Реализация вторичной настройки базы данных, если необходимо
        }

        public List<UserModel> SelectDb()
        {
            try
            {
                //using (WCFDbContext UData = new WCFDbContext())
                //{
                //    Users = UData.UserModel.ToList();
                //}
            }
            catch
            {

            }
            return Users;
        }

        public UserModel SelectDb1(int id)
        {
            UserModel user = null;
            try
            {
                user = Users.FirstOrDefault(u => u.Id == id);
                //using (WCFDbContext UData = new WCFDbContext())
                //{
                //    user = UData.UserModel.FirstOrDefault(u => u.Id == id);
                //}
            }
            catch (Exception ex)
            {

            }
            return user;
        }

        public void POST(UserModel user)
        {
            try
            {
                Users.Add(user);
                //using (WCFDbContext UData = new WCFDbContext())
                //{
                //    UData.UserModel.Add(user);
                //    UData.SaveChanges();

                //}
            }
            catch (Exception ex)
            {

            }
        }
        public void Update(UserModel user)
        {
            try
            {
                var update = Users.FirstOrDefault(i => i.Id == user.Id);
                Users.Remove(update);
                update = user;
                Users.Add(update);
                //using (WCFDbContext UData = new WCFDbContext())
                //{
                //    var update = UData.UserModel.FirstOrDefault(i => i.Id == user.Id);
                //    if (update != null)
                //    {
                //        update.Name = user.Name;
                //        UData.SaveChanges();
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
        }
    }
}