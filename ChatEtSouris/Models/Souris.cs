using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChatEtSouris.Models
{
	internal class Souris
	{
		public int PositionX;
		public int PositionY;
		private Random _random;

		public void Deplacer()
		{
			_random = new Random();

			int deplacementX = _random.Next(-1,2);
			int deplacementY = _random.Next(-1,2);

			PositionX += deplacementX;
			PositionY += deplacementY;

            Console.WriteLine($"La souris se déplace en ({PositionX}, {PositionY})");
		}
	}
}
