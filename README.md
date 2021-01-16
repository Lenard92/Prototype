# Prototype


[Korte inleiding]

Leuk dat je verder wilt werken aan deze aplicatie; ik heb er met veel plezier aan gewerkt en ik zal je wegwijsmaken in wat er tot nu toe gebeurd is, welke ideeën er nog 'under construction' zijn en hoe je het beste verder kunt gaan. 

[Het huidige product]

Wat je hier ziet is het resultaat van een MVP vanuit onze opdrachtgever, met wat extra uitwerkingen en functies. De opdracht die hij ons gaf luidt als volgt: 

"De mobiele applicatie moet werken met een lokale database die meetgegevens opslaat in een entry, inclusief timestamp. Vervolgens moet er een list gegenereerd worden op basis van de tables van de database en moeten de gegevens via die list in de applicatie uitgelezen kunnen worden. De app moet makkelijk in gebruik zijn en platformonafhankelijk werken."

[De meetdatabase en diens entries]  

(! Het project maakt gebruik van een .Net library en de gebruikte SQLite package heet: sqlite-net-pcl by SQLite-net versie 1.7.335 https://github.com/praeclarum/sqlite-net )

De Meetdatabase entries zijn nu op twee manieren moggelijk; 
(1) Op de pagina met meetgegevens is een knop met opslaan, bij het indrukken van deze knop wordt de DateTime property van Meetgegevens.Dag ingevuld met de huidige datum en tijd. (2) Bij de knop kies zelf een datum wordt de datum die geselecteerd wordt door de user meegegeven via de kalender aan de DateTime property van Meetgegevens.Dag. 

Een klein dilemma dat ik hier heb is dat de timevalue bij handmatige datum selectie 00:00:00 is, dat is logisch want je selecteert geen datum op de kalender, maar het staat niet heel erg mooi vind ik zelf. Het dilemma bestaat uit het feit dat ik de tijd die meegegeven wordt volgens methode 1 wel echt iets vind toevoegen en daarom het time atribuut eigenlijk niet wil weghalen, hoewel dat er in het geval van handmatige selectie dus een beetje vreemd uitziet. 

[Processen in ontwikkeling]

Op dit punt is zijn deze delivarables behaald en is er ook al gewerkt aan een inlogfunctie/ userdatabase en een welkomspagina. Wat nog ontbreekt is een pagina waar een user zich kan registreren, want op die manier zou nagegaan kunnen worden of de gegevens die ingevoerd overeen komen met een eerdere user entry en indit het geval zou zijn zou je dan via een REST API je persoonlijke database moeten kunnen downloaden op je mobiele device. Verder wordt er nu slechts gekeken of de username_entry en password_entry een bepaalde value hebben, je krijgt nu alleen een foutmelding als die values leeg zijn met een simpel if/ else statement. 

[Hoe kun je vanaf hier het beste verder gaan?]
Hoewel de basis goed werkt, zou een goed startpunt voor doorontwikkeling zijn om failover tests uit te voeren en null checks te implementeren indien dat kan voorkomen dat de app crasht vanwege een nullreference exception. Op deze manier wordt de basis van de applicatie een stuk stabieler dan nu het geval is en kan je door naar het uitwerken van de userdatabase en de verschillende pagina's die daar relevant zijn (welkomspagina, registratiepagina, dashboard et cetera).

Veel succes met de doorontwikkeling, mocht het nodig zijn ben ik te bereiken via:

Lenard92 @Github
email: lvwinssen@student.che.nl
telefoon: 0621904368

