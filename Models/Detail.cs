using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace React_Axios_Dotnet.Models
{
    public partial class Detail
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
