using System;
namespace Escapade
{
    public class Client
    {
		string firstname;
		string lastname;
		string adress;
		string stay;
		int year;
		int week;

		public Client(string firstname, string lastname, string adress, string stay, int year, int week)
        {
			this.firstname = firstname;
			this.lastname = lastname;
			this.adress = adress;
			this.stay = stay;
			this.year = year;
			this.week = week;
        }

        public string Firstname
		{
			get { return firstname; }
		}
		public string Lastname
		{
			get { return lastname; }
		}
		public string Adress
		{
			get { return adress; }
		}
        public string Stay
		{
			get { return stay; }
		}
		public int Year
		{
			get { return year; }
		}
		public int Week
		{
			get { return week; }
		}
    }
}
