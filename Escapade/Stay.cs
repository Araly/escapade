using System;
namespace Escapade
{
    public class Stay
    {
		string theme;
		int id;
		string borough;
        public Stay(int id, string theme, string borough)
        {
			this.id = id;
			this.theme = theme;
			this.borough = borough;
        }
		public Stay() : this(-1,"N/C","N/C")
		{
			
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
        public string Borough
		{
			get { return borough; }
			set { borough = value; }
		}
		public override string ToString()
		{
			return "id : " + id + ", theme : " + theme + ", borough : " + borough;
		}
	}
}
