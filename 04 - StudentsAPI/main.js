
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
           <li class=name > 
                ${student.name}
           </li>
           <li class=classroom >
                ${student.classroom}
           </li>
           <li class=grades > 
                ${ParseInt32(student.grades)}
           </li>
           <li class=address > 
                ${student.address}
           </li>
        `);
        return node;
    }

    function render(students){
        const list = [];
        
        for(const student of students){
            list.push(create(student));
        }
        $('ul').append(list);
    }

    $.get(apiURL, render);

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
               Name: name,
               Classroom: classroom,
               Grades: grades,
               Address: address
            
            }),
            contentType: 'application/json',
            type: 'POST',},
             function(newstudent){

            const node = create(newstudent);
            $('ul').prepend(node);
        });
    });
    
}