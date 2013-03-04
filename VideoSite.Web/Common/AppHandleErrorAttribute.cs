using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoSite.Web.Common
{
    public class AppHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //记日志
            //ILogger log = LogManager.GetCurrentClassLogger(); 
            Exception ex = filterContext.Exception;
            if (ex is WebException)
            {
                // log.Error("自定义异常（WebException）：", ex); 
                //表示异常已处理，直接跳到500显示错误消息
                filterContext.ExceptionHandled = true;
            }
            else
            {
                // log.Error("系统异常：", ex); 
            };

            var routeData = new RouteValueDictionary();
            routeData.Add("controller", "Error");
            routeData.Add("action", "Unknown");

            filterContext.Result = new RedirectToRouteResult("Error/Unknown", routeData);
        }
    }
}