using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Andia.Models;

namespace Lab2_MVC_Andia.Controllers
{
    public class PersonaController : Controller
    {
        List<Cls_Persona> objLista = new List<Cls_Persona>();
        // GET: Persona
        public ActionResult Index()
        {

            //--------------Instanciar para el objeto 1--------------
            Cls_Persona objPersona1 = new Cls_Persona();

            //--------------Instanciar los atributos de la clase--------------
            objPersona1.apellido = "Porlles Carrillo";
            objPersona1.nombre = "Diego";
            objPersona1.email = "dporlles@upt.pe";
            objPersona1.sexo = true;
            objPersona1.edad = 22;
            objPersona1.talla = 1.65;

            //--------------Pasar el objeto a la lista--------------
            objLista.Add(objPersona1);

            //--------------Instanciar para el objeto 2--------------
            Cls_Persona objPersona2 = new Cls_Persona();

            //--------------Instanciar los atributos de la clase--------------
            objPersona2.apellido = "Mamani Ayala";
            objPersona2.nombre = "Brandon";
            objPersona2.email = "bmamani@upt.pe";
            objPersona2.sexo = true;
            objPersona2.edad = 23;
            objPersona2.talla = 1.60;

            //--------------pasar el objeto a la lista--------------
            objLista.Add(objPersona2);

            //--------------Instanciar para el objeto 3--------------
            Cls_Persona objPersona3 = new Cls_Persona();

            //--------------Instanciar los atributos de la clase--------------
            objPersona3.apellido = "Sosa Bedoya";
            objPersona3.nombre = "Sharon";
            objPersona3.email = "ssosa@upt.pe";
            objPersona3.sexo = false;
            objPersona3.edad = 24;
            objPersona3.talla = 1.65;

            //-----------pasar el objeto a la lista--------------
            objLista.Add(objPersona3);

            //Instanciar para el objeto 1
            Cls_Persona objPersona4 = new Cls_Persona();

            //Instanciar los atributos de la clase
            objPersona4.apellido = "Estrella Palacios";
            objPersona4.nombre = "Katherine";
            objPersona4.email = "kestrella@upt.pe";
            objPersona4.sexo = false;
            objPersona4.edad = 24;
            objPersona4.talla = 1.72;

            //--------------pasar el objeto a la lista--------------
            objLista.Add(objPersona4);

            //--------------retornamos el objeto--------------
            return View(objLista);
        }
    }
}