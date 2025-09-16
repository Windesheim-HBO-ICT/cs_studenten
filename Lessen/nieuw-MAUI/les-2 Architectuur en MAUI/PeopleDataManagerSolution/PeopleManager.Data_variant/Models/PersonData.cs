using SQLite;

namespace PeopleManager.Core.Data.Models
{
    [Table("people")]
    public class PersonData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200)]
        public string FirstName { get; set; }

        [MaxLength(200)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string DateOfBirth { get; set; }
    }
}
