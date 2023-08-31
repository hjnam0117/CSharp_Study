using System.ComponentModel.DataAnnotations;

namespace WebAppReport2.Models
{
    public class Diary
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; }
		public string Writer { get; set; }
	}
}
