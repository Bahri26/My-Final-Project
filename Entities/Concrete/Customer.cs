using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }
}
