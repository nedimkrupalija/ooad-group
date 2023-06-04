using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
    public class Administrator 
    {

        public Administrator()
        {

          }
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }   
        public string? FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get; set; }
    }
}
