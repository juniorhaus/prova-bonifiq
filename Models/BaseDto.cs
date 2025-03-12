namespace ProvaPub.Models
{
    public class BaseDto<T>
    {
        public List<T> List { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
