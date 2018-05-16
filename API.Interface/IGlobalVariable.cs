using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interface
{
    public interface IGlobalVariable
    {
        void Create(GlobalVariable variable);
        GlobalVariable Read(string key);
        GlobalVariable Update(GlobalVariable variable);
        void Delete(string key);
    }
}
