using System;
namespace Escapade
{
    public class Supervisor
    {
		int id;
		string firstname;
		string lastname;
        public Supervisor(int id, string firstname, string lastname)
        {
			this.id = id;
			this.firstname = firstname;
			this.lastname = lastname;
        }
		public Supervisor() : this(-1,"N/C","N/C")
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
		public override string ToString()
		{
			return firstname + " " + lastname;
		}
	}
}
