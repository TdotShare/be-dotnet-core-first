using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_dotnet_core_first.Database.Entity
{
    [Table("act_activity")]
    public class Activity
    {
        [Key]
        public int activityId { get; set; }
        public int activityCategoryId { get; set; }
        public string? activityCode { get; set; }
        public string? activityName { get; set; }
        public string? activityNameEng { get; set; }
        public string? activityDetails { get; set; }
        public int activityUnit { get; set; }
        public int activityScore { get; set; }
        public int activityFacultyCode { get; set; }
        public int activityAgencyCode { get; set; }
        public int activityTypeAgency { get; set; }
        public int activitySemester { get; set; }
        public int activityYear { get; set; }
        public int activityStatus { get; set; }
        public int activityIsShow { get; set; }
        public int activityIsDelete { get; set; }
        public int activityIsRegister { get; set; }
        public string? activityCampusId { get; set; }
        public int activityHaveCertificate { get; set; }
        public int activityStatusLimited { get; set; }
        public int activityAmountMax { get; set; }
        public DateTime activityStartDate { get; set; }
        public DateTime activityEndDate { get; set; }
        public int activityRegisterStartDate { get; set; }
        public DateTime activityRegisterEndDate { get; set; }
        public string? activityCreaetByUsername { get; set; }
        public string? activityUpdateByUsername { get; set; }
        public DateTime activityCreateAt { get; set; }
        public DateTime activityUpdateAt { get; set; }

    }
}
