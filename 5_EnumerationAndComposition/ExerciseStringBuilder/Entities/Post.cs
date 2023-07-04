using System.Text;

namespace ExerciseStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments{ get; set; } = new List<Comment>();


        public Post()
        {         
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) //Add a comment to the Comment list.
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) //Remove a comment to the Comment list.
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
           StringBuilder stringBuilder = new StringBuilder();

           stringBuilder.AppendLine(Title);
           stringBuilder.Append(Likes);
           stringBuilder.Append(" Likes - ");
           stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
           stringBuilder.AppendLine(Content);
           stringBuilder.AppendLine("Comments:");
           foreach (Comment comment in Comments)
           {
           stringBuilder.AppendLine(comment.Text);
           }

            return stringBuilder.ToString();
        }

    }
}