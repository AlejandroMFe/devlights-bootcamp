using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDataAccess.DTOs
{
    public class StudentDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Token { get; set; }
        public List<ActivityDTO> ActivityDTOs { get; set; }
    }
}
