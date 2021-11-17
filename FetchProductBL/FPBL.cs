using FetchProductDAL;
using FetchProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchProductBL
{
    public class FPBL
    {
        FPDAL dalObj;
        public FPBL()
        {
            dalObj = new FPDAL();
        }
        public List<FPDTO> GetAllProducts()
        {
            try
            {
                List<FPDTO> lstResult = dalObj.FetchAllProduct();
                return lstResult;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
