namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Norman Solutions";
        public string Description { get; set; } = "Head of Information Services, Web Technologist &amp; Musician, based on the Wiltshire, Dorset & Somerset border in the UK.  Offering honest independent advice on all things web, security and general IT; with a splash of added music for the soul.";
        public string Owner { get; set; } = "Clive Norman";		   
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
