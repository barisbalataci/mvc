namespace Nortwind.MvcWebUI.Models
{
    public class PagingInfo
    {
        public string BaseUrl { get; set; }
        public int? CurrentCategory { get;  set; }
        public int CurrentPage { get; set; }
        public int TotalPageCount { get;  set; }
    }
}