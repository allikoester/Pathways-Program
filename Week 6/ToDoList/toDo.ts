const addButton: HTMLButtonElement = <HTMLButtonElement>document.getElementById("addButton");
const input: HTMLInputElement = <HTMLInputElement>document.getElementById("newListItem");
const list: HTMLUListElement = <HTMLUListElement>document.getElementById("list");
const item: HTMLCollectionOf<HTMLLIElement> = <HTMLCollectionOf<HTMLLIElement>>document.getElementsByTagName("li");


function addItemToList() {
    const li: HTMLLIElement = <HTMLLIElement>document.createElement("li");

    li.appendChild(document.createTextNode(input.value));

    list.appendChild(li);
    input.value = "";

}
