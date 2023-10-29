using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RKPP_Labs
{
    public abstract class Workshop // абстарктный класс фабрики
    {
        public string? WorkshopName;

        public string? BossName;

        public virtual int NumberOfWorkers { get; set; }

        public List<string> ProductsName = new List<string>();

        public abstract Product CreateProduct();



    }
}
