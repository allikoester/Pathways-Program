var addButton = document.getElementById("addButton");
var input = document.getElementById("newListItem");
var list = document.querySelector("list");
var item = document.getElementsByTagName("li");
function inputLength() {
    return input.value.length;
}
function listLength() {
    return item.length;
}
function addItemToList() {
    var li = document.createElement("li");
    li.appendChild(document.createTextNode(input.value));
    list.appendChild(li);
    input.value = "";
    function crossOut() {
        li.classList.toggle("done");
    }
    li.addEventListener("click", crossOut);
    var deleteButton = document.createElement("button");
    deleteButton.appendChild(document.createTextNode("X"));
    li.appendChild(deleteButton);
    deleteButton.addEventListener("click", deleteListItem);
    function deleteListItem() {
        li.classList.add("delete");
    }
}
function addToListAfterClick() {
    if (inputLength() > 0) {
        addItemToList();
    }
}
function addToListAfterKeypress(event) {
    if (inputLength() > 0 && event.which === 13) {
        addItemToList();
    }
}
addButton.addEventListener("click", addToListAfterClick);
input.addEventListener("keypress", addToListAfterKeypress);
