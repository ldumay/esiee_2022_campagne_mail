[Retour](../../)

# Installation du package **FontAwesome.Sharp**

Il faut aller à la sous-racine du dossier du projet qui est ici `ESIEE_2_Campagne_Mail_v2`.

```
Structure du dossier
Le numéro de série du volume est 36A6-D39A
C:
└───ESIEE_2_Campagne_Mail_v2/
    ├───.vs
    ├───ESIEE_2_Campagne_Mail_v2/ <== IL_FAUT_ALLER_A_CE_NIVEAU
    │    ├───bin/
    │    ├───obj/
    │    ├───Properties/
    │    ├───views/
    │    ├───ESIEE_2_Campagne_Mail_v2.csproj
    │    ├───ESIEE_2_Campagne_Mail_v2.csproj.user
    │    └───Program.cs
    └───ESIEE_2_Campagne_Mail_v2.slnn
```

Maintenant, on ajout le package dotnet `FontAwesome.Sharp`.

```
dotnet add package FontAwesome.Sharp --version 6.2.1
```

Ci-dessous, le résultat obtenu de la commande.

```
  Identification des projets à restaurer...
  Writing C:\Users\dumay\AppData\Local\Temp\tmp1DEB.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET.
info : Ajout de PackageReference pour le package 'FontAwesome.Sharp' dans le projet 'C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2.csproj'.
info : Restauration des packages pour C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2.csproj...
info :   GET https://api.nuget.org/v3-flatcontainer/fontawesome.sharp/index.json
info :   OK https://api.nuget.org/v3-flatcontainer/fontawesome.sharp/index.json 123 ms
info :   GET https://api.nuget.org/v3-flatcontainer/fontawesome.sharp/6.2.1/fontawesome.sharp.6.2.1.nupkg
info :   OK https://api.nuget.org/v3-flatcontainer/fontawesome.sharp/6.2.1/fontawesome.sharp.6.2.1.nupkg 28 ms
info : FontAwesome.Sharp 6.2.1 installé à partir de https://api.nuget.org/v3/index.json avec le code de hachage de contenu eYpj85+70pOjV4cOfB/Et/Rj6m56WRlCKU2G4ivWCohb7sF7DwHz/3jy8XIWp9utgb/R2Pqm+HsaBwV33FBNbg==.
info : Le package 'FontAwesome.Sharp' est compatible avec tous les frameworks spécifiés dans le projet 'C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2.csproj'.
info : PackageReference pour le package 'FontAwesome.Sharp' version '6.2.1' ajouté au fichier 'C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2.csproj'.
info : Écriture du fichier des composants sur le disque. Chemin : C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\obj\project.assets.json
log  : Restauration effectuée de C:\Projets\ESIEE_2_Campagne_Mail\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2\ESIEE_2_Campagne_Mail_v2.csproj (en 955 ms).
```

Voilà, le package `FontAwesome.Sharp` est maintenant ajouté.