using System.ComponentModel.DataAnnotations;

namespace Polidom.Core.Domains
{
    public class AssignBranchMapping
    {
        [Key]
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string MallId { get; set; }
    }
}
