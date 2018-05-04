using System;
namespace Escapade
{
    public class Stay
    {
		string theme;
		int id;
        public Stay(int id, string theme)
        {
			this.id = id;
			this.theme = theme;
        }
		public Stay() : this(-1,"N/C")
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
		public override string ToString()
		{
			return "id : " + id + ", theme : " + theme;
		}
	}
}
