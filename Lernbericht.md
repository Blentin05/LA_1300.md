# LA_1300 Lern-Bericht der Gruppe Cupcake
Janick Hurschler,  
Blentin Tousoni,  
Joël Haldimann,  
Benas Sivikas,  
Gian-Marco Mileti,  

## Einleitung

Wir haben mit Windows Forms, in Visual Studios, ein Cookie-Clicker programmiert. Dieser soll als game für den Benutzer spielbar sein.

## Was habe ich gelernt?

Wir haben gelernt, wie man einen ein Textfeld, also bei uns ein Counter, die ganze Zeit updaten kann, ohne ihn anzuklicken.

## Beschreibung

Als wir endlich die Grobstruktur der Games hatten, mussten wir die Upgrades programmieren. Diese sollten das Spiel interessanter machen und mehr Dynamik rein bringen.
Wir haben uns von anfang an für ein Upgrade entschieden, dass dem Spieler pro Click doppelte Anzahl Cookies gibt. Das war an sich kein Problem. Nur stellte sich beim
Testen heraus, dass der Counter gar nicht geupdated wird. Das heisst, dass der Spieler gar nie sieht, wie viele Cookies er besitzt oder gesammelt hat. Für das musste jetzt eine Lösung her.
Nach viel Ausprobieren und recherchieren im Internet sind wir auf eine scheinbar logisch, simple und einfache Lösung gekommen. Man kann nämlich einen Butten oder ein Textfeld auch
updaten, wenn man einen anderen Button drückt. Das klingt wie gesagt ziemlich einfach, aber wir dachten zuerst, dass dies nur im Code vom eigenen Button funktioniert.
Also Schlussendlich haben wir einfach den Button, der fürs anklicken des Cookies gedacht ist, genommen und haben gesagt: Wenn man diesen Knopf, also Cookie, drückt, dann
Schreibe auch die aktuelle Punktzahl in das Counter-Feld. So konnten wir das Problem lösen und am Programm weiterarbeiten.

![Code:](<img width="584" alt="2022-12-22" src="https://user-images.githubusercontent.com/111045598/209099849-deeb40af-27d6-49aa-ad77-9c3ed4dcc8bc.png">)



## Verifikation

Der Text zeigt, was das Problem war und wie wir zur Lösung gekommen sind.   
Das Bild zeigt, wie das ganze im Code aussieht.   
Und das GIF zeigt, wie es aussieht, wenn der Spieler auf den Cookie clickt.  

# Reflexion zum Arbeitsprozess

Wir hatten sehr schnell unser Ziel vor Augen. Wir wussten grob was und wie wir den Cookie-Clicker prgrammieren müssen. Dies gelang dank einem PAP und einer Besprechung in der Gruppe. 

Wie haben hin und wieder vergessen, die Projektdokumentation zu schreieben und updaten. So war es auch schwieriger zu sehen, wie weit das Programm überhaupt ist und was man für Arbeiten vor sich hat.

**VBV**: Beim nächsten Projekt muss die Gruppe unbedingt eine Person auswählen, die die Projektdoku immer überarbeitet und alles einschreibt. Die anderen Gruppenmitglieder müssen natürlich mit diesser Person
auch kommunizieren. So sollten alle einen Überblick behalten und es gibt am Ende des Projektes keinen Stress.
