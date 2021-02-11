using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ToDoApp
{
    /// <summary>
    /// クライアントからの要求をRouteConfigの内容を元に呼び出すコントローラーを決定
    /// </summary>
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                //呼び出される形式はこのurlメソッドで定義できる。例:http://localhost:8080/Todoes/Details/3　の場合
                //「Controllerフォルダ」→「TodoesControllers.cs」の→が呼ばれる  public ActionResult Details(int? id)
                url: "{controller}/{action}/{id}",
                //要求にcontrollerとactionがなければdefaultsのページが呼ばれる
                defaults: new { controller = "Todoes", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
