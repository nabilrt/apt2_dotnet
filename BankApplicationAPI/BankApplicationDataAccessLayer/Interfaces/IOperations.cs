using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.Interfaces
{
    public interface IOperations<CLASS, Id, RET>
    {
        List<CLASS> getALL();

        CLASS get(Id id);

        RET Add(CLASS cls);

        RET Update(CLASS cls);

        RET Delete(Id id);


    }
}
