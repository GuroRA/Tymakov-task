using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_task
{
    internal class Program
    {
        static void Zina(Stack<Dweller> dwellers, Queue<Dweller> window1, Queue<Dweller> window2, Queue<Dweller> window3)
        {
            while (dwellers.Count > 0)
            {
                Dweller dweller = dwellers.Pop();

                if (dweller.Temperament.Wisdom == 0)
                { 
                    int rnd = new Random().Next(1, 3);
                    switch (rnd)
                    {
                        case 1:
                            window1.Enqueue(dweller);
                            break;
                        case 2:
                            window2.Enqueue(dweller);
                            break;
                        case 3:
                            window3.Enqueue(dweller);
                            break;
                    }
                }
                else if (dweller.Problem.Description.ToLower().Contains("отоплен"))
                {
                    window1.Enqueue(dweller);
                }
                else if (dweller.Problem.Description.ToLower().Contains("оплат"))
                {
                    window2.Enqueue(dweller);
                }
                else 
                {
                    window3.Enqueue(dweller);
                }
            }
        }
        static void Main(string[] args)
        {
            Queue<Dweller> window1 = new Queue<Dweller>();
            Queue<Dweller> window2 = new Queue<Dweller>();
            Queue<Dweller> window3 = new Queue<Dweller>();

            Dweller Pasha = new Dweller("Паша", Guid.NewGuid(), Guid.NewGuid(), "Проблемы с оплатой", 4, 1);
            Dweller Mark = new Dweller("Марк", Guid.NewGuid(), Guid.NewGuid(), "Нет отопления", 3, 0);
            Dweller Sophia = new Dweller("Софья", Guid.NewGuid(), Guid.NewGuid(), "Нет холодной воды", 4, 24);
            Dweller Leroy = new Dweller("Лерой", Guid.NewGuid(), Guid.NewGuid(), "Нет отопления", 36, 1);
            Dweller Sergey = new Dweller("Сергей", Guid.NewGuid(), Guid.NewGuid(), "Забился сортир", 8, 1);
            Dweller Tom = new Dweller("Том", Guid.NewGuid(), Guid.NewGuid(), "Проблемы с оплатой", 7, 0);

            Zina(Dweller.Objects, window1, window2, window3);

            while (window1.Count > 0)
            {
                Console.WriteLine(window1.Dequeue().Name);
            }
            Console.ReadKey();
        }
    }
}
