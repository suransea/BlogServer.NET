using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogServer.Models
{
    [Table("content")]
    public class ArticleContent
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("content")]
        public string Content { get; set; }
    }
}
