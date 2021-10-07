class Piatto{
    constructor(n,p,t){
        this.nome = n;
        this.prezzo = parseFloat(p);
        this.tipo = t;
    }
    toString = function(){
        return ` - ${this.nome} "(${this.tipo})" ${this.prezzo}$ <br>`;
    }

}//fine classe

class Tavolo{
    constructor(n,c){
        this.numero = parseInt(n);
        this.coperti = parseInt(c);
        this.piatti = [];
    }

    conto = function(){
        var ris = 0;

        for(var i=0; i<this.piatti.length;i++)
            ris += this.piatti[i].prezzo ;

        ris += this.coperti*2;

        return ris;
    }

    toString = function(){
        var elenco = "";

        for(var i=0; i<this.piatti.length;i++)
            elenco += this.piatti[i].toString();

        return `- Tavolo n°${this.numero}: ${this.coperti} coperti,<br> ${elenco}<br><br>
                 TOTALE CONTO: ${this.conto()}$`;
    }
}//fine classe

/*function test(){
    elencoTavoli[0].piatti.push(menu[0]);
    elencoTavoli[0].piatti.push(menu[1]);

    document.getElementById("stampatest").innerHTML = elencoTavoli[0].toString();
}*/

var menu = [
    new Piatto("Gnocco fritto con salumi", 8,90, "Antipasto"),
    new Piatto("Linguine allo scoglio", 13, "Primo"),
    new Piatto("Penne al pesto", 8, "Primo"),
    new Piatto("Grigliata mista", 15 , "Secondo"),
    new Piatto("hamburger veg", 4 , "Secondo"),
    new Piatto("Patatine fritte", 3 , "Contorno"),
    new Piatto("Cheesecake", 5.5 , "Dolce"),
    new Piatto("Red Velvet", 8.5 , "Dolce")
];

var elencoTavoli = [
    new Tavolo(1,2),
    new Tavolo(2,4),
    new Tavolo(3,4),
    new Tavolo(4,5),
    new Tavolo(5,8),
    new Tavolo(6,8),
    new Tavolo(7,12)
];

for(var i=0; i<elencoTavoli.length;i++){
    document.getElementById("bottonitavoli").innerHTML += 
    "<button onclick='stampaTavolo(" +elencoTavoli[i].numero + ")'>" + 
    "TAVOLO " + elencoTavoli[i].numero +
    " </button";
}
function stampaTavolo(numeroTavolo){
    //console.log(`Ti devo stampare il tavolo numero ${numeroTavolo}`);
    
    for (var i = 0; i <elencoTavoli.length; i++){
        if(numeroTavolo == elencoTavoli[i].numero)
            document.getElementById("stampaTavolo").innerHTML = elencoTavoli[i].toString();
    }
    
}

/*
    `<button onclick= '${stampaTavolo("elencoTavoli[i].numero")}' > TAVOLO ${elencoTavoli[i].numero} </button`;
     "<button onclick='stampaTavolo(" +elencoTavoli[i].numero + ")'>" + 
    "TAVOLO " + elencoTavoli[i].numero +
    " </button";
*/

function aggiungipiatto(){
    
    var ris = {
        nome: document.getElementById("nome").value,
        prezzo: parseFloat(document.getElementById("prezzo").value),
        tipo: document.getElementById("tipo").value
    }
    
    var nice = false;

    if(this.nome != "" && this.prezzo >= 3 && this.prezzo <=25)
    {
        nice = true;
        
    }
    
    if(nice)
        menu.push(ris);
    
    
    console.log("done");
}

function stampa(){  

    var ris = "";
    
    for (var i = 0; i <menu.length; i++)
    ris += `- ${menu[i].nome} ${menu[i].prezzo}$, <br>`;
    
    document.getElementById("destra").innerHTML = ris;
}