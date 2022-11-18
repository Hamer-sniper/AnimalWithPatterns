using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Абстрактное животное
    /// </summary>
    public abstract class Animal : IAnimal
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string AnimalId { get; set; }
        /// <summary>
        /// Название животного
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип животного
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Издаваемый звук
        /// </summary>
        public string Sound { get; set; }

        public override string ToString()
        {
            return $"{AnimalId}; {Name}; {Type}; {Sound};";
        }
    }
}
