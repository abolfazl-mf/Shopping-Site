using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using ZarinPal.Class;

namespace product__easy_learn_.Controllers
{
    //public class zarinpal1Controller : Controller
    //{
    //    private Payment _payment;
    //    public zarinpal1Controller()
    //    {
    //        var expose = new Expose();
    //        _payment = expose.CreatePayment();
    //    }
    //   public async Task<IActionResult> Peyment1()
    //    {
    //        var result= await _payment.Request(new Dto.Payment.DtoRequest(){ 
    //            Amount= 20000,
    //            Description="خرید محصول",
    //            CallbackUrl= "https://localhost:44330/zarinpal1/validate",
    //            MerchantId="XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
    //        },ZarinPal.Class.Payment.Mode.sandbox);
    //        return Redirect($"https://sandbox.zarinpal.com/pg/StartPey/{result.Authority}");
    //    }
    //    public async Task<IActionResult> Validate(string authority,string status)
    //    {
    //        var verfication = await _payment.Verification(new Dto.Payment.DtoVerification { 
    //        Amount=20000,
    //        Authority=authority,
    //        MerchantId= "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
    //        },ZarinPal.Class.Payment.Mode.sandbox);
    //        if (status !=null && authority !=null && status=="OK")
    //        {
    //            if (verfication.Status==100)
    //            {
    //                ViewBag.refId = verfication.RefId;
    //                ViewBag.Success = true;
    //            }
    //            else
    //            {
    //                ViewBag.Success = false;
    //            }
    //            return View();
    //        }
    //        else
    //        {
    //            ViewBag.Success = false;
    //            return View();
    //        }
    //    }
    //}
}
