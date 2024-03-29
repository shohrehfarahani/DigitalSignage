﻿using Aryaban.Engine.Core.WebService;
using DigitalSignageUI.Models.Entity;
using DigitalSignageUI.Models.ServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalSignageUI.Controllers
{
    public class ShowController : Controller
    {
        
        public ActionResult ShowContent()
        {
            return View();
        }


        //Partial
        public ActionResult ShowContent_Type1()
        {
            return View();
        }


        //Load Content
        [HttpPost]
        public ActionResult loadContent( long content_id)
        {

            
            ContentProxy serviceProxy = new ContentProxy();
            ResultMessage<List<AdsInfo>> contentList = serviceProxy.loadContentsWithAdsItemDetail( content_id);

            if (contentList.result.status == Aryaban.Engine.Core.WebService.Result.state.error)
                //Redirect To Error Page
                return RedirectToAction("Error", "Error");

            JsonResult result = new JsonResult();
            result.Data = contentList;
            return result;
        }

    }
}