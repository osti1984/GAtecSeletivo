﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAtec.Seletivo.Domain.Model.Extended;
using GAtec.Seletivo.Util.Libs;
using GAtec.Seletivo.Domain.Business;

namespace GAtec.Seletivo.Web.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IUserService _userService;

        public AdminController(IUserService userService)
        {
            this._userService = userService;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginInfo input)
        {
            if (!ModelState.IsValid)
                return View(input);

            var getUser = _userService.Get(input.Username, input.Password);

            if (getUser != null)
            {
                if (getUser.Type.Equals(Domain.Model.UserType.Admin))
                {
                    Auth.LogIn(input.Username, "Admin");

                    return RedirectToAction("Index", "Admin");
                }
            }

            return View(input);

        }

        public ActionResult Logout()
        {
            Auth.LogOut();

            return RedirectToAction("Index", "Home");
        }
    }
}