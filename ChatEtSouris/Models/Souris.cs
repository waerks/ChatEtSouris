using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChatEtSouris.Models
{
	// Delegate
	public delegate void DeplacementHandler(int x, int y);
	internal class Souris
	{
		public int PositionX { get; set; }
		public int PositionY { get; set; }

		// Event
		public event DeplacementHandler Deplacement;

		public void Deplacer()
		{
			Random random = new Random();

			// Donner aléatoirement un chiffre pour la position
			int deplacementX = random.Next(-1,2);
			int deplacementY = random.Next(-1,2);

			// Déplacer de +1 à chaque déplacement
			PositionX += deplacementX;
			PositionY += deplacementY;

			//Indique (émet) le fait de s'être déplacé
			Deplacement?.Invoke(PositionX, PositionY);
		}
	}
}
