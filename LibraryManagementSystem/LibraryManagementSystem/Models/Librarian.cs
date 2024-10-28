using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Librarian : Person
    {
        private static int _id = 0;
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime HireDate { get; set; }
        public Librarian(string name, DateTime hireDate) : base(name)
        {
            Name = name;
            Id = _id++;
        }
    }
}
