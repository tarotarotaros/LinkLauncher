using System;

namespace Models
{
    public class WebInfo
    {
        public static WebInfo Empty = new WebInfo();

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

        private WebInfo()
        {
            _title = string.Empty;
            _url = string.Empty;
            _description = string.Empty;
            _imagePath = string.Empty;
        }

        public override bool Equals(object? obj)
        {
            return obj is WebInfo info &&
                   _title == info._title &&
                   _url == info._url &&
                   _description == info._description &&
                   _imagePath == info._imagePath &&
                   Title == info.Title &&
                   Url == info.Url &&
                   Description == info.Description &&
                   ImagePath == info.ImagePath;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_title, _url, _description, _imagePath, Title, Url, Description, ImagePath);
        }
    }
}