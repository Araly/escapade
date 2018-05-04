using System;
namespace Escapade
{
    public class Housing
    {
		int bedrooms;
		string borough;
		int id;
		double overall_satisfaction;
		bool availability;
		int host_id;
		int room_id;
		int price;
		public Housing(int id, int bedrooms, string borough, double overall_satisfaction, bool availability,int host_id, int room_id, int price)
        {
			this.id = id;
			this.bedrooms = bedrooms;
			this.availability = availability;
			this.borough = borough;
			this.overall_satisfaction = overall_satisfaction;
			this.host_id = host_id;
			this.room_id = room_id;
			this.price = price;
        }
		public Housing() : this(-1, -1, "N/C", -1, false,-1,-1,-1)
		{
			
		}
        public int Bedrooms    
		{
			get { return bedrooms; }
			set { bedrooms = value; }
		}
		public string Borough
		{
			get { return borough; }
			set { borough = value; }
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public double Overall_satisfaction
        {
			get { return overall_satisfaction; }
			set { overall_satisfaction = value; }
        }
		public bool Availabilty
        {
			get { return availability; }
			set { availability = value; }
        }
		public int Host_id
		{
			get { return host_id; }
			set { host_id = value; }
		}
		public int Room_id
		{
			get { return room_id; }
			set { room_id = value; }
		}
		public int Price
        {
            get { return price; }
            set { price = value; }
        }    
		public override string ToString()
		{
			return "id : " + id +  ", borough : " + borough + ", overall_satisfaction :" + overall_satisfaction + ", number of bedrooms : " + bedrooms + ", availability : " + availability + ", host_id = " + host_id + ", room_id = " + room_id + ", price : " + price;
		}
	}
}
