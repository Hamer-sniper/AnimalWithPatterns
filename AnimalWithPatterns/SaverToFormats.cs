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

        public SaverToFormats(Repository repository)
        {
            this.Reposit = repository;
        }

        public SaverToFormats(ISaverToFormats Method, Repository repository)
            : this (repository)
        {
            this.Mode = Method;
        }

        public void Save()
        {            
            Mode.SaveAnimals(Reposit);
        }
    }
}
