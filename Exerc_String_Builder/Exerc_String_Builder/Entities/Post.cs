using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_String_Builder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment cm in Comments)
            {
                sb.AppendLine(cm.Text);
            }
            return sb.ToString();
        }
    }
}
