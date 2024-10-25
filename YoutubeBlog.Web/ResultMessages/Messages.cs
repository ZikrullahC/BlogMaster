namespace YoutubeBlog.Web.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} article added successfully";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} article updated successfully";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} article deleted successfully";
            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} category added successfully";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} category updated successfully";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} category deleted successfully";
            }
        }
    }
}
