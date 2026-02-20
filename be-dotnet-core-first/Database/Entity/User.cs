using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_dotnet_core_first.Database.Entity
{

    [Table("act_user")]
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string? userUsername { get; set; }
        public string? userCitizenId { get; set; }
        public string? userEmail { get; set; }
        public string? userStuCode { get; set; }
        public string? userFirstName { get; set; }
        public string? userLastName { get; set; }
        // เพิ่ม property อื่นๆ ตามความต้องการจากไฟล์ SQL
        public DateTime? userCreateAt { get; set; }

    }
}
