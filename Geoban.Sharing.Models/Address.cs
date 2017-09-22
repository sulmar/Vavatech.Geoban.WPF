namespace Geoban.Sharing.Models
{
    public class Address : Base
    {
        #region City

        private string _City;
        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
                OnPropertyChanged(()=>City);
            }
        }

        #endregion

        public string Street { get; set; }

    }
}
