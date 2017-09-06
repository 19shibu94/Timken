using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimkenTest.Models;

namespace TimkenTest.Interface
{
    public interface ITimkenRepo
    {
        int AddData(TimkenModel collection);
        IEnumerable<TimkenModel> ListData();
    }
}
