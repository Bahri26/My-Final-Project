using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto:IEntity
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int BranId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CompanyName { get; set; }
        public string CarBrand { get; set; }
        public int CarModel { get; set; }
        public string CarDescription { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
