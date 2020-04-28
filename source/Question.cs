using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1
{
    public class Question
    {

        #region Zmienne
        private string text;

		public string Text
		{
			get { return text; }
			set { text = value; }
		}

		private string poprawnaOdpowiedz;

		public string PoprawnaOdpowiedz
		{
			get { return poprawnaOdpowiedz; }
			set { poprawnaOdpowiedz = value; }
		}

		private string blednaOdpowiedz1;

		public string BlednaOdpowiedz1
		{
			get { return blednaOdpowiedz1; }
			set { blednaOdpowiedz1 = value; }
		}
		private string blednaOdpowiedz2;

		public string BlednaOdpowiedz2
		{
			get { return blednaOdpowiedz2; }
			set { blednaOdpowiedz2 = value; }
		}
		private string blednaOdpowiedz3;

		public string BlednaOdpowiedz3
		{
			get { return blednaOdpowiedz3; }
			set { blednaOdpowiedz3 = value; }
		}
		/*
		private Image grafika;

		public Image Grafika
		{
			get { return grafika; }
			set { grafika = value; }
		}
		*/
		#endregion
	}
}
