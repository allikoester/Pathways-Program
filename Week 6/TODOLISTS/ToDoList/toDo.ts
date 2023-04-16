const addButton: HTMLButtonElement = <HTMLButtonElement>document.getElementById("addButton");
const input: HTMLInputElement = <HTMLInputElement>document.getElementById("newListItem");
const list: HTMLUListElement = <HTMLUListElement>document.querySelector("list");
const item: HTMLCollectionOf<HTMLLIElement> = <HTMLCollectionOf<HTMLLIElement>>document.getElementsByTagName("li");

function inputLength(): number {
    return input.value.length;
}

function listLength(): number {
    return item.length;
}

function addItemToList() {
    const li: HTMLLIElement = <HTMLLIElement>document.createElement("li");

    li.appendChild(document.createTextNode(input.value));

    list.appendChild(li);
    input.value = "";

    function crossOut() {
        li.classList.toggle("done");
    }
    li.addEventListener("click", crossOut);

    const deleteButton: HTMLButtonElement = <HTMLButtonElement>document.createElement("button");
    deleteButton.appendChild(document.createTextNode("X"));
    li.appendChild(deleteButton);
    deleteButton.addEventListener("click", deleteListItem);

    function deleteListItem() {
        li.classList.add("delete");
    }

}

function addToListAfterClick() : void{
    if (inputLength() > 0) {
        addItemToList();
    }
}

function addToListAfterKeypress(event: { which: number; }) {
    if (inputLength() > 0 && event.which === 13) {
        addItemToList();
    }
}


addButton.addEventListener("click", addToListAfterClick);

input.addEventListener("keypress", addToListAfterKeypress);
