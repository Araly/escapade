using System;
namespace Escapade
{
    public class Housing
    {
		int bedroomNumber;
		string theme;
		int id;
		int rating;
		bool available;
        public Housing(int id, int bedroomNumber, string theme, int rating, bool available)
        {
			this.id = id;
			this.bedroomNumber = bedroomNumber;
			this.available = available;
			this.theme = theme;
			this.rating = rating;
        }
		public Housing() : this(-1,-1,"N/C",-1,false)
		{
			
		}
        public int BedroomNumber      
		{
			get { return bedroomNumber; }
			set { bedroomNumber = value; }
		}
        public string Theme
		{
			get { return theme; }
			set { theme = value; }
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
		public bool Available
        {
            get { return available; }
            set { available = value; }
        }
		public override string ToString()
		{
			return "id : " + id +  ", borough : " + theme + ", rating :" + rating + ", number of bedrooms : " + bedroomNumber + ", available : " + available;
		}
	}
}
