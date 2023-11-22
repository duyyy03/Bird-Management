using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpDatedTime { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User UsernameNavigation { get; set; } = null!;
    }
}
