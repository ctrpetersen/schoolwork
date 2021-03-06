﻿namespace RESTConsumer
{
    public class RESTData
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        public RESTData(int UserId, int Id, string Title)
        {
            userId = UserId;
            id = Id;
            title = Title;
        }

        public override string ToString()
        {
            return $"{nameof(userId)}: {userId}, {nameof(id)}: {id}, {nameof(title)}: {title}, {nameof(completed)}: {completed}";
        }
    }
}