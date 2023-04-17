const form = (document.querySelector('form')!) as HTMLFormElement;
const toDoList = (document.querySelector('ul')) as HTMLUListElement;
const newToDo = (document.getElementById('newToDo')) as HTMLInputElement;
const item = (document.getElementsByTagName('li')) as HTMLCollectionOf<HTMLLIElement>


form.addEventListener('submit', function (e) {
    const li = document.createElement('li');
    e.preventDefault();
    let liText = document.createTextNode(newToDo.value);
    li.appendChild(liText);
    toDoList.appendChild(li);
    newToDo.value = "";

    function markChecked() {
        li.classList.toggle("checked");
    }
    li.addEventListener("click", markChecked);

    const deleteButton: HTMLButtonElement = document.createElement('button');
    deleteButton.appendChild(document.createTextNode('X'));
    li.appendChild(deleteButton);
    deleteButton.addEventListener('click', deleteItem);
    function deleteItem() {
        li.classList.add("close");
    }

    const clearAllButton = (document.querySelector('.clearButton')) as HTMLButtonElement;
    clearAllButton.addEventListener('click', clearAll);
    function clearAll() {
        li.classList.add('close');
    }

});



