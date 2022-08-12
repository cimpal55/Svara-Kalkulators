using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara_kalkulators.DbConnections
{
    public interface IResultsRepository
    {
        Results Find(int id);
        List<Results> GetAll();
        Results Add(Results results);
        Results Update(Results results);
        void Remove(int id);
    }
}
