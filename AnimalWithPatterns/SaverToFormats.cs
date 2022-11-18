using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    public class SaverToFormats
    {
        public ISaverToFormats Mode { get; set; }

        public Repository Reposit { get; set; }

        public SaverToFormats(ISaverToFormats Method, Repository repository)
        {
            this.Mode = Method;
            this.Reposit = repository;
        }

        public void Save()
        {            
            Mode.SaveAnimals(Reposit);
        }
    }
}
