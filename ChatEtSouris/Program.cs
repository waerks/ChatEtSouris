using ChatEtSouris.Models;

namespace ChatEtSouris
{
	internal class Program
	{
		// On initialise la fin du jeu à faux pour ne pas qu'elle s'enclenche
		public static bool FinDeJeu {  get; private set; } = false;
		static void Main(string[] args)
		{
			// Création de la Souris
			Souris souris = new Souris();
			souris.PositionX = 5;
			souris.PositionY = 5;
			
			// Création du Chat
			Chat chat = new Chat();
			chat.PositionX = 0;
			chat.PositionY = 0;

			// On crée une réaction à l'event pour notifier la position de la souris
			souris.Deplacement += delegate (int x, int y)
			{
				Console.OutputEncoding = System.Text.Encoding.UTF8;
				Console.WriteLine($"La 🐭 se déplace en ({x}, {y})");
			};
			// Quand la souris se déplace, la chat doit aussi se déplacer
			// La chat s'abonne à l'event de la souris
			souris.Deplacement += chat.SeRapprocher;


			// Récupère CaptureAction et déclence le cw et la fin du jeu
			chat.Capture += CaptureAction;

            // Tant que la fin du jeu est false, la chat chasse la souris
            do
            {
				souris.Deplacer();
            }
            while (!FinDeJeu);
        }

		static void CaptureAction()
		{
            Console.WriteLine("Le 😼 a capturé la 🐭 !");
			FinDeJeu = true;
		}
	}
}
