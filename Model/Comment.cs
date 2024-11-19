using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForYp2.Model
{
    internal class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;

        [ForeignKey ("MasterId")]
        public User? Master { get; set; }

        [ForeignKey ("ClientId")]
        public User? Client { get; set; }
    }
}
