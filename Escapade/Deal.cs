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
		string state;
		public Deal(int id, Stay stay, Car car, Client client, Housing housing, int price, int week, int year, int rating, string ratingDescription,string state)
        {
			this.id = id;
			this.stay = stay;
			this.car = car;
			this.client = client;
			this.housing = housing;
			this.price = price;
			this.week = week;
			this.year = year;
        }
		public Deal() : this(-1,null,null,null,null,-1,-1,-1,-1,"N/C","N/C")
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
		public Stay Stay
		{
			get { return stay; }
			set { stay = value; }
		}
		public Housing Housing
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
        public string State
		{
			get { return state; }
			set { state = value; }
		}
		public override string ToString()
		{
			return "id_deal : " + id + ", stay : " + stay.ToString() + ", housing : " + housing.ToString() + ", client : " + client.ToString() + ", car : " + car.ToString() + ", price : " + price;
		}
	}
}
