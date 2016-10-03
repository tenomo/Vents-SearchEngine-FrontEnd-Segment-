using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAjax.Models
{
    public class TestModel
    {
        string name;
        string model;
        int id;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Model
        {
            get
            {
                return "sld-1 model Azf-09-14 : " + name;
            }


        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + Name + "\n" + Id + "\n" + Model;
        }
    }
}