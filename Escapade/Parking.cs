using System;
namespace Escapade
{
	public class Parking
	{
		int id;
		string theme;
		public Parking(string theme)
		{
			this.theme = theme;
		}
		public Parking() : this("N/C")
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
		public override string ToString()
		{
			return theme;
		}
	}
}
