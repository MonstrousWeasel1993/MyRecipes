namespace RecipeOrganiser.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public string Description { get; set; }
        public int? PhotoID { get; set; }
        public int? ServingSize { get; set; }
        public int? PrepHours { get; set; }
        public int? PrepMinutes { get; set; }
        public int? CookHours { get; set; }
        public int? CookMinutes { get; set; }
        public int? CookTemperature { get; set; }
        public string? SourceName { get; set; }
        public string? SourceURL { get; set; }
        public bool Active { get; set; }
    }
}
