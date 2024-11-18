namespace ProjectForYp2.Model
{
    internal class Requests
    {
        public int RequestID { get; set; }
        public DateOnly StartDate { get; set; }
        public int OrgTechType { get; set; }
        public string OrgTechManufacture { get; set; } = null!;
        public string OrgTechModel { get; set; } = null!;
        public string OrgTechNumber { get; set; } = null!;
        public string Id_requestStatus { get; set; } = null!;
        public DateOnly CompletionDate { get; set; }
        public string RepairParts { get; set; } = null!;
        public int masterID { get; set; }
        public int clientID { get; set; }
    }
}
