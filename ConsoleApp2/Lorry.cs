using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс-потомок Грузовик, потомок абстрактного класса Транспортного средства
    /// </summary>
    class Lorry : Vehicle
    {
        /// <summary>
        /// Свойства поля Максимальная емкость
        /// </summary>
        public int maxCapacity { get; set; }
        /// <summary>
        /// Переопределённый метод из класса Транспортное средство
        /// </summary>
        public override void SpecificalParameters()
        {
            Console.Write("Ввести максимальную вместимость грузовика:");
            maxCapacity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
