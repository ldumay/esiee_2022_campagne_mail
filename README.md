# ESIEE_2_Campagne_Mail

## 0 - Recherches Ldumay

- [HELP_RECHERCHES](HELP_RECHERCHES.md)

## 1 - Requis

Afin de pouvoir éditer ou débugger l'application, il est nécessaire d'avoir :

1. **Windows 10**
2. **.Net 6.0**
3. **Visual Studio - Version : Communauté**
    - Téléchargeable [ici](https://visualstudio.microsoft.com/fr/downloads/)
    - Pack à installer : Développement .Net Desktop
      - ![img](_img/Visual_Studio_Installer.png)
4. **.Net CLI**
    - Si besoin, voici un [guide d'installation de DotNet CLI](Install_DotNet_CLI.md)
5. **Nuget**
    - Si besoin, voici un [guide d'installation de Nuget](Install_Nuget.md)
6. **.Net CLI - Packages**
    - **FontAwesome.Sharp**
        - Si besoin, voici un [guide d'installation du package FontAwesome.Sharp](Install_DotNet_CLI_FontAwesome_Sharp.md)

## 2 - Conception de l'application

- [CONCEPT_v1](CONCEPT_v1.md)

## 3 - Chargé les paquets du projet

Tout d'abord, **descendre** dans le dossier du projet avec **PowerShell**.

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

Puis **recharger** tous les paquets nécessaire avec la commande ci-dessous.

```
donet restore
```

## 4 - Ouvrir le projet

Lancer **Visual Studio** et ouvrer le projet via le fichier de solution d'extension **.sln**.

![img](_img/004.png)

Vérifier l'état des paquets avec une clique droit sur le projet pour ouvrir le gestionnaire de paquets de **Nuget**.

![img](_img/005.png)

Il est possible que ce message apparait si les paquets ont mal été chargé, mais **Visual Studio** devrait aussi pouvoir les rechargés (si non, rechargé les paquets via la commande plus haut).

![img](_img/006.png)

Une fois le gestionnaire de paquets de **Nuget**, il est possible de gérer les paquets du projet.

![img](_img/007.png)

## 5 - Lancer le projet

[En cours ...]