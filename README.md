# FullReloaded

<https://user-images.githubusercontent.com/68634636/174169752-d84329d9-1dd7-4b42-884a-8cf40e62dcc5.mp4>

la vidéo est sur YouTube, clique sur le lien suivant:
[Gameplay V1 - FullReloaded](https://youtu.be/d3KHO9GXfts)

**Ce README contient la liste des différentes fonctions possibles ainsi que le Roadmap (fonctions que j'envisage dans le futur)**
*Note: Il se peut que j'emploi le terme "jeu" car cela me semble plus naturel*

1. **Les déplacements de bases:**
   - Avancer
   - Reculer
   - Gauche
   - Droite
   - Courir
   - S'accroupir
   - **~~Les contrôles peuvent se retrouvé inverser pour X raison (bug à corriger)~~**
   - **Compatibilité AZERTY/QWERTY**
   - **~~Saut et course simultanée possible mais limité~~**
   - **~~Les contrôles sont affichés sur l'écran pendant que l'on joue~~ Ils sont affichés dans la section "controls" du menu pause**

2. **Réaparition au point de départ lors d'un accident de chut dans le vide (Respawn)**

3. **Menu d'accueil et menu pause**
   - Le menu d'accueil:
     - Démarrer la jeu
     - Accéder aux paramètres du jeu
     - Quitter le jeu
     - **~~Les paramètres ne propose que le changement du volume du jeu, il est enregistré donc pas besoin de le changer à chaque lancement~~ Maintenant on peut modifier la résolution, les graphismes (bas, moyen, élévée), choisir si l'on veut en plein écran ou pas, la barre de son à été "optimisé"**

   - Le menu pause:
     - Reprendre le jeu
     - (V1) Contrôles
     - (V1) Paramètres
     - Accéder au menu
     - Quitter le jeu
     - **Les paramètres sont maintenant accessibles depuis le menu pause**

4. **Ajout de musique**
   - Une musique pour le fond du jeu et une musique pour le menu d'accueil et celui de pause
   - les musique utilisés sont:

   [Alivvve & Sweeep - Last Night (Glo Remix)](https://www.youtube.com/watch?v=xnjpgqFYAGA&ab_channel=Fluidified) - Fond de jeu

   [Michael FK - Go Back [Official Video]](https://www.youtube.com/watch?v=Y_aYjA83GUY&ab_channel=MichaelFK) - Menu Accueil et menu pause

   - Les musiques ont été légérement modifié via un logiciel de musique, je compter composer les musiques moi-même mais ce n'est pas mon truc.

5. **Ennemies**
   - Les ennemies ont 100 PV (Point de Vie)
   - ~~les coups de l'arme blanche varie entre 1 et 20 point de dégats sur l'ennemies~~ Le nombre de dégâts est affichés au dessus de l'ennemi
   - Une bar de vie indique combien il reste de vie à l'ennemi
   - Dès qu'il atteind 0 PV il disparait
   - ~~Un son est émis lorsqu'on donne un coup et dès qu'il meurt~~
   - (V1) Ils apparaisent via un spawner
   - Ils poursuivent le joueur et tire une fois en face de celui-ci
   - Leurs pistolets ont des valeurs aléatoires comme le fusil du joueur, cependant la distance de tir et les dégâts sont réduis (entre 3 et 5 PV par tir)
   - **~~Pour le moment la seul arme utilisable par le joueur pour tuer l'ennemi est un couteau~~**

6. **(V1) Ajout d'un fusil**
   - Il est automatique
   - chaque tir ont:
     - des dégats entre 5 et 20PV
     - une portée entre 30 et 100
   - Il peut contenir 30 munitions et se recharge automatiquement, une touche "R" est assignée au rechargement si l'on souhaite rechargé en plein milieu de chargeur (il faut utiliser une munition afin de recharger manuellement, le chargeur à 30 balles alors il en faut 29 pour appuyer sur R).
   - l'affichage des munitions actuelles est visible

7. **(V1) Holster d'armes**
   - Il peut contenir autant d'arme que l'on souhaite et il fonctionne avec la molette de la souris
   - Les touches 1,2,3,4 du clavier (celles du haut) peuvent accéder aux différentes armes directement

8. **(V1) Barre de vie**
   - Une barre de vie est intégrée au jeu, elle est verte, puis jaune à partir de 40% et lorsqu'on atteind les 20% elle devient rouge
   - dans le même thème: un effet "touché" est appliqué au joueur lorsqu'il est touché par l'ennemi
   - Des endroits pour regagner de la vie (entre 20 et 30 PV) sont sur la carte, ils apparaisent toute les 20 secondes.

9. **(V1) Gameplay**
   - Ce sont des vagues, le nombre de départ est à 2 et l'on ajoute 2 autres a chaque vague, ils apparaisent a un taux de 1secondes et ce taux diminue de 0.1 entre chaque vague.

10. **(V1) Minimap**
   - Le jeu intègre une minimap statique montrant l'emplacement du joueur (Fleche blanche) sur la carte ainsi que celui des ennemies (Point rouge) et les endroits où l'on peut récuperer de la vie sont marqués d'un point vert.

11. **(V1) Ambiance**
   - Ambiance de nuit avec peu de lumière, tentative d'immersion pure.

12. **(V1) StoryTelling**
   - c'est l'histoire d'un homme qui se fait retrouvé par la police encore une fois et cette fois-ci ils veulent le tuer alors il se protège contre eux et essaye de survivre (Scénario inspiré de la scène dans la forêt dans RAMBO (1982))

13. **(V1) Map**
   - Petit cottage en forêt isolé du monde entouré d'un cabanon délabré et d'un hangar, 2 maison à côté sont abandonnés, une dont la maison est détruite et une autre qui est en étât mais inhabités.

**(corrigé)**
~~**BUG**
Lorsque le joueur décide de retourner au menu puis de refaire une partie il se peut être retrouvé bloqué, il suffit d'appuyer sur échap et le gameplay continue.~~

## Futur fonction

Pour le moment je me suis contenté de ça en guise de démo technique mais je verrais bien des améliorations eventuelles (tout dépendra de ma motivation), voici ma roadmap:

- [x] 1. **Extension du niveau**
Le niveau est unique un carré entouré de mur en brique rouge avec une croix rouge en guise de respawn ainsi qu'une structure pour testé la fonction d'accroupissement. Je pense qu'une extension ne fera pas de mal avec + de structure pour embellir le décor.

- [x] 2. **Accentuation du fond de jeu**
Je me suis contenté de la base, c'est-à-dire le fond bleu et l'éclairage de base mais peut-être qu'un meilleur fond et un meilleur éclairage pourrait amennée du "réalisme" (j'avais un autre mot mais je l'es oublié).

- [x] 3. **Ajout d'armes**
Pour le moment il n'y as qu'un couteau mais je compte ajouté un fusil avec son interface (affichage des munitions, effets spéciaux lorsqu'on tire et qu'on touche), ensuite avec cela un système pour passer d'une arme à une autre et eventuellement une fonction qui permettrerais de donné un coup de couteau lorsqu'on est équippé du fusil.

- [x] 4. **Meilleurs ennemies**
Les ennemies pour le moment sont statiques et ne se déplacent pas, cependant je compte les faire déplacer et se diriger vers le joueur et ainsi nous attaqué, cela amennera une bar de vie pour le joueur en suppléments.

- [x] 5. **Réparations des différends bugs et eventuelle optimisations**
Notamment le bug d'inversion de contrôles et celui du freeze.

- [x]  6. **Ajouts de paramètres et meilleurs Menu**
Pour le moment les menus sont laids et basiques, je vais les embellir et ajoutés plus de paramètres, notamment une fonctions de respawn des ennemies puis des paramètres graghiques.

## Disclaimer

Tout code utilisé pour ma démonstration technique ne sont que des bouts de codes récupérés sur internet et sur des tutoriel Youtube.
