using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Magazine : LibraryItem
    {
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime?.Year PublicationYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private static int _id = 0;

        public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
