using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    public interface IAnimal
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        string AnimalId { get; set; }

        /// <summary>
        /// Название животного
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Тип животного
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Издаваемый звук
        /// </summary>
        string Sound { get; set; }
    }
}
