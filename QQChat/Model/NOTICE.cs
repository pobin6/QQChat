namespace QQChat.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NOTICE")]
    public partial class NOTICE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int noticeId { get; set; }

        public int userId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string noticeText { get; set; }

        public DateTime noticeTime { get; set; }

        public virtual USER USER { get; set; }
    }
}
