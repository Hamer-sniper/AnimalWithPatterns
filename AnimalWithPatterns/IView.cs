using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    public interface IView
    {
        string AnimalType { get; set; }        

        string AnimalName { get; set; }

        Animal ConcreteAnimal { get; set; }

        Repository LocalRepository { get; set; }
    }
}
