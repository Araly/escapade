using System;
namespace Escapade
{
    public class Housing
    {
		string name;
		string theme;
		int id;
        public Housing(string name, string theme)
        {
			this.name = name;
			this.theme = theme;
        }
		public Housing() : this("N/C","N/C")
		{
			
		}
        public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public string Theme
		{
			get { return theme; }
			set { theme = value; }
		}
		public int Id
        {
            get { return id; }
            set { id = value; }
        }
		public override string ToString()
		{
			return name + ", situé dans le " + theme + "ème arrondissement";
		}
	}
}
