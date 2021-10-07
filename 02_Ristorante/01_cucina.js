//questo e un oggetto anonimo, ovver creato senza partire da una classe
var p1 = {
    nome: "Spaghetti allo scoglio",
    prezzo: 11.5,
    ingredienti : ["Pasta","Vongole","Cozze"],
    tipo : "Primo"
};
var p2 = {
    nome: "Filetto di cavallo",
    prezzo: 15,
    ingredienti : ["Cavallo", "Sale"],
    tipo : "Secondo"
};
var p3 = {
    nome: "Polenta e brasato",
    prezzo: 12,
    ingredienti : ["Farina","Asino","Vino"],
    tipo : "Secondo"
};

var piatti = [p1,p2,p3];

function aggiungi(){

    var ris = {
        nome: document.getElementById("nome").value,
        prezzo: parseFloat(document.getElementById("prezzo").value),
        tipo: document.getElementById("tipo").value,
        ingredienti: document.getElementById("ingredienti").value.split(",")
    }

    piatti.push(ris);
    console.log("lets go");    
}

function stampa(){  

    var ris = "";
    
    document.getElementById("destra").innerHTML = "";
    
    for (var i = 0; i <piatti.length; i++)
    ris += `- ${piatti[i].nome} ${piatti[i].prezzo}$, <br>`;
    
    document.getElementById("destra").innerHTML = ris;
}

function prezzotot(){
    
    var ris = 0;
    
    document.getElementById("destra").innerHTML = "";
    
    for (var i = 0; i <piatti.length; i++)
    ris += piatti[i].prezzo;
    
    document.getElementById("destra").innerHTML = `il prezzo dei piatti totale e: ${ris}$`;
    
}

function stampaprimi(){  
    
    var ris = "";
    
    document.getElementById("destra").innerHTML = "";
    
    for (var i = 0; i <piatti.length; i++)
    {
        if(piatti[i].tipo == "Primo")
        ris += `- ${piatti[i].nome} ${piatti[i].prezzo}$, <br>`;
    }
    
    document.getElementById("destra").innerHTML = ris;
}

function stampaingredienti(){
    var ris = "";
    
    document.getElementById("destra").innerHTML = "";

    for(var i=0; i <piatti.length; i++){
        ris += `- ${piatti[i].nome} ${piatti[i].prezzo}$,<br>
                 ingredienti: ${piatti[i].ingredienti}, <br>`;
    }

    console.log("ris");
    document.getElementById("destra").innerHTML = ris;
}

function prezzotipo(){
    var ris = 0;
    
    for (var i = 0; i <piatti.length; i++)
    {
        if(piatti[i].tipo == document.getElementById("type").value)
        ris += piatti[i].prezzo;
    }
    document.getElementById("destra").innerHTML = `la somma piatti de ${document.getElementById("type").value} = ${ris}$`;
}

function prezzobw(){
    var ris = "";

    for (var i = 0; i <piatti.length; i++)
    {
        if(piatti[i].prezzo >= parseInt(document.getElementById("prezzomin").value) && 
            piatti[i].prezzo <=parseInt(document.getElementById("prezzomax").value))
            ris += `- ${piatti[i].nome} ${piatti[i].prezzo}$, ${document.getElementById("type").value} <br>`;
    }
    document.getElementById("destra").innerHTML = ris;
}

function cercapiattiIng(){
    var ris = "";
    var dacercare = document.getElementById("ingrediente").value.toLowerCase();

    for(var i=0; i<piatti.length; i++)
    {
        for(var k=0; k<piatti[i].ingredienti.length; k++)
            if(piatti[i].ingredienti[k].toLowerCase() == dacercare)
            {
                ris += `- ${piatti[i].nome} ${piatti[i].ingredienti}, <br>`;
                break;
            }
    }
    document.getElementById("destra").innerHTML = ris;
}

function cercapiattiNonIng(){
    var ris = "";
    var dacercare = document.getElementById("ingrediente").value.toLowerCase();

    for(var i=0; i<piatti.length; i++)
    {   
        var trovato = false;
        for(var k=0; k<piatti[i].ingredienti.length; k++)
            if(piatti[i].ingredienti[k].toLowerCase() == dacercare)
            {
                trovato = true;
                break;
            }
    }

    if(!trovato)
        ris += `- ${piatti[i].nome}, <br>`;


    document.getElementById("destra").innerHTML = ris;
}