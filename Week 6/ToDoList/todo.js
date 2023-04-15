var addButton = document.getElementById("addButton");
var input = document.getElementById("newListItem");
var list = document.getElementById("list");
var item = document.getElementsByTagName("li");
function addItemToList() {
    var li = document.createElement("li");
    li.appendChild(document.createTextNode(input.value));
    list.appendChild(li);
    input.value = "";
}
