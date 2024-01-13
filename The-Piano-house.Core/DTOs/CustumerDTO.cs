using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Piano_house.Core.DTOs
{
    public class CustumerDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
