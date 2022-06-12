namespace BaltaPoo.ContentContext 
{
    /// <summary>
    /// Apenas para cria��o de artigo, ficar� vazia.
    /// </summary>
    public class Article : Content 
    {
        /// <summary>
        /// Construtor usando heran�a.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        public Article(string title, string url) : base(title, url)
        {
        }
    }
}