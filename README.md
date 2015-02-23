# Arbetsprov
Arbetsprovet består av en visual studio lösning som innehåller två stycken projekt.

Det första projektet, "Arbetsprov", är en asp.net web application som innehåller en enkel websida, databas och en WCF service.
Websidan består av en gridview som visar data från databasen.
WCF servicen består av en metod för att lägga till data i databasen.

Det andra projektet, "MessageInput", är en console application från vilken man kan skicka ett meddelande genom en 
service referens till WCF servicen i första projektet som då sparar meddelandet i databasen.
