﻿using System.Web.Mvc;

namespace AspNetMVCEgitimi.NETFramework.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {Controller = "Categories", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}