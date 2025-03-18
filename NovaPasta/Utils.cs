namespace ProvaPub.NovaPasta
{
    public static class Utils
    {
        public static (List<T>, bool) GenericPagination<T>(int pageIndex, List<T> list)
        {
            const int pageSize = 10;

            var count = list.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            var hasNext = pageIndex < totalPages;

            var paginationList = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return (paginationList, hasNext);
        }
    }
}
