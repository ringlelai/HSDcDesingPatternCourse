using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using hsdc.dpt.Control.Structural.Facade;
using hsdc.dpt.Control.DTO;

namespace WebMVC.Controllers.Structural
{
    public class FacadeController : Controller
    {
        private 買烏龜Control control = new 買烏龜Control();        
        private List<烏龜商品> itemList;
        private ShoppingCart cart = new ShoppingCart();

        // GET: Facade
        public ActionResult Index()
        {                        
            // 取得烏龜販賣清單
            itemList = control.list烏龜清單();

            // Hold the itemList to Stateful State.
            Session["ItemList"] = itemList;

            //return View(dto);
            return View(itemList);
        }

        [HttpPost]
        public ActionResult AddToCart()
        {
            cart.CartList = new List<烏龜商品>();

            烏龜商品 m_item;
            string m_id, m_qty;

            // Get the itemList from Session Object.
            itemList = (List<烏龜商品>)Session["ItemList"];
                                    
            // Get the Form's ID
            string[] keys = Request.Form.AllKeys;
            foreach (var key in keys)
            {
                if (key.Contains("id"))
                { 
                    m_id = Request.Params[key];
                    m_item = itemList.Where(t => t.id == m_id).SingleOrDefault();       // 取得所相對應烏龜清單內的商品

                    if (m_item != null)
                    {
                        m_qty = Request.Params["qty_" + m_id];
                        if (string.IsNullOrEmpty(m_qty))
                            continue;
                        m_item.quantity = Int32.Parse(m_qty);
                        cart.CartList.Add(m_item);              // 將所購買的商品放入 ShoppingCart 物件內
                    }
                }
            }
            cart.eCoupon = Request["txtCoupon"];        // 取得 Coupon 欄位值
            cart = control.確認訂購資訊(cart);          // 交由 Facade 物件計算訂購總額，並再將結果傳回

            Session["ShoppingCart"] = cart;             // Hold the ShoppingCart object to Session

            return View(cart);
        }

        // 結帳
        public ActionResult Checkout(string btnCheckout)
        {
            switch (btnCheckout)
            {
                case "結帳" :
                    {
                        cart = (ShoppingCart)Session["ShoppingCart"];
                        ViewData["result"] = this.SaveOrder(cart);          // 將處理儲存訂購結果回傳給 View
                        return View();
                    }
                case "取消" :
                    return RedirectToAction("Index", "Facade");
                default: return View();
            }
        }

        // 委由 Facade 物件儲存本次的訂購交易
        private string SaveOrder(ShoppingCart cart)
        {
            if (control.Save訂購交易(cart))
                return "訂購完成";
            else
                return "交易失敗";
        }
    }
}