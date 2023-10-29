

using RKPP_Labs.Lab2;

namespace RKPP_Labs
{
    internal class Program
    {
        static void Main(string[] args)
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
                                                                            "Токарный цех №4",17);        
            turningShop4.Print();
            turningShop4.CreateProduct();
            

        }
    }
}