using System;
namespace Escapade
{
	public class Parking
	{
		int id;
		string theme;
		string name;
		string adress;
		public Parking(int id, string theme, string name, string adress )
		{
			this.id = id;
			this.theme = theme;
			this.name = name;
			this.adress = adress;
		}
		public Parking() : this(-1, "N/C","N/C","N/C")
		{
			
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public string Adress
		{
			get { return adress; }
			set { adress = value; }
		}
		public override string ToString()
		{
			return "id : " + id +", name : " + name + ", adress : " + adress + ", borough : " + theme;
		}
	}
}
