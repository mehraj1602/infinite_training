
using Custon_ModelBinding_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_ModelBinding_Prj.CustomBindings
{
    public class EmpCustomBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            string title = request.Form.Get("title");
            string firstname = request.Form.Get("firstname");
            string middlename = request.Form.Get("middlename");
            string lastname = request.Form.Get("lastname");

            return new EmployeeModel
            {
                Title = title,
                EmpFullName = firstname + " " + middlename + " " + lastname
            };
        }
    }
}