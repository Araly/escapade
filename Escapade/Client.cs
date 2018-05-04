using System;
namespace Escapade
{
    public class Client
    {
		string firstname;
		string lastname;
		string adress;
		int id;
		string phone;
		string email;
        
		public Client(int id, string firstname, string lastname, string phone, string adress, string email)
		{
			this.id = id;
			this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
			this.phone = phone;
			this.email = email;
		}
        public Client(string firstname, string lastname, string adress)
		{
			this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
		}
		public Client() : this(-1,"N/C","N/C","N/C","N/C","N/C")
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
			return "id : " + id + ", firstname : " + firstname + ", lastname : " + lastname + ", adress :" + adress + ", num tel : " + phone + ", email : " + email;
		}
	}
}
