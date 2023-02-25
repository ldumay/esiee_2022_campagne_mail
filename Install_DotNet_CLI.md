[Retour](../../)

# Installation de **.Net CLI**

Pour ce faire, il est nécessaire de téléchargher le fichier d'installation de `dotnet-install`.

Celui-ci est disponible ici :
- Bash (Linux/macOS) : [https://dot.net/v1/dotnet-install.sh](https://dot.net/v1/dotnet-install.sh)
- PowerShell (Windows) : [https://dot.net/v1/dotnet-install.ps1](https://dot.net/v1/dotnet-install.ps1)

> **NB :** Si les liens ci-dessous sont indisponible, il faut aller sur la documentation de Microsoft : [https://learn.microsoft.com/fr-fr/dotnet/core/tools/dotnet-install-script](https://learn.microsoft.com/fr-fr/dotnet/core/tools/dotnet-install-script)

Une fois télécharger, il est maintenant le temps de l'installer. 

Voici une suite de commande que je propose permettant de **préparer**, **télécharger** et **installer** `dotnet-install`.

```
cd /
mkdir dotnet
cd dotnet
Invoke-WebRequest -URI https://dot.net/v1/dotnet-install.ps1 -OutFile dotnet-install.ps1
./dotnet-install.ps1
```

> **NB :** 
> - Il est nécessaire d'utilise le **PowerShell** et non *l'Invite de commande*.
> - Ci-dessus, il s'agit du fichier d'installation Windows et de commandes Linux car j'ai préalablement installé le noyaux Linux sur mon environnement.
>
> **PS :** *Je développe principalement sur MacOS.*

Lors de l'exécution des commandes, voici le message qui est obtenue :

```
Voulez-vous exécuter le logiciel de cet éditeur non approuvé ?
Le fichier C:\Users\dumay\Downloads\dotnet-install.ps1 est publié par CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US et
 n'est pas approuvé sur votre système. N'exécutez que des scripts provenant d'éditeurs approuvés.
[M] Ne jamais exécuter  [N] Ne pas exécuter  [O] Exécuter une fois  [T] Toujours exécuter  [?] Aide (la valeur par défaut est « N ») :
```

Ce message demande simplement l'approbation d'exécution du fichier d'installation.
Saisiser `o` pour valider l'exécution une seule fois.

```
dotnet-install: Note that the intended use of this script is for Continuous Integration (CI) scenarios, where:
dotnet-install: - The SDK needs to be installed without user interaction and without admin rights.
dotnet-install: - The SDK installation doesn't need to persist across multiple CI runs.
dotnet-install: To set up a development environment or to run apps, use installers rather than this script. Visit https://dotnet.microsoft.com/download to get the installer.

dotnet-install: Extracting the archive.
dotnet-install: Adding to current process PATH: "C:\Users\dumay\AppData\Local\Microsoft\dotnet\". Note: This change will not be visible if PowerShell was run as a child process.
dotnet-install: Note that the script does not resolve dependencies during installation.
dotnet-install: To check the list of dependencies, go to https://learn.microsoft.com/dotnet/core/install/windows#dependencies
dotnet-install: Installed version is 6.0.406
dotnet-install: Installation finished
```

Voilà, .Net CLI est installer.

Vous pouvez vérfier la version installer avec la commande : `dotnet --version`.

Pour moi, voici la version que j'ai installé.

```
6.0.406
```