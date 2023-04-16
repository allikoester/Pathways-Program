type Task = {
    title: string,
    completed: boolean
}

const list = document.querySelector<HTMLUListElement>("#list");
const form = document.getElementById("newTaskForm") as HTMLFormElement | null;
const input = document.querySelector<HTMLInputElement>("#newTaskTitle");

form?.addEventListener("submit", e => {
    e.preventDefault()

    if (input?.value == "" || input?.value == null)
        return

    const newTask: Task = {
        title: input.value,
        completed: false
    }

})

function putItemOnList(task: Task) {
    const item = document.createElement("li");
    const label = document.createElement("label");
    const checkbox = document.createElement("input");
    checkbox.addEventListener("change", () => {
        task.completed = checkbox.checked
    })
    checkbox.type = "checkbox";
    checkbox.checked = task.completed;
    label.append(checkbox, task.title);
    item.append(label);
    list?.append(item);
}