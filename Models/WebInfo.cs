namespace Models
{
    public class WebInfo
    {
        private readonly string _title;
        private readonly string _url;
        private readonly string _description;
        private readonly string _imagePath;

        public string Title { get { return _title; } }
        public string Url { get { return _url; } }
        public string Description { get { return _description; } }
        public string ImagePath { get { return _imagePath; } }

        public WebInfo(string title, string url, string description, string imagePath)
        {
            _title = title;
            _url = url;
            _description = description;
            _imagePath = imagePath;
                
        }

        public WebInfo(string title, string url, string imagePath)
        {
            _title = title;
            _url = url;
            _description = string.Empty;
            _imagePath = imagePath;
        }
    }
}