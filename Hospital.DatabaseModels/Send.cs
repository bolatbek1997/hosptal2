using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DatabaseModels
{
    public class Send
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime Date { get => DateTime.Today; }
    }
}
