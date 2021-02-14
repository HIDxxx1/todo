using sun.security.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
        //認証していない状態でログインするのでAllowAnonymousを設定
      [AllowAnonymous]
      public class LoginController : Controller
      {

        readonly CustomMembershipProvider membershipProvider = new CustomMembershipProvider();
          // GET: Login
          public ActionResult Index()
          {
            return View();
          }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "UserName,Password")]LoginViewModel model)
        {
            //UseNameとPasswordが適切かチェックする
            if (ModelState.IsValid)
            {
                if (this.membershipProvider.ValidateUser(model.UserName, model.Password))
                {
                    //条件が正しければ認証クッキーを設定して認証状態を保持する
                    //SetAuthCookieでUserNameをクッキーに保持し、認証クッキーがブラウザに保持されている間は認証状態と言うこと
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    //認証が完了したらTodoesコントローラーのIndexに処理をリダイレクトする
                    return RedirectToAction("Index", "Todoes");
                }
            }
            ViewBag.Message = "ログインに失敗しました。";
            return View(model);
        }
      public ActionResult SignOut()
        {
            //認証クッキーを削除してホーム画面
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");

        }
    }
}