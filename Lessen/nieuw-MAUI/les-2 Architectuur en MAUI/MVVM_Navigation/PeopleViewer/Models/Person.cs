using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleViewer.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;

        public string PlaceOfBirth { get; set; } = string.Empty;

        public DateOnly DateOfBirth { get; set; }
    }
}
