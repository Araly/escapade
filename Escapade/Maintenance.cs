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
		public Maintenance(int id, Car car, string cause, string intervention, int week, int year, bool done)
		{
			this.id = id;
			this.car = car;
			this.cause = cause;
			this.intervention = intervention;
			this.week = week;
			this.year = year;
			this.done = done;
		}
		public Maintenance() : this(-1, null, "N/C", "N/C", -1, -1, false)
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
			return "cause : " + cause + ", intervention : " + intervention + ", week : " + week + ", year : " + year + ", done : " + done + ", car : " + car.ToString();
		}
	}
}
