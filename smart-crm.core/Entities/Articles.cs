using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Articles
    {
        public string Title { get; set; }
        public string content { get; set; }

        [ForeignKey("Categories")]
        public int CategoriesId { get; set; }
        public virtual ArticleCategories Categories { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Account Author { get; set; }

        public int status { get; set; }
    }
}