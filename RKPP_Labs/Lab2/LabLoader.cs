using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKPP_Labs.Lab2
{
    class LabLoader
    {
        public static void LoadLab_2()
        {
            try
            {
                TurningShop turningShop2 = new TurningShop();

                turningShop2.Print();

                turningShop2.NumberOfWorkers = -15;

            }
            catch (WorkshopNegativValueExeption)
            {
                Console.WriteLine("Исключение обработанно!");

            }


            TurningShop turningShop4 = new TurningShop("Сергей Инвановчи", new List<string>()
                                                                           {
                                                                            "Изделие1",
                                                                            "Изделие2",
                                                                            "Изделие3"
                                                                            },
                                                                            "Токарный цех №4", 17);
            turningShop4.Print();
            turningShop4.CreateProduct();

        }
    }
}
