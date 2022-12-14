# Projekt-Dokumentation


### Gruppe:
Cupcake
### Mitglieder: 
Benas Sivickas, <br>
Janick Hurschler, <br>
Blentin Tosuni, <br>
Gian-Marco Mileti, <br>
Joël Haldimann <br>

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   1.12.22    | 0.0.1   |       Wir haben angefangen in Paaren zu programmieren.          |
|     8.12.22          |  0.0.2    | Wir hatten einen ersten spielbaren Prototypen und übten dann unsere Präsentation.   |
|   15.12.22               | 1.0.0   |     Wir haben unser Programm vollständig zusammengefügt.          |


## 1 Informieren

### 1.1 Ihr Projekt

Wir als Gruppe programmieren ein Cookie-Clicker-Game mit C#, Visual Studios und WinForms.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss             |   funktional   | als User möchte ich auf einen button clicken, um meinen Score zu erhöhen|
| 2  |      muss           |   Qualität   |     als User möchte ich mit meinem Score Verbesserungen kaufen, um das Spiel cooler und schneller zu machen.                          |
| 3  |       muss          |   funktional   |     Als Computer möchte ich die Clicks von User erkennen, um seinen Score zu erhöhen.                               |
| 4  |       muss          |   Qualität   |     Als Computer möchte ich dem User die Möglichkeit geben, Verbesserungen zu kaufen.                               |
| 5  |       muss          |  Qualität    |     Als Computer möchte ich das Aussehen und die Geschwindigkeit des Games verändern, um dem User den Spielspass zu erhöhen.                               |
| 6 |    kann             |  qualität    |   Als User möchte ich, dass das Design vom Spiel schön ist, um Spass am Spiel zu haben.                                 |
| 7 |  kann          | funktional        |   Als User möchte ich wählen, welche Cookies ich produzieren will, damit mehr Abwechslung im Spiel ist.
| 8 |  kann               |  funktional   |  Als User möchte ich, dass die Zeit des Spiels begrenzt ist, damit das Spiel nicht langweilig wird.                                  |
| 9 | kann              |funktional      |  Als User möchte ich, dass man die Cookies verkaufen kann.                                  |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |      Spiel wird gestartet       |   Click auf Button     |       Score: +1        |
| 2.1  |      Spiel wird gestartet      |   Click auf Verbesserungen      |      Verbesserungen wurden gekauft          |
| 3.1  |      Spiel wird gestartet        | Click auf Button        |       Score wird erhöht          |
| 4.1  |   Spiel wird gestartet       |  Click auf Verbesserungen      |       Verbesserungen wurden gekauft.          |
| 5.1  | Laufendes Spiel      | Click auf Button      |   Aussehen und Geschwindigkeit wird verändert.             |
| 6.1  | Laufendes Spiel      | -      |   Schönes Design            |
| 7.1  | Laufendes Spiel      | Click auf beliebiges Cookie      |   Ausgewähltes Cookie erscheint          |
| 8.1  | Laufendes Spiel      | -      |   Spiel ist beendet            |
| 9.1  | Laufendes Spiel      | Cookie wird auf Kunden verschoben     |   Score: +5           |
### 1.4 Diagramme

![Screenshot_20221215_090158](https://user-images.githubusercontent.com/111045987/207805966-7b523bda-a21b-40a2-999b-036fdcead4f8.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   01.12.2022    |     Joël, Janick      |      Funktionen         |      135 min         |
| 2.A  |   01.12.2022    |     Benas, Gian-Marco      |      Design        |       135 min        |
| 3.A  |   01.12.2022    |      Blentin      |      Funktion        |       135 min        |
| 4.A  |   08.12.2022    |     Benas      |      Funktion        |       135 min        |
| 5.A  |   08.12.2022    |     Blentin      |      Design        |       135 min        |
| 6.A  |   08.12.2022    |      Gian-Marco      |      Design        |       135 min        |
| 7.A  |   08.12.2022    |     Jancik    |    Funktion        |       135 min        |
| 8.A  |   08.12.2022    |     Joël      |      Funktion       |       135 min        |
| 9.A  |   15.12.2022    |     Benas     |      Design        |    90 min           |
Total: 900 min

## 3 Entscheiden

Wir wollen in C# mit Windows Forms ein Spiel programmieren.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 01.12.2022      | Joël, Janick          |135 min               |Ca. 160 min                   |
| 2.A  |01.12.2022     |  Benas, Gian-Marco         |135 min               |Ca. 160  min                   |
| 3.A  |   08.12.2022    |     Blentin     |     135 min       |       Ca. 160 min        |
| 4.A  | 08.12.2022      | Joël, Janick          |135 min               |Ca. 160 min                   |


Wir haben die Zeit verschätzt, deswegen haben wir länger gebraucht als gedacht. Wir mussten und auch gegenseitig helfen, also wir mussten am 01.12.2022 alle zusammen an zwei Arbeitspaketen arbeiten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1 |22.12.2022|OK          |Blentin Tosuni        |
| 2.1 |22.12.2022|OK          |Blentin Tosuni        |
| 3.1 |22.12.2022|OK          |Blentin Tosuni       |
| 4.1 |22.12.2022|OK          |Blentin Tosuni        |
| 5.1 |22.12.2022|OK          |Blentin Tosuni        |
| 6.1 |22.12.2022|OK          |Gian-Marco Mileti      |
| 7.1 |22.12.2022|NOK          |Gian-Marco Mileti        |
| 8.1 |22.12.2022|NOK          |Gian-Marco Mileti        |
| 9.1 |22.12.2022|NOK          |Gian-Marco Mileti        |




## 6 Auswerten

https://github.com/Blentin05/LA_1300.md/blob/main/Lernbericht.md


