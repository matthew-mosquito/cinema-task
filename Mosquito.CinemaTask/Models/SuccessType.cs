using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mosquito.CinemaTask.Models
{
    public enum SuccessType
    {
        None = 0,
        Failed = 1,
        Create = 2,
        Edit = 3,
        Delete = 4,
        UpdateModelSameAsPrevious = 5
    }
}