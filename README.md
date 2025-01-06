# Énoncé : Le Jeu du Chat et de la Souris

## Imaginez un jeu simple où un chat essaie d'attraper une souris.

**La Souris** : La souris se déplace aléatoirement dans une grille (vous n'avez pas besoin d'implémenter la grille visuellement, juste simuler le déplacement). Chaque fois que la souris se déplace, elle émet un événement "Deplacement".

**Le Chat** : Le chat écoute l'événement "Deplacement" de la souris. Chaque fois que la souris se déplace, le chat tente de se rapprocher de sa position (vous pouvez simplifier en disant que le chat se déplace d'une case dans la direction de la souris).

**La Capture** : Si la position du chat et de la souris deviennent identiques, le chat "attrape" la souris. Un événement "Capture" est alors émis.


## Spécifications

### Créer une classe Souris avec :
- Des propriétés `PositionX` et `PositionY` (entiers).
- Une méthode `Deplacer()`, qui ne retourne rien : elle change aléatoirement `PositionX` et `PositionY` (par exemple, de -1, 0 ou +1).
- Un événement `Deplacement` qui transmet les nouvelles coordonnées de la souris.

### Créer une classe Chat avec :
- Des propriétés `PositionX` et `PositionY` (entiers).
- Une méthode `SeRapprocher(int sourisX, int sourisY)`, qui ne retourne rien : elle met à jour les coordonnées du chat pour se rapprocher de la souris.
- Un événement `Capture` qui est émis lorsque le chat et la souris on la même position en X et en Y.

### Dans la class Program :
- Ajouter une propriété `static FinDeJeu (booléen)`, initialisé à `false`.

### Dans la méthode Main :
- Créer une instance de `Souris` et de `Chat`.
- Abonner le chat à l'événement `Deplacement` de la souris.
- Dans le gestionnaire d'événement `Deplacement`, appeler la méthode `SeRapprocher` du chat.
- Abonner la méthode `Main` à l'événement `Capture` du chat pour afficher un message de capture et changer la valeur de `FinDeJeu` à `true`.
- Dans une boucle (TantQue FinDeJeu est à false, le chat chasse la souris), appeler la méthode `Deplacer()` de la souris.

### Exemple de sortie console :
````
La souris se déplace en (3, 5)
Le chat se rapproche en (2, 4)
La souris se déplace en (3, 4)
Le chat se rapproche en (3, 4)
Le chat a attrapé la souris !
````
