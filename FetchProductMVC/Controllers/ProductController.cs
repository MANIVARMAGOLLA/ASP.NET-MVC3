using FetchProductBL;
using FetchProductDTO;
using FetchProductMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FetchProductMVC.Controllers
{
    public class ProductController : Controller
    {

        FPBL blObj;
        public ProductController()
        {
            blObj = new FPBL();
        }
        // GET: Product
        public ActionResult ViewAllProduct()
        {
            try
            {
                List<FPDTO> lstAllProducts = blObj.GetAllProducts();
                List<ProductsView> lstFinalProdView = new List<ProductsView>();

                foreach (FPDTO product in lstAllProducts)
                {
                    lstFinalProdView.Add(new ProductsView()
                    {
                        ProdName = product.ProductName,
                        Prodcolor = product.Productcolor,
                        ProdListPrice = product.ProductListPrice
                    }); ;
                }

                return View(lstFinalProdView);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}