using System.ComponentModel.DataAnnotations;

namespace ME_api.Models
{
    public class MainCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; } // không có required ở đây cũng được vì đã có Required ờ định nghĩa trên đầu rồi
    }
}
