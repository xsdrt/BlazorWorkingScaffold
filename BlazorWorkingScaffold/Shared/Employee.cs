using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWorkingScaffold.Shared
{
    public class Employee       //Employee Model
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty; //new in .net6 and C#10
        public string LastName { get; set; } = String.Empty;
        public string Position { get; set; } = string.Empty;
    }
}
