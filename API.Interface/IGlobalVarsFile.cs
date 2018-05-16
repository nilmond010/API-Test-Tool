using API.Model;
using System.Collections.Generic;

namespace API.Interface
{
    public interface IGlobalVars
    {
        IList<GlobalVariable> LoadGlobalVariables();
        void StoreGlobalVariable(IList<GlobalVariable> variables);
    }
}