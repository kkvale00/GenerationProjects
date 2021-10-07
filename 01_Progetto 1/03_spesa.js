//creo un vettore prodotti , in javascript i vettori sono dinamici
//e possono contenere elementi di tipi diversi
var prodotti = [];

function aggiungi(){
    
    prodotti.push(document.getElementById("prodotto").value);

    document.getElementById("prodotto").value = "";


    console.log(prodotti);

    //ogni volta che verra aggiunto, verranno ristampati tutti
    stampa();
}

function stampa(){
    var ris = "";

    for (var i = 0; i <prodotti.length; i++)
        ris += " - " + prodotti[i] + "<br>";

    document.getElementById("elenco").innerHTML = ris;

}

function cancellaultimo(){
    prodotti.pop();

    console.log(prodotti);
    stampa();
}

function deletedis(){
    prodotti.splice(document.getElementById("todelete"),1);

    console.log(prodotti);
    stampa();



}