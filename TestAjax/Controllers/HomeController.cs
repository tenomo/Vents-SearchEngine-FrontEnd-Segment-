using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAjax.Models;

namespace TestAjax.Controllers
{
    
       
    public class HomeController : Controller
    {

        List<TestModel> list = new List<TestModel>();
        public HomeController()
        {
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new TestModel { Name = "test" + i, Id = i });
            }

        }


        public ActionResult Index( )
        {
           
            return View();
        }

        public JsonResult Search(string segmentName = "0")
        {
            System.Diagnostics.Debug.WriteLine("Количество выбраных элементов: " + list.Where(x => x.Name.Contains(segmentName)).Count());
            return Json( list.Where(x => x.Name.Contains(segmentName)), JsonRequestBehavior.AllowGet);
        }

            //===================

        public JsonResult GetTestModel(int modelId)
        {
            System.Diagnostics.Debug.WriteLine("====================\n GetTestModel(model id: " + modelId + ")");
            System.Diagnostics.Debug.WriteLine("Найденая модель " + list.First(x => x.Id == modelId));                   
            return Json(list.First(x=>x.Id == modelId), JsonRequestBehavior.AllowGet);
        }
            //====================



        public JsonResult TestGet ()//(string x = "void")
        {

            string[] arr =
                {
                "Благими намерениями вымощена дорога в ад",
                "Волка ноги кормят.", "Всяк по-своему с ума сходит",
                "Всяк правду ищет, да не всяк ее творит.",
                "Голод в мир гонит.",
                "Денежный грех — на богатого",
                "До слова — крепись, а давши слово — держись.",
                "Если больная смотрит в зеркало — значит она выздоравливает.",
                "Не оскверняй меня своим курсором!",
                "Кто не с нами, тот против нас",
                "Лучше меня не злить",
                "Я слишком стар для всего этого",
                "Настоящая война будет завтра, с бодуна!",
                "Здесь есть хоть одна винная лавка?" ,
                "Вскрытие показало: больной спал.",
                "Ну что, лечить или пусть живёт?",
                "Время лечит, но жрец — быстрее.",
                "Побочные эффекты могут включать: сухость во рту, тошнота, рвота, задержка воды, болезненный ректальный зуд, галлюцинации, деменция, психозы, кома, смерть и дурной запах изо рта.Магия не для всех. Перед использованием проконсультируйтесь с врачом",
                "— Скажи-ка, дядя, ведь недаром?…"
            };

            string res = null;

            Random rnd = new Random();
         //   int count = rnd.Next(1,arr.Length-1);
          //  for (int i = 0; i < count; i++)
          //  {
                res +=" "+ arr[rnd.Next(0, arr.Length - 1)];
          //  }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMP(string term)
        {
             
            return Json("test entry", JsonRequestBehavior.AllowGet);
        }
        //[AcceptVerbs(HttpVerbs.Get)]
        //public ActionResult Fo()
        //{
        //    Random rnd = new Random();
        //    List<string> strList = new List<string>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        strList.Add("Запись: " + i + ", значение: " + rnd.Next(-1000, 10000));
        //    }

        //    return Json(strList);
        //}
    }
}