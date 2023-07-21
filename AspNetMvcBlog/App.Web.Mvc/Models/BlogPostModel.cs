namespace App.Web.Mvc.Models
{
	public class BlogPostModel
	{
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        public DateTime InsertedDate { get; set; }
        public string Content { get; set; }
        public bool ShowInSlider { get; set; } //slider'da gösterilsin mi
    }
}
