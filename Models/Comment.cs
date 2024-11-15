using Microsoft.AspNetCore.Mvc;

namespace Final8Net.Models
{
    public class Comment 
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Comment(string content, string userName)
        {
            Content = content;
            UserName = userName ?? throw new ArgumentNullException(nameof(userName), "UserName cannot be null");
            CreatedAt = DateTime.Now;
        }
    }
}

