using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Comment
{
    public class CommentVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string TextMessage { get; set; }

        //public List<Comment> Comments { get; set; }
    }
}
