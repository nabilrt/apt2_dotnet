using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccessLayer.Operations
{
    public interface IOperations<CLASS,ID,RET>
    {
        List<CLASS> getAll();

        CLASS get(ID id);

        RET add(CLASS cls);

        RET delete(ID id);

        RET Update(CLASS cls);


    }
}
