# Referentie architectuur

De ToDo uitwerking bevat de referentie architectuur als richtlijn voor de Memory aftekenopdracht. 


## Meerdere Solution files. 

Open eerst de ConsoleToDoSolution om een uitwerking van de referentie architectuur door te nemen waarbij de data-access laag 'InMemory' een eenvoudige generieke Collection is en een Console user interface heeft. Het project voor de business laag wordt ook geladen. Kijk daarna naar het test project, hierin zie je verschillende soorten van Unit Testen staan die de business logica testen. Er wordt ook een voorbeeld gegeven hoe een test met Mocking gedaan kan worden. Hierbij wordt de data access laag in de test vervangen door een Mock. De mogelijkheid tot deze vorm van geïsoleerde testen is een van de vele voordelen van deze gekozen 'clean' architectuur.

Open daarna de WpfToDoSolution. Hierin vind je weer de business laag (herbruikbaar) maar nu toegepast in een WPF userinterface en is de data-access laag een SQL-Server database. De code voor het WPF gedeelte is echter nog niet helemaal uitgewerkt. (Werk in uitvoering) 

Wanneer je de ToDoSolution opent worden alle projecten geladen, dit kan handig zijn wanneer je de overeenkomsten in de verschillende toepassingen van de business laag wilt vergelijken.


## Database Aanmaken

Voor het uitvoeren van de applicatie is een database nodig. In het data access project staat een tekstbestand (Create  Db and Table-sql.txt) met instructies voor het aanmaken van de database. 
