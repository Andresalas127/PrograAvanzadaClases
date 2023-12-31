﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKNPrograAvanzada.Entities;
using WebKNPrograAvanzada.Models;

namespace WebKNPrograAvanzada.Controllers
{
    public class LoginController : Controller
    {
        //Esto es una instancia
        UsuarioModel claseUsuario = new UsuarioModel();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();

        }
        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            claseUsuario.IniciarSesion(entidad);
            return View();

        }
        [HttpGet]
        public ActionResult RegistrarCuenta()
        {
            return View();

        }
        [HttpPost]
        public ActionResult RegistrarCuenta(UsuarioEnt entidad)
        {
            claseUsuario.RegistrarCuenta(entidad);
            return View();

        }

        [HttpGet]
        public ActionResult RecuperarCuenta()
        {
            return View();

        }
        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            claseUsuario.RecuperarCuenta(entidad); 
            return View();

        }




    }
}