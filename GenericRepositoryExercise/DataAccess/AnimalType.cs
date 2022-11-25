using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalType
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
    }
}
