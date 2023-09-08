# Projekt-Dokumentation

Wir möchten eine C# Konsolenapplikation Number guesser spiel programmieren womit man über eine LAN verbindung multiplayer spielen kann.

Keanu Koelewijn, Stefan Jesenko (Stefaanu)

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|18.08.2023| 0.0.1 |Anfang des Projekts, 1-2 wurden aktualisiert.|
|25.08.2023| 0.0.2 |Realisiserung hat angefangen, abgeschlossene Arbeiten wurden Dokumentiert.|
|01.09.2023| 0.3.4 |Wir haben grundsätzlich unser Programm im Einzelspieler Fertig. Nur der Mehrspieler funktioniert noch nicht|
|08.09.2023| 0.4.0 |Wir haben uns jetzt dazu entschieden das wir den Multiplayer nicht machen, weil es nicht in den zeitlichen Ramen passt.|

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein Random Number guesser Spiel, das man im Multiplayer über Lan spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss|Funktional|Als User möchte ich, dass das Programm eine Zufällige Zahl von 1-100 generiert, damit ich das Spiel spielen kann.|
| 2    |Muss|Funktional|Als User möchte ich eine Zahl eingeben können, damit ich die Generierte Zahl erraten kann.|
| 3    |Muss|Funktional|Als User möchte ich, dass das Programm mir nach jedem versuch sagt ob mein versuch zu hoch oder zu tief war.|
| 4    |Muss|Funktional|Als User möchte ich, dass das Programm mir sagt wenn ich die richtige Zahl erraten habe.|
| 5    |Muss|Funktional|Als User möchte ich das mir gesagt wird wie viele versuche ich gebraucht habe, damit ich weiss wie gut ich war.|
| 6    |Muss|Funktional|Als User möchte ich, dass das Programm fehlerhafte eingaben bemerkt und darauf reagiert, damit das Programm nicht immer abstürzt wenn es eine Fehlerhafteeingabe gibt.|
| 7    |Muss|Funktional| Als ein User möchte ich, mit freunden über eine Lokale Verbindung gegeneinander spielen kann, damit, wir gegeinander spielen können.|
| 8    |Muss|Funktional| Als ein User möchte ich, die möglichkeit haben meinen Highscore zu sehen, der Highscore soll in einem Dokument gespeichert werden und wieder aufgerufen werden können.|
| 9    | Muss|Funktional| Ich kann einen Spielernamen eingeben der in der Highscore Liste gespeichert wird.|


| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Programm wurde gestartet.| - |Programm generiert eine zufällige Zahl zwischen 1-100|
| 2.1  |zufällige Zahl wurde generiert.| - |Versuche Sie die zufällige Zahl zu erraten:|
| 2.2  |zufällige Zahl wurde generiert.|31| - |
| 3.1  |User hat eine Zahl eingegeben.| - | Die Zufällige Zahl ist höher.|
| 3.2  |User hat eine Zahl eingegeben.| - | Die Zufällige Zahl ist kleiner.|
| 4.1  |User hat eine Zahl eingegeben.| - | Gratulation Sie haben die Zahl erraten.|
| 5.1  |User hat die Zahl richtig gerraten.| - | Sie haben 11 versuche gebraucht.|
| 6.1  |Programm läuft|sajdfhlakdf| Falsche Eingabe!|
| 7.1  |Programm läuft|User wählt Multiplayer modus.|Programm stellt Lan verbindung her.|
| 7.2  |Lan verbindung ist hergestellt.|gibt IP des anderen Users ein.|Programm verbindet die User.|
| 7.3  |Verbindung zwischen den Usern ist hergestellt.| - |Spiel kann jetzt abwechselnd gespeit werden.|
| 8.1  |User hat Zahl richtig erraten.| - |Highscore wird angezeigt.|
| 8.2  |User hat Zahl richtig erraten.| - |Highscore wird in einer Datei gespeichert.|
| 9.1  |Programm existiert| - |Das Programm wurde objekt orientiert geschrieben.|



### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |25.08.2023|Keanu Koelewijn|Eine zufällige Zahl zwischen 1-100 wird generiert.|10min|
| 2.A  |25.08.2023|Stefan Jesenko|User kann eine Zahl eingeben|20min|
| 3.A  |25.08.2023|Keanu Koelewijn|Es wird geschaut ob die eingegebene Zahl grösser als die zufällige Zahl ist.|20min|
| 3.B  |25.08.2023|Stefan Jesenko|Es wird geschaut ob die eingegebene Zahl kleiner als die zufällige Zahl ist.|20min|
| 4.A  |25.08.2023|Keanu Koelewijn|Es wird geschaut ob die eingegebene Zahl die zufällige Zahl ist.|20min|
| 5.A  |25.08.2023|Stefan Jesenko|Es wird gezählt wie viele versuche der User gebraucht hat bevor er die Zahl erraten hat.|30min|
| 5.B  |25.08.2023|Stefan Jesenko|Es wird ausgegeben wie viele versuche der User gebraucht hat.|30min|
| 6.A  |25.08.2023|Keanu Koelewijn|Bei allen eingaben gegen Fehlerhafte eingaben absichern.|30min|
| 7.A  |01.09.2023|Keanu Koelewijn|Eine Lanverbindung herstellen|90min|
| 7.B  |01.09.2023|Stefan Jesenko|Beide Spieler können abwechselnd spielen.|30min|
| 8.A  |01.09.2023|Stefan Jesenko|Die Highscore Liste wird angezeigt.|30min|
| 8.B  |01.09.2023|Keanu Koelewijn|Die highscore Liste wird in einem Dokument gespeichert.|20min|




## 3 Entscheiden



Wir haben uns Entschieden, dass wir einen Randomn Number Guesser Spiel Programmieren in diesem wird man eine zufàllige Zahl erraten kann. Wir wollen ausserdem einen Multiplayer modus einbauen der über Lan läuft.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |25.08.2023|Keanu Koelewijn|10min|10min|
| 2.A  |25.08.2023|Stefan Jesenko|20min|20min|
| 3.A  |25.08.2023|Keanu Koelewijn|20min|20min|
| 3.B  |25.08.2023|Stefan Jesenko|20min|10min|
| 4.A  |25.08.2023|Keanu Koelewijn|20min|10min|
| 5.A  |  |  |  |
| 5.B  |  |  |  |
| 6.A  |01.09.2023|Stefan Jesenko|30min|20min|
| 8.A  |01.09.2023|Keanu Koelewijn|30min|60min|
| 8.B  |08.09.2023|Keanu Koelewijn|20min|40min|
 

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |08.09.2023|OK|Stefan Jesenko|
| 2.1  |08.09.2023|OK|Stefan Jesenko|
| 2.2  |08.09.2023|OK|Stefan Jesenko|
| 3.1  |08.09.2023|OK|Stefan Jesenko|
| 3.2  |08.09.2023|OK|Stefan Jesenko|
| 4.1  |08.09.2023|OK|Stefan Jesenko|
| 5.1  |08.09.2023|NOK|Stefan Jesenko|
| 6.1  |08.09.2023|OK|Stefan Jesenko|
| 7.1  |08.09.2023|NOK|Stefan Jesenko|
| 7.2  |08.09.2023|NOK|Stefan Jesenko|
| 7.3  |08.09.2023|NOK|Stefan Jesenko|
| 8.1  |08.09.2023|OK|Stefan Jesenko|
| 8.2  |08.09.2023|OK|Stefan Jesenko|
| 9.1  |08.09.2023|OK|Stefan Jesenko|

Es hat leider nicht geklappt den Multiplayer einzubauen. Es war etwas zu viel diesen in der begrenzten Zeit die wir hatten einzubauen. Wir werden nächstes mal besser Planen damit wir alles geplante auch umsetzen können.




## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

