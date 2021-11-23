using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGalleryPresentation.Proxy.Sample
{
    public interface IOfficeInternetAccess
    {
        void AccessInternet(int employeeId);
    }

    public class OfficeInternetAccess : IOfficeInternetAccess
    {
        public void AccessInternet(int employeeId)
        {
            // Allows to access internet to anyone
        }
    }

    public class ProtectionProxy : IOfficeInternetAccess
    {
        public void AccessInternet(int employeeId)
        {
            if (GetRole(employeeId) > 4)
            {
                var internetAccess = new OfficeInternetAccess();
                // allow internet access
            }
            else
            {
                throw new Exception
                    ("not allowed to access internet");
            }
        }
        private int GetRole(int empId)
        {
            return 9;
        }
    }
}
