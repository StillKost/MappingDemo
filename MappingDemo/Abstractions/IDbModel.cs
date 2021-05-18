using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Abstractions
{
    public abstract class IDbModel : ICrudable
    {
        public int Id { get; set; }        
    }
}
