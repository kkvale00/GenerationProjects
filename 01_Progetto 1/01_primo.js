/*
Javascript è un linguaggio per la gestione degli eventi
Significa che risponde ad eventuali input inseriti dall'utente in modi che
possiamo definire noi, solitamente attivando determinate funzioni.
Una funzione non è altro che un blocco di codice che contiene istruzioni.
*/
function calcola(){
    //questo e il corpo della funzione
    //quando verra richiamata vera eseguita 
    //tutto questo codice
    console.log("hai cliccato il bottone!");
    
    //il prezzo del biglietto parte da 7
    //se hai meno di 12 anni o piu di 60 sconto 2euro
    //se fai il medico o militare sconto 3 euro
    //se il film "squalo,it,shining" aumenta 2 euro

    var nomeInserito = document.getElementById("nome").value;
    var etaInserita = document.getElementById("eta").value;
    var profInserita = document.getElementById("professione").value;
    var filmInserito = document.getElementById("film").value;

    console.log("nella casellina del nome hai scritto " + nomeInserito);
    console.log("nella casellina dell'eta hai scritto " + etaInserita);
    console.log("nella casellina della professione hai scritto " + profInserita);
    console.log("nella casellina del film hai scritto " + filmInserito);

    var biglietto = 7;

    if(etaInserita < 12 || etaInserita > 60)
        biglietto -= 2;
    if(profInserita.toLowerCase() == "medico" || profInserita == "militare")
        biglietto -= 3;
    if(filmInserito.toLowerCase() == "squalo" || filmInserito == "it" || filmInserito == "shining")
        biglietto += 2;
    
    console.log("il tuo biglietto costa " + biglietto);

    //andiamo a modificiare la scritta contenuta nel paragrafo con id "testorisposta"
    //e ci mettiamo il risultato del calcolo
    //l'INNERHTML indica il testo che c'e tra l'apertura e la chiusura di un tag
    //qualsiasi. Con questa istruzione andiamom a sostituirlo
    document.getElementById("testoRisposta").innerHTML = 
        //"Caro " + nomeInserito + " il tuo biglietto costa " + biglietto + "euri";
        `Caro ${nomeInserito}, il tuo biglietto costa ${biglietto}$`; 
}