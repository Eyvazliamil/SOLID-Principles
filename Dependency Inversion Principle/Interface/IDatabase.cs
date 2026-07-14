using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Interface
{
    public interface IDatabase
    {
        void Save(string data);
    }
}
