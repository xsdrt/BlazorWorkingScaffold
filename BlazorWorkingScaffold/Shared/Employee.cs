using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWorkingScaffold.Shared
{
    public class Employee       //Employee Model        //Make sure and install via package manager Entity Framework Core 6
                                //using the following command (dotnet tool install --global dotnet-ef).   If you already
                                //have installed you can update to the latest core 6 by the following command
                                //(dotnet tool uninstall --global dotnet-ef) and then reinstall
                                //(dotnet tool install --global dotnet-ef) 
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty; //new in .net6 and C#10
        public string LastName { get; set; } = String.Empty;
        public string Position { get; set; } = string.Empty;
    }
}
