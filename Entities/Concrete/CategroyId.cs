using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class CategroyId:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
