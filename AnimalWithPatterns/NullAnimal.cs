using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Неизвестное животное
    /// </summary>
    public class NullAnimal : Animal
    {
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="AnimalId">Идентификатор</param>
        /// <param name="Name">Название животного</param>
        public NullAnimal(string animalId, string name)
        {
            AnimalId = animalId;
            Name = name;
            Type = "Неизвестный тип животного";
            Sound = "Неизветный издаваемый звук";
        }

        /// <summary>
        /// Конструктор с автоподстановкой GIUD
        /// </summary>
        /// <param name="Name">Название животного</param>
        public NullAnimal(string name) : this (Guid.NewGuid().ToString(), name) =>  Name = name;
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>       
        public NullAnimal() : this ($"Неизвестное животное {new Random().Next().ToString()}") { }
    }
}
