using System;
namespace Escapade
{
    public class Deal
    {
		int id;
		Stay stay;
		Car car;
		Client client;
		Housing housing;
		int price;
		int week;
		int year;
		int rating;
		string ratingDescription;
		public Deal(Stay stay, Car car, Client client, Housing housing, int price, int week, int year, int rating, string ratingDescription)
        {
			this.stay = stay;
			this.car = car;
			this.client = client;
			this.housing = housing;
			this.price = price;
			this.week = week;
			this.year = year;
			this.rating = rating;
			this.ratingDescription = ratingDescription;
        }
		public Deal() : this(null,null,null,null,0,0,0,0,"N/C")
		{
			
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
		public Stay Sejour
		{
			get { return stay; }
			set { stay = value; }
		}
		public Housing Residence
		{
			get { return housing; }
			set { housing = value; }
		}
		public Client Client
		{
			get { return client; }
			set { client = value; }
		}
        public int Price
		{
			get { return price; }
			set { price = value; }
		}
		public int Rating
		{
			get { return rating; }
			set { rating = value; }
		}
		public string RatingDescription
		{
			get { return ratingDescription; }
			set { ratingDescription = value; }
		}
		public override string ToString()
		{
			return "sejour : " + stay.ToString() + ", residence : " + housing.ToString() + ", client : " + client.ToString() + ", voiture : " + car.ToString() + ", prix : " + price + ", note : " + rating + ", commentaires du client : " + ratingDescription;
		}
	}
}
