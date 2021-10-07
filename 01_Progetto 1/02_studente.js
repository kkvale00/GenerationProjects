function calcola(){
    console.log("hai cliccato il pulsante!");

    //prendere gli input del valoridei voti
    var nome = document.getElementById("nome").value;
    var votoita = parseInt(document.getElementById("votoita").value);
    var votosto = parseInt(document.getElementById("votosto").value);
    var votomate =parseInt(document.getElementById("votomate").value);
    var votoing = parseInt(document.getElementById("votoing").value);

    if( isNaN(votoita) || isNaN(votoita) || isNaN(votoita) || isNaN(votoita) 
        || nome.value == "")
    {
        document.getElementById("testoRisposta").innerHTML = 
        "oh che cristo mi clicchi se non metti i voti ";

        return;
    }

    //console.log("nella casellina del nome hai scritto " + nome);
    //console.log("nella casellina votoita hai scritto " + votoita);

    //faccio la media
    var media = (votoing + votoita + votosto + votomate) / 4;

    //sommo con il ternario per contare le insufficienze
    var nInsufficienze =    (votoita < 6 ? 1 : 0) +
                            (votosto < 6 ? 1 : 0) +
                            (votomate< 6 ? 1 : 0) +
                            (votoing < 6 ? 1 : 0) ;

    //do un true false se e' stato bocciato
    var promosso = false;
    if(media >= 6 && nInsufficienze <= 1)
        promosso = true;

    //controllo se e stato bocciato e stampo le risposte
    if(promosso){
        document.getElementById("testoRisposta").innerHTML =
            "complimenti sei stato promosso con la media del " + media;
        }
    else {
        document.getElementById("testoRisposta").innerHTML = 
            nome + " sei stato bocciato.. hai una media del " + media;
        }
}

//in js non va specificato il tipo dei parametri
function fix(fixit) {
    if(parseInt(document.getElementById(fixit).value) < 1)
        document.getElementById(fixit).value = 1;
    else if(parseInt(document.getElementById(fixit).value) > 10)
        document.getElementById(fixit).value = 10;
}