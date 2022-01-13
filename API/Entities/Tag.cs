using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Tags")]
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}