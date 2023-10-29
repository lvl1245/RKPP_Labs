using RKPP_Labs.Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKPP_Labs
{
    partial class TurningShop : Workshop, IPrintable
    {
        private string WorkshopNegativValueMessage = "Некорректное значение для колличества работников";

        private int numberOfWorkers = 0;
        public TurningShop() // конструктор 1
        {
            BossName = "Empty";
            ProductsName = new List<string>();
            WorkshopName = "Unknown turning shop";
            NumberOfWorkers = 0;
        }

        public TurningShop(string BossName, List<string> ProductsName, string WorkshopName, int NumberOfWorkers) // конструктор 2
        {
            this.BossName = BossName;
            this.ProductsName = ProductsName;
            this.WorkshopName = WorkshopName;
            this.NumberOfWorkers = NumberOfWorkers;
        }

        public override Product CreateProduct() // переопределенный метод
        {
            Console.WriteLine("Бим Бим");

            Console.WriteLine("Бам Бам");

            Console.WriteLine("Продукт готов");

            return new Product();
        }

        public override int NumberOfWorkers // переопределенное свойство
        {
            get { return this.numberOfWorkers; }
            set {
                if (value > 0) { 
                    numberOfWorkers = value; 
                } 
                else {             
                    throw new WorkshopNegativValueExeption(WorkshopNegativValueMessage, value);
                }
            }
        }

        public void Print() // реализация интерфейса
        {
            Console.WriteLine($"Workshop: {WorkshopName}\n" +
                $"Boss: {BossName}\n" +
                $"Number of workers: {NumberOfWorkers}\n" +
                $"Count of products {ProductsName.Count}");
        }

        public string this[int index] // индексатор 
        {
            get => ProductsName[index];
            set => ProductsName[index] = value;
        }
    }
}
