// $ selezioniamo il dom e per mezzo della funzione ready
// passiamo la nostra funzione al cui interno sarà contenuta
// tutta la logica dell'applicazione
$(document).ready(init);

// In JS posso passare le funzioni come parametri ad altre funzione
// callback
// Le function sono first class citizens
function init() {
  const apiURL = 'https://jsonplaceholder.typicode.com/todos';

  $('#add-btn').click(function () {
    const inputValue = $('#todo').val();
    console.log(inputValue);

    // Devo effettuare una chiamata AJAX, con metodo POST
    // e mandare nel body un oggetto ti tipo Todo:
    // title: inputValue
    $.post(apiURL, { title: inputValue }, function (newTodo) {
      // Se si tratta di una RESTFul API dovrebbe rimandarmi indietro
      // la risorsa creata nel server: con l'id assegnato
      const node = createElementFromTodo(newTodo);
      // a differenza di append, aggiunge davanti invece che di dietro
      $('ul').prepend(node);
    });
  });

  // $.get effettua una chiamata di tipo GET all'indirizzo specificato
  // il secondo parametro è la funzione di callback che viene richiamata
  // quando la chiamata (dell'api) viene effettuata con successo
  $.get(apiURL, renderTodoList);

  function createElementFromTodo(todo) {
    const node = $(`
        <li class="${todo.completed ? 'completed' : ''}">
            ${todo.title}
        </li>
    `);
    // a cui posso, per mezzo della funzione click
    // assegnare un evento specifico
    node.click(function () {
      // prendiamo l'elemento che è stato cliccato
      // e effettuiamo il toggle della classe che segnala
      // lo stato di completed
      $(this).toggleClass('completed');
    });
    return node;
  }

  // Questo approccio è più complesso
  // perché voglio assegnare delle funzioni agli elementi
  // che vado a creare col codice JS
  // con soltanto il codice html potevo fare relativamente poco
  // ma creado oggetto JQuerizzati
  // posso assegnargli direttamente delle funzionalità
  function renderTodoList(todos) {
    const nodeList = [];

    for (const todo of todos) {
      // $('codiceHtml') mi crea un oggetto JQuerizzato
      nodeList.push(createElementFromTodo(todo));
    }
    // append() rispetto a html() non va a sovrascrivere il contenuto
    // originale, ma aggiunge soltanto il resto in "coda"
    $('ul').append(nodeList);
  }
  // Genera del codice html e poi va a sovrascrivere quello
  // dell'elemento ul
  //   function renderTodoList(todos) {
  //     let listHtml = '';
  //     // foreach, in JS si chiama for of, perché in JS foreach è una function
  //     for (const todo of todos) {
  //       listHtml += `
  //         <li class="${todo.completed ? 'completed' : ''}">
  //             ${todo.title}
  //         </li>
  //       `;
  //     }
  //     $('ul').html(listHtml);
  //   
}
/*
function test() {
  //   console.log(v2);
  //   let v1;
  //   // a tutti i var viene applicato l'hoinsting
  //   // sollevamente rispetto alla funzione in cui si trova
  //   var v2;
  //   const c3 = 3.14;
  if (true) {
    var v1 = 33;
  }
  {
    var v1 = 42;
  }
  console.log(42);
}
test();
*/
/*
const numbers = [312, 12, 45, 12, 777, 99, 11];
numbers.sort(sortFunction);
console.log(numbers);
function sortFunction(first, second) {
  if (first < second) {
    return 1;
  }
  return -1;
}
let sum = 0;
numbers.forEach(function (x) {
  sum += x;
});
console.log(sum);
*/