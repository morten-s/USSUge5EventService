Programmet Har 2 forskellige endpoints , g�r kun lige hvad der er beskrevet i opgaven.

1: pizza ordre med en post funktion som kalder funktion i eventstore som gemmer et event 
2: event endpoint som kan l�se events som er gemt i event store

2 datatyper som records en til events og en til ordre.

der bruges scrutor til at injecte IEventstore i pizzaController

event store ville nok v�re decoupled mere i et rigtigt setup, med en seperat broker service som kunne tilg�es med en clientadapter / connectors
