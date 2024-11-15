namespace Final8Net.Models
{
    public class CommentViewModel
    {
        public List<Comment> Comments { get; set; }

        public CommentViewModel()
        {
            Comments = new List<Comment>();
        }
    }
}
