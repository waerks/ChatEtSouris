using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEtSouris.Models
{
	// Delegate
	public delegate void CaptureHandler();
	internal class Chat
	{
		public int PositionX { get; set; }
		public int PositionY { get; set; }

		// Event
		public event CaptureHandler Capture;

		// Cette méthode récupère la posistion de la souris via l'event de la souris
		public void SeRapprocher(int sourisX, int sourisY)
		{
			// Si la position du chat est plus grande que celle de la souris, alors sa position doit diminuer sinon, elle augmente
			if (PositionX > sourisX) PositionX--;
			else if (PositionX < sourisX) PositionX++;

			if (PositionY > sourisY) PositionY--;
			else if (PositionY < sourisY) PositionY++;

            Console.WriteLine($"Le 😼 se rapproche en ({PositionX}, {PositionY})");

			// Si la position du chat est identique à celle de la souris, on enclenche la capture
			if (PositionX == sourisX && PositionY == sourisY) Capture?.Invoke();
		}
	}
}
