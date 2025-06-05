using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Dtos.Book
{
    public record BookParams
    
        (int sortOrder=1, string? sortField = null, string? Search = null,  int? authorId=null,int? categoryId=null);
    
}
