using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Models;
using IMS.Models.Contexts;


namespace IMS.Controllers
{
    class TryUpdateUser
    {
        private UserData UserData;
        UserDataContext context = new UserDataContext();

        public TryUpdateUser(UserData userData)
        {
            this.UserData = userData;
        }

        public bool Update()
        {

            try
            {
                UserData data = context.UsersData.FirstOrDefault(user => user.Username == Program.User);
                if (data == null) return false;
                data.FirstName = UserData.FirstName;
                data.LastName = UserData.LastName;
                data.Email = UserData.Email;
                data.Picture = UserData.Picture;
                data.Username = UserData.Username;
                data.Password = UserData.Password;
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                context.Dispose();
            }
        }

        public bool  InsertUser()
        {
            try
            {
                context.UsersData.Add(UserData);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                context.Dispose();
            }
        }

        public bool DeleteUser(int ID)
        {
            UserDataContext context = new UserDataContext();
            try
            {
                UserData U = context.UsersData.FirstOrDefault(usr => usr.ID == ID);
                context.UsersData.Remove(U);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                context.Dispose();
            }
        }

    }
}
