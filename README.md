1. [Aufteilung](#projekt-und-branchaufteilung)
2. [Anforderungen](#anforderungen)
3. [Richtlinien](#richtlinien)  
- [Mergekonflikte](#mergekonflikte-vermeiden)  
- [Organisation](#organisation)  


# MultiTool
Die Schüler des Bildungsganges Berufsfachschule wurden damit beauftragt eine Multi-Tool Software zu erstellen, welche allen kommenden Berufsfachschülern aus dem Bereich Technik als Hilfsmittel dienen soll, um ihren Schulabschluss erfolgreich zu meistern. Hierbei sollen wiederkehrende oder besonders aufwendige Aufgaben aus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben ergeben sich aus den Problemstellungen der Unterrichtseinheiten der Berufsfachschule für Technik. 

Das Projekt ist in die Bereiche Mathematik, Elektrotechnik… aufgeteilt. Diese Bereiche orientieren Sich an den Naturwissenschaftlichen Unterrichtsfächern der Berufsfachschule. Die nachfolgende Tabelle zeigt welche Features in den einzelnen Bereichen umgesetzt werden.


***Die Teamkoordinatoren können direkt in die jeweilige Entwicklungs-Branch schreiben. Die Entwickler müssen ein Pull-Request bei den jeweiligen Koodrinatoren stellen*** 

---

## Anforderungen

Die Einhaltung der Anforderungen wird bei der Bewertung der Teilprogramme geprüft.

|Framework Anforderungen | Anforderungen an die Benutzerfreundlichkeit| Externe Anforderungen|
|----------|----------|----------|
|Programmiert in C#|Programm und einzelne Optionen sind beliebig oft wiederholbar.|Alle gesetzlichen vorgaben werden eingehalten.|
|Konsolenanwendung|Eine Fehleingabe führt zu einer erneuten Eingabeaufforderung.|Moralische und ethische Grundsätze sind einzuhalten.|
|.NET 6 |Eingabeaufforderungen können ohne gültige Eingabe verlassen werden. |-|
|Alle Features und Menüs sind in der Klassenbibliothek zu erstellen|Das Programm kann in jederzeit beendet werden.|-|
|-|Alle Eingaben werden über die Tastatur gemacht.|-|
|-|Die Konsole wird beim Verlassen des aktuellen Moduls gelöscht.|-|

---

## Projekt und Branchaufteilung

Alle Teilnehmer die noch kein Feature eingereicht haben, sind dazu angehalten, zeitnah eins vorzuschlagen. 

***Die Teamkoordinatoren können direkt in die jeweilige Entwicklungs-Branch schreiben. Die Entwickler müssen ein Pull-Request bei den jeweiligen Koordinatoren stellen*** 

| Bereich     	    | Feature 	|Rolle		        |Username	|Branch		             |
| --------------- 	| -------- 	|------		        |--------	|-----------	         |
|**Administration**	|Release    |Administrator		|   AI-Assistant  	  |Release, main         |
|		                |	          |		              |      		|		                   |		
|**Elektrotechnik**	|Menü ET    |Teamkoordinator  |         |ETEntwicklung,Feature1|
|                   |           |Entwickler       |         |Feature2              |
|                   |           |Entwickler       |         |Feature3              |
|                   |           |Entwickler       |         |Feature4              |
|                   |           |Entwickler       |         |Feature5              |
|		                |	          |              		|		      |		                   |		
|**Physik**	        |Menü PY / Gravitation 	  |Teamkoordinator  |CallmeBabygirl|PHEntwicklung	,Feature6|
|		                |           |Entwickler	      |nahehs   |Feature7              |		
|		                |	          |Entwickler	      |Nextsuki |Feature8              |
|		                |           |Entwickler	      |simqn    |Feature9              |
|		                |           |Entwickler       |         |Feature10             |		
|		                |	          |                 |         |                      |				
|**Informatik**	    |Menü IT    |Teamkoordinator  |   snwster      |ITEntwicklung,Feature11|				
|		                |Passwortgenerator	          |Entwickler       |		nacelol      |Feature12             |		
|		                |Byterechner	          |Entwickler       |   K923ai      |Feature13             |	
|		                |	          |Entwickler       |  	kilian1008      |Feature14             |			
|		                |	          |Entwickler       |         |Feature15             |			
|		                |	          |	                |		      |		                   |				

|		                |	          |	              	|		      |                        	 |					
|**Mathematik**	    |Menü MT    |Teamkoordinator  | WireWale        |MAEntwicklung,Feature21|				
|		                |           |Entwickler       | Kohano        |Feature22             |		
|		                |           |Entwickler       | JonathanJostar05        |Feature23             |		
|		                |           |Entwickler       | qwni 	      |Feature24             |
|		                |           |Entwickler	      | eleinads      	|Feature25             |


---

## Richtlinien

Die Richtlinien dienen dazu, die Zusammenarbeit geordnet und übersichtlich zu gestalten. 

Es ist von höchster Wichtigkeit, dass sich alle an diese Richtlinien halten, ansonsten kann es zu schweren Problemen bei der Zusammenführung der Bereiche kommen. 

### Mergekonflikte vermeiden

|||
| ----------- 	| ----------- 	|
|  | Default Projekte **nicht** verändern!!|
| ⚠️ |**MultiTool** |
| ⚠️  |**KonsolenExtrasBibliothek**  |

Einstellungen oder Dateien dieser bereits in den Branches existierenden Projekte dürfen von **keinem** geändert werden. Eine Missachtung kann dazu führen das 

1. Der Teamkoordinator euren Pull-Request nicht merged (Code des Entwicklers wird nicht in das Projekt eingebunden).
2. Der Admin euren Team-Pull-Request nicht merged (Code des Teams wird nicht in das Projekt eingebunden).

Die Teamkoordinatoren achten darauf, dass die Richtlinien eingehalten werden. 🦅 


### Organisation

Alle Teamkoordinatoren müssen eine neue Klassenbibliothek für ihren Bereich erstellen. Um das Untermenü aufzurufen wird eine .cs Datei erstell welche Bereichsspezifisch benannt wird. Das Untermenü soll anschließend in einer Methode realisiert werden. 

|Bereich|Name der Klassenbibliothek|Untermenü Klassenname/Dateiname|Methodenbezeichnung|
| ----------- 	| ----------- 	| ----------- 	| ----------- 	|
| Elektrotechnik | ETKlassenBibliothek|ETMenue/ETMenue.cs|ETSubMenue|
| Informatik|ITKlassenBibliothek |ITMenue/ITMenue.cs|ITSubMenue|
| Mathematik  |MAKlassenBibliothek |MAMenue.cs/MAMenue|MASubMenue|
|Physik|PHKlassenBibliothek|PHMenue/PHMenue.cs|PHSubMenue|
|Wirtschaft|WIKlassenBibliothek|WIMenue/WIMenue.cs|WISubMenue|

Die jeweiligen Bereiche und Ihre Mitglieder erstellen und verändern nur Dateien in ihren **eigenen** Klassenbibliotheken. ⚠️ 

### Branches

Jedes Projektmitglied sollte eine Branch erstellen in der das Feature Programmiert wird. In der [Projektübersicht](#projekt-und-branchaufteilung) können die dafür zu verwendenden Branch-Bezeichnungen entnommen werden. 

Wenn Branches gepusht werden, die selber erstellt worden sind, sind diese nicht schreibgeschützt. Aus diesem Grund ist darauf zu achten das nur in der eigenen Branch programmiert wird.
