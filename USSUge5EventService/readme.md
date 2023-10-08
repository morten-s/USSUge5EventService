Programmet Har 2 forskellige endpoints , gør kun lige hvad der er beskrevet i opgaven.

1: pizza ordre med en post funktion som kalder funktion i eventstore som gemmer et event 
2: event endpoint som kan læse events som er gemt i event store

2 datatyper som records en til events og en til ordre.

der bruges scrutor til at injecte IEventstore i pizzaController

event store ville nok være decoupled mere i et rigtigt setup, med en seperat broker service som kunne tilgåes med en clientadapter / connectors
