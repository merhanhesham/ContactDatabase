using System.ComponentModel.DataAnnotations;
using EdgeDB;
namespace EdgeDb.Pages
{
    public enum TitleEnum
    {
        Mr, Mrs, Ms, Dr
    }
    public class ContactClass
    {
        [Required(ErrorMessage = "Firstname is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsMarried { get; set; }
        public string DateofBirth { get; set; }
    }
}