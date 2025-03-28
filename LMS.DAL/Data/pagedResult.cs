using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Data
{
    public class pagedResult<T> where T : class
    {
        public List<T> Result { get; set; }=new List<T>();
        public int TotalCount { get; set; }  
    }
}
