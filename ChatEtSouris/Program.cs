using ChatEtSouris.Models;

namespace ChatEtSouris
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Souris souris = new Souris();
			souris.PositionX = 0;
			souris.PositionY = 0;
			souris.Deplacer();
		}
	}
}
