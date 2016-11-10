namespace QQChat.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MESSAGE")]
    public partial class MESSAGE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int messageId { get; set; }

        public int userId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string messageText { get; set; }

        public DateTime messageTime { get; set; }

        public virtual USER USER { get; set; }
    }
}
