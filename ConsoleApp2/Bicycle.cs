using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс-потомок Велосипед, потомок абстрактного класса Транспортного средства
    /// </summary>
    class Bicycle : Vehicle
    {
        /// <summary>
        /// Свойства поля Количество пасажиров
        /// </summary>
        public int maxPassengers { get; set; }
        /// <summary>
        /// Переопределённый метод из класса Транспортное средство
        /// </summary>
        public override void SpecificalParameters()
        {
            Console.Write("Ввести количество пасажиров на велосипеде:");
             maxPassengers = Convert.ToInt32(Console.ReadLine());
        }
    }
}
