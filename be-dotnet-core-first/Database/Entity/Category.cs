using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_dotnet_core_first.Database.Entity
{
    [Table("act_category")]
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string? categoryNameTh {  get; set; }
        public string? categoryNameEng {  get; set; }
        public string? categoryShotName {  get; set; }
        public int categoryFree {  get; set; }
        public int categoryStatus {  get; set; }
        public int categoryIsRequest {  get; set; }
        public DateTime categoryCreateAt {  get; set; }
        public DateTime categoryUpdateAt {  get; set; }

    }
}
