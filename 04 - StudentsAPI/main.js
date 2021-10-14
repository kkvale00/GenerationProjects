
//seleziono il dom che con il ready passa la funzione
$(document).ready(init);


function init(){
    //dichiaro anzitutto una constante che per ogni funzione 
    const apiURL = 'http://learn-mock-api.herokuapp.com/api/v1/students';
    // ritorna all'url dell'api che stiamo usando

        //creo una funzione in modo da richiamarla e non riscreverla
    //che all'ul aggiungera una riga con i nuovi dati passati
    function create(student){
        const node = 
        $(`
            <tr>
                <td>${student.name}</td> 
                <td>${student.classroom}</td>   
                <td class= "${student.grades<6 ? 'red white' : ''} ">${student.grades}</td> 
                <td>${student.address}</td> 
                <td><button class="button1 right">DELET DIS</button></td>
            </tr>
        `);
        node.children('td').children('.button1').click(function(id){
                
            $.ajax(apiURL+"/"+id,
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
    
    function render(students){
        const list = [];
        
        for(const student of students){
            list.push(create(student));
            
           
        }
        $('table').append(list);
    }

    

    //nell'html ho dichiarato un button, ora vado a dargli un senso
    //richiamndo l'id assegnatogli e in modo che non stampi a vuoto diocan
    $('#new-btn').click(function(){
        //dichiaro una costante che valorizza l'input e trasforma in valore
        const name = $('#name').val();
        const classroom = $('#classroom').val();
        const grades = $('#grades').val();
        const address = $('#address').val();
        //procedo con stampare il comando, essendo che sto lavorando con un api
        //RESTFUL, la RUOTE corrisponde all'url dell'API e nel body valorizzo il 
        //l'oggetto
        //nel body, passo l'input che in precedenza ha valorizzato il valore
        $.ajax(apiURL,
             {data: JSON.stringify({
               name: name,
               classroom: classroom,
               grades: grades,
               address: address
            
            }),
            contentType: 'application/json',
            type: 'POST',},
             function(newstudent){

            const node = create(newstudent);
            $('ul').prepend(node);
        });
    });
    
}