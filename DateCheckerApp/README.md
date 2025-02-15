Info:
Das zentrale Rechenzentrum einer Bank hat sich vorgenommen, eine eigene Software zur automatisierten Belegerfassung zu entwickeln. Die von den Bankkunden handschriftlich ausgefüllten Überweisungsformulare sollen in Zeichencodes umgesetzt werden (Fachbegriff dafür: OCR=Optical Character Recognition).

Ein Belegleser liefert das Datum in Form von drei Zahlen: eine für den Tag, eine für den Monat und eine für das Jahr. Die Softwareentwicklung bittet Sie wg. Personalmangel um Unterstützung bei der Entwicklung einer Routine, die das Datum auf Gültigkeit überprüft. Die Routine soll das Datum entgegennehmen und "wahr" bzw. "falsch" zurückliefern, je nach Gültigkeit des Datums.

Beispiele:
Der Belegleser liefert als Datum die drei Zahlen 22 12 2007, also den 22. Dezember 2007. Dieses Datum ist formal richtig, also "wahr".

Der Belegleser liefert 32 10 2007. Den 32. Oktober gibt es nicht, daher "falsch".

Der Belegleser liefert 29 2 2007. 2007 war kein Schaltjahr, daher ebenfalls "falsch".

Auftrag:
Erstellen Sie zunächst den Algorithmus und stellen Sie diesen als Struktogramm dar; anschließend erstellen Sie das Programm.

Um Ihre Funktion testen zu können, müssen Sie ein Testprogramm entwickeln. Ihr Testprogramm muss die Möglichkeit bereitstellen, drei Zahlen (Tag, Monat Jahr) eingeben zu können. Ihre Funktion soll diese drei Werte übernehmen. Entsprechend dem Rückgabewert Ihrer Funktion (True oder False) soll Ihr Testprogramm "Datum ok" bzw. "Datum nicht ok" auszugeben.

Hinweise zur Programmierung:

Erstellen Sie eine Klasse „DateProof“. Erstellen Sie in dieser Klasse eine Methode „datok“, die drei integer-Werte als Parameter übernehmen kann (tag, monat, jahr), und einen boolschen Rückgabewert hat (true oder false).
