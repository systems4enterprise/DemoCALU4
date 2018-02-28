using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataModelCodeFirst.ViewModels
{
    public class AuthorViewModel
    {


        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        

        [Required]
        [Display(Name = "Author Name")]
        public string Name { get; set; }


        public static implicit operator AuthorViewModel(Author a)
        {
            return new AuthorViewModel
            {
                Id = a.Id,
                Name = a.Name
                
            };
        }

        public static implicit operator Author(AuthorViewModel avm)
        {
            return new Author
            {
                Id = avm.Id,
                Name = avm.Name
            };
        }
    }

    public class AuthorsDataView
    {
        public IEnumerable<AuthorViewModel> AuthorsData { get; set; }
    }
}
