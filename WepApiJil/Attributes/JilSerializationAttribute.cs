using System;
using System.Web.Http.Controllers;
using WepApiJil.Formatters;

namespace WepApiJil.Attributes
{
    public sealed class JilSerializationAttribute : Attribute, IControllerConfiguration
    {
        public void Initialize(HttpControllerSettings controllerSettings, HttpControllerDescriptor controllerDescriptor)
        {
            // Register JilMediaTypeFormatter for controller
            controllerSettings.Formatters.Insert(0, new JilMediaTypeFormatter());
        }
    }
}