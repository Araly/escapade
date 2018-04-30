using System;
namespace Escapade
{
    public class Deal
    {
		int id;
		Stay sejour;
		Car voiture;
		Client client;
		Housing residence;
		int price;
		int week;
		int year;
		int rating;
		string ratingDescription;
		public Deal(Stay sejour, Car voiture, Client client, Housing residence, int price, int week, int year, int rating, string ratingDescription)
        {
			this.sejour = sejour;
			this.voiture = voiture;
			this.client = client;
			this.residence = residence;
			this.price = price;
			this.week = week;
			this.year = year;
			this.rating = rating;
			this.ratingDescription = ratingDescription;
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
        public Car Voiture
        {
            get { return voiture; }
            set { voiture = value; }
        }
		public Stay Sejour
		{
			get { return sejour; }
			set { sejour = value; }
		}
		public Housing Residence
		{
			get { return residence; }
			set { residence = value; }
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
			return "sejour : " + sejour.ToString() + ", residence : " + residence.ToString() + ", client : " + client.ToString() + ", voiture : " + voiture.ToString() + ", prix : " + price + ", note : " + rating + ", commentaires du client : " + ratingDescription;
		}
	}
}
