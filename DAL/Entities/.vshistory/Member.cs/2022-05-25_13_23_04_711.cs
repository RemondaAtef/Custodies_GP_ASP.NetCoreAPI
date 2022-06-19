using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB3GP.DAL.Entities
{
    public class Member
    {
        //[Key]
        //public int UserId { get; set; }

        [Key]
        public string UserId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name Cannot exceed 40 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mail Required")]
        [EmailAddress(ErrorMessage = "You Must Enter Valid Mail")]
        public string Email { get; set; }
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Min Len 3")]
        public string Number { get; set; }
        public MemberRole Role { get; set; }
        public MemberStatus status { get; set; }
    }

    public enum MemberStatus
    {
        Active=1,
        Inactive=2,
    }
    public enum MemberRole
    {
        Admin=1,
        Normal=2,
    }
}
