    class SiteModule
    {
        public string htmlCode { get; set; }
        public list<Image> Graphics;
        
        public class API
        {
            public string GetSite { }
            public void ModifySite(String site) { }
            public void AddImage(Image Im) { }
        }
    }
