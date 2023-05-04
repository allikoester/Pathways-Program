var form = (document.querySelector('form'));
var toDoList = (document.querySelector('ul'));
var newToDo = (document.getElementById('newToDo'));
var item = (document.getElementsByTagName('li'));
form.addEventListener('submit', function (e) {
    var li = document.createElement('li');
    e.preventDefault();
    var liText = document.createTextNode(newToDo.value);
    li.appendChild(liText);
    toDoList.appendChild(li);
    newToDo.value = "";
    function markChecked() {
        li.classList.toggle("checked");
    }
    li.addEventListener("click", markChecked);
    var deleteButton = document.createElement('button');
    deleteButton.appendChild(document.createTextNode('X'));
    li.appendChild(deleteButton);
    deleteButton.addEventListener('click', deleteItem);
    function deleteItem() {
        li.classList.add("close");
    }
    var clearAllButton = (document.querySelector('.clearButton'));
    clearAllButton.addEventListener('click', clearAll);
    function clearAll() {
        li.classList.add('close');
    }
});
