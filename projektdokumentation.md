# Projekt-Dokumentation


### Gruppe:
Cupcake
### Mitglieder: 
Benas Sivickas, <br>
Janick Hurschler, <br>
Blentin Tusoni, <br>
Gian-Marco Mileti, <br>
Joël Haldimann. <br>

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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
| 5  |       muss          |  Qualität    |     Als Computer möchte ich das Aussehen und die Geschwindigkeit des Games veröndern, um dem User den Spielspass zu erhöhen.                               |
| 6 |    kann             |  qualität    |   Als User möchte ich, dass das Design vom Spiel schön ist, um Spass am Spiel zu haben.                                 |
| 7 |  kann          | funktional        |   Als User möchte ich wählen, welche Cookies ich produzieren will, damit mehr Abwechslung im Spiel ist.
| 8 |  kann               |  funktional   |  Als User möchte ich, dass die Zeit des Spiels begrenzt ist, damit das Spiel nicht langweilig wird.                                  |
| 9 | kann              |kann      |  Als User möchte ich, dass man die Cookies verkaufen kann.                                  |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |      Spiel wird gestartet       |   Click auf Button     |       Score: +1        |
| 2.1  |      Spiel wird gestartet      |   Click auf Verbesserungen      |      Verbesserungen wurden gekauft          |
| 3.1  |      Spiel wird gestartet        | Click auf Button        |       Score wird erhöht          |
| 4.1  |   Spiel wird gestartet       |  Click auf Verbesserungen      |       Verbesserungen wurden gekauft.          |
| 5.1  | Laufendes Spiel      | Click auf Button      |   Aussehen und Geschwindigkeit wird verändern.             |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   01.12.2022    |     Joel, Janick      |      Funktionen         |      120 min         |
| 2.A  |   01.12.2022    |     Benas, Gian-Marco      |      Design        |       120 min        |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
