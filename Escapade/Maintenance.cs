using System;
namespace Escapade
{
	public class Maintenance
	{
		int id;
		Car car;
		string cause;
		string intervention;
		int week;
		int year;
		bool done;
		public Maintenance(Car car, string cause, string intervention, int week, int year, bool done)
		{
			this.car = car;
			this.cause = cause;
			this.intervention = intervention;
			this.week = week;
			this.year = year;
			this.done = done;
		}
		public Maintenance() : this(null, "N/C", "N/C" ,0, 0, false)
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
		public Car Voiture
		{
			get { return car; }
			set { car = value; }
		}
		public string Cause
		{
			get { return cause; }
			set { cause = value; }
		}
		public string Intervention
		{
			get { return intervention; }
			set { intervention = value; }
		}
        public bool Done
		{
			get { return done; }
			set { done = value; }
		}
		public override string ToString()
		{
			return "cause : " + cause + ", intervention : " + intervention + ", semaine : " + week + ", année : " + year + ", disponible : " + done + ", Voiture : " + car.ToString();
		}
	}
}
