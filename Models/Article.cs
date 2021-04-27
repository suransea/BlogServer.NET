using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogServer.Models
{
    [Table("article")]
    public class Article
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("summary")]
        public string Summary { get; set; }

        [ForeignKey("content_id")]
        public ArticleContent Content { get; set; }
    }
}
