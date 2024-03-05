using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Абстрактный класс Транспортное средство
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        /// Свойства поля Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Свойства поля Максимальной скорости
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Свойства поля Год
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Абстрактный метод для задания специфичных параметров средства передвижения
        /// </summary>
        public abstract void SpecificalParameters();
        /// <summary>
        /// Метод для вывода информации о транспортном средстве
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Цена : {Price}\tМаксимальная скорость : {MaxSpeed}\tГод : {Year}");
        }
    }
}
