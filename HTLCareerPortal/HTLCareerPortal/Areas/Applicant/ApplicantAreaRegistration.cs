﻿using System.Web.Mvc;

namespace HTLCareerPortal.Areas.Applicant
{
    public class ApplicantAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Applicant";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Applicant_default",
                "Applicant/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                 new[] { "HTLCareerPortal.Areas.Applicant.Controllers" }
            );
        }
    }
}