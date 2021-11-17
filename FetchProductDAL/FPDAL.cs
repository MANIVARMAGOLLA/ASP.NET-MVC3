using FetchProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchProductDAL
{
    public class FPDAL
    {
        AdventureWorks2012Entities contextObj;
        public FPDAL()
        {
            contextObj = new AdventureWorks2012Entities();
        }
        public List<FPDTO> FetchAllProduct()
        {
            try
            {

                List<Product> lstProductFromDB = contextObj.Products.ToList();

                List<FPDTO> lstFinalProductList = new List<FPDTO>();
                foreach (Product product in lstProductFromDB)
                {
                    lstFinalProductList.Add(new FPDTO()
                    {
                        ProductID = product.ProductID,
                        ProductName = product.Name,
                        Productcolor = product.Color,
                        ProductListPrice =product.ListPrice,
                       
                    });
                }
                return lstFinalProductList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
