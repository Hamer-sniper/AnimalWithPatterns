using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    static class RepositoryFactory
    {
        public static Repository GetSQLRepository()
        {
            return new Repository();
        }
    }
}
