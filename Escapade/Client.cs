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
		int id;
		string phone;
		string email;

		public Client(string firstname, string lastname, string adress, string stay, int year, int week)
		{
			this.firstname = firstname;
			this.lastname = lastname;
			this.adress = adress;
			this.stay = stay;
			this.year = year;
			this.week = week;
		}
		public Client(string firstname, string lastname, string phone, string adress, string email)
		{
			this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
			this.phone = phone;
			this.email = email;
		}
		public Client() : this("N/C","N/C","N/C","N/C",0,0)
		{
			
		}

        public string Firstname
		{
			get { return firstname; }
			set { firstname = value; }
		}
		public string Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public string Adress
		{
			get { return adress; }
			set { adress = value; }
		}
        public string Stay
		{
			get { return stay; }
			set { stay = value; }
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
        public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}
        public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public override string ToString()
		{
			return firstname + " " + lastname + ", " + adress + ", sejour : " + stay + " la semaine " + week + year;
		}
	}
}
