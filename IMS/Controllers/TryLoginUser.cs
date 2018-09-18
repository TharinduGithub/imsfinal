using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Models;
using System.Data.SqlClient;
using IMS.Models.Contexts;
using System.Windows.Forms;

namespace IMS.Controllers
{
    class TryLoginUser
    {
        public bool IsUser { get; }
        public string UserRoll { get;}
        private User user;

        public TryLoginUser() { }

        public TryLoginUser(User user)
        {
            this.user = user;

            UserDataContext context = new UserDataContext();

            try
            {
                List<UserData> Usrs = context.UsersData.ToList();
                if (Usrs.Count == 0)
                {
                    if (user.Username == "Admin" && user.Password == "12345")
                    {
                        context.UsersData.Add(new UserData() { Username = "Admin", Password = "12345", UserType = "Administrator", FirstName = "Unknown", LastName = "Unknown", Email = "Yourname@example.com" });
                        context.SaveChanges();

                        this.IsUser = true;
                        this.UserRoll = "Administrator";
                        Program.IsAuthenticated = true;
                        Program.UserRoll = "Administrator";
                        Program.User = "Admin";
                        Program.UserID = 1;
                        return;
                    }

                }

                UserData U = Usrs.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
                if (U == null) return;

                if (U.UserType == "Administrator")
                {
                    this.IsUser = true;
                    this.UserRoll = "Administrator";

                    Program.IsAuthenticated = true;
                    Program.UserRoll = "Administrator";
                    Program.User = U.Username;
                    Program.UserID = U.ID;

                }
                else if (U.UserType == "User")
                {

                    this.IsUser = true;
                    this.UserRoll = "User";

                    Program.IsAuthenticated = true;
                    Program.UserRoll = "User";
                    Program.User = U.Username;
                    Program.UserID = U.ID;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Program.ErrorCode = ex.HResult;
            }
            finally
            {
                context.Dispose();
            }

        }


    }
}
