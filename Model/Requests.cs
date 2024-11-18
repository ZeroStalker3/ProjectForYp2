using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForYp2.Model
{
    internal class Requests
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public DateOnly StartDate { get; set; }
        public OrgTechType Id_OrgTechType { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string OrgTechManufacture { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string OrgTechModel { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string OrgTechNumber { get; set; } = null!;

        public Statys Id_Statys { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateOnly CompletionDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string RepairParts { get; set; } = null!;
        public int? MasterId { get; set; }
        public int? ClientId { get; set; }
        public virtual User? Client { get; set; }
        public virtual User? Master { get; set; }

    }
}
