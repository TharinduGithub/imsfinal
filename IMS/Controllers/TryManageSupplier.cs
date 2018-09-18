using IMS.Models;
using IMS.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Controllers
{
    class TryManageSupplier
    {
        private Supplier Sup;
        VendorContext context = new VendorContext();

        public TryManageSupplier(Supplier S)
        {
            this.Sup = S;
        }

        public async Task<Supplier> InsertSupplier(int ID)
        {
            try
            {

                Sup.Vendor = context.Venders.Where(c => c.ID == ID).First();
                context.Suppliers.Add(Sup);
                await context.SaveChangesAsync();
                return Sup;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                context.Dispose();
            }
        }

        public void Update(int ID)
        {
            try
            {
                var supplier = context.Suppliers.Where(s=>s.Code == Sup.Code).Single();
                supplier.Name = Sup.Name;
                supplier.Mobile = Sup.Mobile;
                supplier.JoinDate = Sup.JoinDate;
                supplier.Vendor = context.Venders.Where(v => v.ID == ID).First();
                context.SaveChanges();

            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                context.Dispose();
            }

        }
    }
}
