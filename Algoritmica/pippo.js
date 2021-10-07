//Quesito 1
//Crea un vettore contenente 5 numeri, stampare la somma dei numeri dispari
var vet = [5, 9, 12, 39, 10];

var somma = 0;
for (var i = 0; i < vet.length; i++)
    if (vet[i] % 2 == 1)
        somma += vet[i];

document.getElementById("risposta1").innerHTML = `Quesito numero 1:<br> ${somma}`;

//Quesito 2
//Utilizzando il vettore creato nel quesito numero stampare il numero più piccolo
//il numero più grande e la media dei numeri
var max = Math.max(5, 9, 12, 39, 10);
var min = Math.min(5, 9, 12, 39, 10);
var somma = 0;
var n = 0;

for (var i = 0; i < vet.length; i++){
    somma += vet[i];
    n++
}
document.getElementById("risposta2").innerHTML = `Quesito numero 2:<br> >il minimo: ${min},<br>>il massimo: ${max}<br>,>la media: ${somma/n}<br>`;


//quesito 3
//Crea un vettore contenente 5 parole, stampare quante sono le parole la cui
//lunghezza è >= 5 lettere e stampare il numero medio di lettere

var nomi = ["mamma","papa","nonna","zio","cugina"]
var ris = 0;
var sommas = 0;

for (var i = 0; i < nomi.length; i++){
    sommas += nomi[i].length;
    if(nomi[i].length >= 3){
        ris++;
    }
}
document.getElementById("risposta3").innerHTML = `Quesito numero 3:<br> >quante parole: ${ris},<br>>media lettere: ${sommas/ris}`;

//Quesito 4
//Crea un oggetto anonimo,vedi cucina.js, con le proprietà: nome, residenza, 
//professione, eta valorizzate come vuoi tu
//Poi stampa il prezzo del biglietto che questa persona paga al cinema sapendo che
//un biglietto costa 8€ a cui:
//togliamo 2€ a chi ha meno di 12 anni o è medico
//togliamo 5€ a chi è militare o ha meno di 5 anni
//togliamo 3€ a chi abita a "Calvenzano" 
//APPLICARE SOLO UNO SCONTO, OVVIAMENTE IL PIU VANTAGGIOSO

var p = {
    nome: "davide",
    residenza: "calvenzano",
    professione: "medico",
    eta: 19
}

var biglietto = 8;

if(p.professione == "militare" || p.eta < 5)
    biglietto -= 5;
else if(p.residenza == "calvenzano")
    biglietto -= 3;
else if(p.professione == "medico" || p.eta < 12)
    biglietto -= 2;

document.getElementById("risposta4").innerHTML = `Quesito numero 4:<br>costo totale: ${biglietto}$<br>`;


//Quesito 5
//Creare 3 oggetti anonimi come quelli di prima e aggiungerli tutti ad un vettore
//Successivamente scrivere il calcolo che mi restituisca l'età media delle persone
var p1 = {
    nome: "fabio",
    residenza: "milano",
    professione: "militare",
    eta: 23
}
var p2 = {
    nome: "barbara",
    residenza: "napoli",
    professione: "barbiere",
    eta: 19
}
var p3 = {
    nome: "achille",
    residenza: "torino",
    professione: "medico",
    eta: 4
}

var persone = [p1,p2,p3];

var ans = 0;
var n = 0;

for(var i=0; i<persone.length; i++){
    ans += persone[i].eta;
    n++;
}
document.getElementById("risposta5").innerHTML = `Quesito numero 5:<br> La media dell'eta e' ${ans/n}`;

//Quesito 6
//Stampare in ordine il vettore del quesito 1 dal numero più basso al più alto
var vez = [5, 9, 12, 39, 10];

vez = vez.sort(function(a, b){return a - b});
document.getElementById("risposta6").innerHTML = `quesito numero 6: ${vez}<br>`;

//Quesito 7
//Stampare in ordine il vettore del quesito 2 dalla parola prima in ordine
//alfabetico all'ultima
nomi = nomi.sort();
document.getElementById("risposta7").innerHTML = `quesito numero 7: ${nomi}<br>`