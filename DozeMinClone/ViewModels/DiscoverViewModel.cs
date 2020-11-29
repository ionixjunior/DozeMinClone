namespace DozeMinClone.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        public string _search;
        public string Search
        {
            get => _search;
            set => SetProperty(ref _search, value);
        }

        private string _cover;
        public string Cover
        {
            get => _cover;
            set => SetProperty(ref _cover, value);
        }

        private string _author;
        public string Author
        {
            get => _author;
            set => SetProperty(ref _author, value);
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
    }
}
