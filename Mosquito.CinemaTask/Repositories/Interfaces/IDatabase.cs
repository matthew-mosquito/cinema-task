using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosquito.CinemaTask.Repositories.Interfaces
{
    interface IDatabase
    {
        SqlConnection connection();
    }
}
