using IMS.Models;
using IMS.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Controllers
{
    class TryManageRecever
    {
        private Recever Recever { get; set; }
        ReceverContext context = new ReceverContext();

        public TryManageRecever(Recever Recever)
        {
            this.Recever = Recever;
        }

        public async Task<Recever> InsertAsync()
        {
            try
            {
                var recever = context.Recevers.Add(this.Recever);
                await context.SaveChangesAsync();
                return this.Recever;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                context.Dispose();
            }
        }

        public async Task<bool> UpdateAsync(string Code)
        {
            try
            {
                var recever = context.Recevers.FirstOrDefault(r => r.ReceverCode == Code);
                if (recever == null) return false;
                recever.ReceverCode = Code;
                recever.Name = Recever.Name;
                recever.Mobile = Recever.Mobile;
                recever.Designation = Recever.Designation;
                await context.SaveChangesAsync();
                return true; ;
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

        public async Task<bool> DeleteAsync(string Code)
        {
            try
            {
                var recever = context.Recevers.FirstOrDefault(r => r.ReceverCode == Code);
                if (recever == null) return false;
                context.Recevers.Remove(recever);
                await context.SaveChangesAsync();
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
