using System;
namespace Escapade
{
    public class Car
    {
		string id;
		string model;
		string brand;
		string type;
		bool available;
		string parking_space;
		Supervisor supervisor;
		Parking parking;
		public Car(string id,string brand, string type, string model, bool available, Supervisor supervisor, string parking_space, Parking parking)
        {
			this.id = id;
			this.model = model;
			this.brand = brand;
			this.type = type;
			this.available = available;
			this.parking_space = parking_space;
			this.supervisor = supervisor;
			this.parking = parking;
        }
		public Car() : this("N/C","N/C","N/C","N/C",false,null,"N/C",null)
		{
			
		}
		public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Model
		{
			get { return model; }
			set { model = value; }
		}
        public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}
        public string Type
		{
			get { return type; }
			set { type = value; }
		}
        public bool Available
		{
			get { return available; }
			set { available = value; }
		}
        public string Parking_space
		{
			get { return parking_space; }
			set { parking_space = value; }
		}
		public Supervisor Supervisor
		{
			get { return supervisor; }
			set { supervisor = value; }
		}
		public Parking Parking
		{
			get { return parking; }
			set { parking = value; }
		}
		public override string ToString()
		{
			return "immatriculation : " + id + ", modele : " + model + ", marque" + brand + ", type " + type + ", disponible : " + available + ", place de parking : " + parking_space + ", superviseur : " + supervisor.ToString() + ", parking : " + parking.ToString();
		}
	}
}
