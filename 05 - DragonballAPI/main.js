
//seleziono il dom che con il ready passa la funzione
$(document).ready(init);


function init(){
    //dichiaro anzitutto una constante che per ogni funzione 
    const apiURL = 'https://localhost:44385/Character';
    // ritorna all'url dell'api che stiamo usando

        //creo una funzione in modo da richiamarla e non riscreverla
    //che all'ul aggiungera una riga con i nuovi dati passati
    function create(character){
        const node = 
        $(`
            <tr>
                <td>${character.name}</td> 
                <td>${character.power}</td>   
                <td>${character.dob}</td> 
                <td><button class="button1 right">DELETE</button></td>
            </tr>
        `);
        node.children('td').children('.button1').click(function(){
                
            $.ajax(apiURL+"/"+character.id,
                {
                  type: 'DELETE',
                  contentType: 'application/json',
                },
           );
           node.hide();
        });

        return node;

    }

    $.get(apiURL, render);
    
    function render(characters){
        const list = [];
        
        for(const character of characters){
            list.push(create(character));
            
           
        }
        $('table').append(list);
    }

    

    //nell'html ho dichiarato un button, ora vado a dargli un senso
    //richiamndo l'id assegnatogli e in modo che non stampi a vuoto diocan
    $('#new-btn').click(function(){
        //dichiaro una costante che valorizza l'input e trasforma in valore
        const name = $('#name').val();
        const power = $('#power').val();
        const dob = $('#dob').val();
        //procedo con stampare il comando, essendo che sto lavorando con un api
        //RESTFUL, la RUOTE corrisponde all'url dell'API e nel body valorizzo il 
        //l'oggetto
        //nel body, passo l'input che in precedenza ha valorizzato il valore
        console.log(name);
        $.ajax(apiURL,
             {data: JSON.stringify({
               name: name,
               power: parseInt(power),
               dob: dob,
            
            }),
            type: 'POST',
            contentType: 'application/json',
            },
             function(newcharacter){

            const node = create(newcharacter);
            $('table').append(node);
        });
    });
}