<p align="center"> ![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/AxelLofberg/gruppuppgiftCI_CD/grupp7.yml) ![action results](https://github.com/AxelLofberg/gruppuppgiftCI_CD/actions/workflows/grupp7.yml/badge.svg)
</p>

<h1 align="center">Personnummerkontrollapplikation</h1>

<p align="center">
  En enkel C#-konsolapplikation för att verifiera giltigheten av svenska personnummer och hämta kön.
</p>

## Lokal körning och testning

### Steg 1: Installera .NET Core

Besök [dotnet-webbplatsen](https://dotnet.microsoft.com/download) och hämta och installera den senaste versionen av .NET Core passande för ditt operativsystem.

### Steg 2: Klona projektet

```bash
git clone https://github.com/AxelLofberg/gruppuppgiftCI_CD.git
cd gruppuppgiftCI_CD








Personnummer projekt Github/Docker

Vi inledde projektet genom att skapa ett repository på GitHub som alla medlemmar i gruppen klonade. Därefter använde vi terminalen eller bash för att navigera till projektet, vilket genomfördes enligt nedan. 

För personen som ska klona projektet:
gå till projektet
tryck på code och kopiera länken för att klona projektet
gå till någon lämplig mapp via terminal 
skriv git clone och klistra in länken som du kopierade från github
sedan skriver du git pull (för att uppdatera till senaste versionen)

git checkout main → så att vi vet att vi är på mainbranchen (huvudgrenen)

git pull → dra ner alla uppdateringar, nu har projektet uppdaterats enligt github

git checkout -b “branch_namn” → namnge din branch/gren (används om flera jobbar på samma kod/projekt)

När alla hade anslutit sig till projektet skapade varje gruppmedlem en egen gren (branch) för att kunna arbeta separat och parallellt. Eftersom projektet var kopplat till GitHub kunde vi enkelt övervaka testerna som kördes och aktiviteten i projektet.
Vi använde terminalen för att pusha koden som gjordes, sedan mergades detta via github. 


Ett exempel på hur det kan se ut efter ändringar gjorts och ny kod ska pushas upp:

(skriv ny kod:
git add . → git commit -m “new code” → git push origin “ny_branch_namn”

skapa pull request → merge pull request )

Enhetstesterna gjordes via ramverket xUnit. För att underlätta testning skapade vi en projektfil med XUnit-ramverket installerat. Detta gjordes för att kunna köra omfattande tester på vår kod. Själva koden låg i en fil, medan testkoden som kontrollerade inmatad information låg i en separat fil. Dessa tester automatiserades via Github actions, vilket gjorde att vår kod testades vart efter våra ändringar.

En dockerfile gjordes för att göra applikationen still en Docker-container.
Github actions användes för att kunna skapa och köra en docker-container. 
För att skapa vår Docker-image integrerade vi GitHub-projektet med DockerHub. Därefter kopplade vi DockerHub till den lokala Docker-servern på våra datorer.
Detta gjorde vi genom att dels använda terminalen för att integrera projektet med Dockern. 

docker build -t anvandarnamn/personnummerkontroll
docker pull anvandarnamn/personnummerkontroll
docker run -it anvandarnamn/personnummerkontroll



Ramverk för svenskt personnummer
De 2 första siffrorna anger vilket århundrade personen är född och de två följande siffrorna anger födelseår
De två siffror som följer årtalet representerar månaden och de följande representerar kalenderdagen man är född

Dessa representerar alltså personens födelsedag. 

Den tionde siffran är en kontrollsiffra för att kunna skilja på de personer som föddes samma dag. 
Elfte siffran för att verifiera giltigheten av personnumret 
Den tolfte för att identifiera kön på personen, jämn siffra = tjej och ojämn siffra=kille. 


Applikationen
Vår applikation funkar på så sätt att man startar den och anger ett personnummer på 12 siffror. Sedan skriver man dotnet run och därefter körs den och ger ett resultat om det är ett giltigt personnummer eller inte.
