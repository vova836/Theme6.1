using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс-потомок Автомобиль, потомок абстрактного класса Транспортного средства
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// Свойства поля Мощность
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// Переопределённый метод из класса Транспортное средство
        /// </summary>
        public override void SpecificalParameters()
        {
            Console.Write("Ввести мощность автомобиля:"); 
            Power = Convert.ToInt32(Console.ReadLine());
        }
    }
}
