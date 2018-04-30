using System;
namespace Escapade
{
    public class Stay
    {
		string theme;
        public Stay(string theme)
        {
			this.theme = theme;
        }
        public string Theme
		{
			get { return theme; }
			set { theme = value; }
		}
		public override string ToString()
		{
			return "Sejour : " + theme;
		}
	}
}
