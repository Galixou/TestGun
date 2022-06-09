# Ceci n'est pas un jeu mais une démonstration technique

**Ce README contient la liste des différentes fonctions possibles ainsi que le Roadmap (fonctions que j'envisage dans le futur)**
*Note: Il se peut que j'emploi le terme "jeu" car cela me semble plus naturel*

1. **Les déplacements de bases:**
   - Avancer
   - Reculer
   - Gauche
   - Droite
   - Courir
   - S'accroupir
   - **Les contrôles peuvent se retrouvé inverser pour X raison (bug à corriger)**
   - **Compatibilité AZERTY/QWERTY**
   - **Saut et course simultanée possible mais limité**
   - **Les contrôles sont affichés sur l'écran pendant que l'on joue**

2. **Réaparition au point de départ lors d'un accident de chut dans le vide (Respawn)**

3. **Menu d'accueil et menu pause**
   - Le menu d'accueil
     - Démarrer la jeu
     - Accéder aux paramètres du jeu
     - Quitter le jeu
     - **Les paramètres ne propose que le changement du volume du jeu, il est enregistré donc pas besoin de le changer à chaque lancement**

   - Le menu pause:
     - Reprendre le jeu
     - Accéder au menu
     - Quitter le jeu

4. **Ajout de musique**
   - Une musique pour le fond du jeu et une musique pour le menu d'accueil et celui de pause
   - les musique utilisés sont:

   [Cartoon - On & On (feat. Daniel Levi) [NCS Release]](https://www.youtube.com/watch?v=K4DyBUG242c&ab_channel=NoCopyrightSounds) - Fond de jeu

   [Egzod & Maestro Chives - Royalty (ft. Neoni) [NCS Release]](https://www.youtube.com/watch?v=C5fLxtJH2Qs&ab_channel=NoCopyrightSounds) - Menu Accueil et menu pause

5. **Ennemies**
   - Les ennemies ont 100 PV (Point de Vie)
   - les coups de l'arme blanche varie entre 1 et 20 point de dégats sur l'ennemies
   - Une bar de vie indique combien il reste de vie à l'ennemi.
   - Une fois qu'il atteind 0 PV ou moins il disparait
   - Un son est émis lorsqu'on donne un coup et dès qu'il meurt
   - **Pour le moment la seul arme utilisable par le joueur pour tuer l'ennemi est un couteau**

**(corrigé)**
~~**BUG**
Lorsque le joueur décide de retourner au menu puis de refaire une partie il se peut être retrouvé bloqué, il suffit d'appuyer sur échap et le gameplay continue.~~

## Futur fonction

Pour le moment je me suis contenté de ça en guise de démo technique mais je verrais bien des améliorations eventuelles (tout dépendra de ma motivation), voici ma roadmap:

- [ ] 1. **Extension du niveau**
Le niveau est unique un carré entouré de mur en brique rouge avec une croix rouge en guise de respawn ainsi qu'une structure pour testé la fonction d'accroupissement. Je pense qu'une extension ne fera pas de mal avec + de structure pour embellir le décor.

- [ ] 2. **Accentuation du fond de jeu**
Je me suis contenté de la base, c'est-à-dire le fond bleu et l'éclairage de base mais peut-être qu'un meilleur fond et un meilleur éclairage pourrait amennée du "réalisme" (j'avais un autre mot mais je l'es oublié).

- [ ] 3. **Ajout d'armes**
Pour le moment il n'y as qu'un couteau mais je compte ajouté un fusil avec son interface (affichage des munitions, effets spéciaux lorsqu'on tire et qu'on touche), ensuite avec cela un système pour passer d'une arme à une autre et eventuellement une fonction qui permettrerais de donné un coup de couteau lorsqu'on est équippé du fusil.

- [ ] 4. **Meilleurs ennemies**
Les ennemies pour le moment sont statiques et ne se déplacent pas, cependant je compte les faire déplacer et se diriger vers le joueur et ainsi nous attaqué, cela amennera une bar de vie pour le joueur en suppléments.

- [ ] 5. **Réparations des différends bugs et eventuelle optimisations**
Notamment le bug d'inversion de contrôles et celui du freeze.

- [x]  6. **Ajouts de paramètres et meilleurs Menu**
Pour le moment les menus sont laids et basiques, je vais les embellir et ajoutés plus de paramètres, notamment une fonctions de respawn des ennemies puis des paramètres graghiques.

## Disclaimer

Tout code utilisé pour ma démonstration technique ne sont que des bouts de codes récupérés sur internet et sur des tutoriel Youtube.