const uri = 'api/RecipeListRecipes';
let recipeList = [];

function getRecipes() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayRecipes(data))
        .catch(error => console.error('Unable to get recipes.', error));
}

function addRecipe() {
    const addNameTextbox = document.getElementById('add-name');
    const addDescriptionTextbox = document.getElementById('add-description');
    const addNumberOfPeople = document.getElementById('add-people');

    const recipe = {
        isComplete: false,
        name: addNameTextbox.value.trim(),
        description: addDescriptionTextbox.value.trim(),
        people: addNumberOfPeople.value
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(recipe)
    })
        .then(response => response.json())
        .then(() => {
            getRecipes();
            addNameTextbox.value = '';
            addDescriptionTextbox.value = '';
            addNumberOfPeople.value = 0;
        })
        .catch(error => console.error('Unable to add recipe.', error));
}

function deleteRecipe(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getRecipes())
        .catch(error => console.error('Unable to delete recipe.', error));
}

function displayEditForm(id) {
    const recipe = recipeList.find(recipe => recipe.id === id);

    document.getElementById('edit-name').value = recipe.name;
    document.getElementById('edit-description').value = recipe.description;
    document.getElementById('edit-people').value = recipe.people;
    document.getElementById('edit-id').value = recipe.id;
    document.getElementById('edit-isComplete').checked = recipe.isComplete;
    document.getElementById('editForm').style.display = 'block';
}

function updateRecipe() {
    const recipeId = document.getElementById('edit-id').value;

    const recipe = {
        id: parseInt(recipeId, 10),
        isComplete: document.getElementById('edit-isComplete').checked,
        name: document.getElementById('edit-name').value.trim(),
        description: document.getElementById('edit-description').value.trim(),
        people: document.getElementById('edit-people').value
    };

    fetch(`${uri}/${recipeId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(recipe)
    })
        .then(() => getRecipes())
        .catch(error => console.error('Unable to update recipe.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(recipeCount) {
    const name = (recipeCount === 1) ? 'recipe' : 'recipes';

    document.getElementById('counter').innerText = `${recipeCount} ${name}`;
}

function _displayRecipes(data) {
    const tBody = document.getElementById('recipeList');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(recipe => {
        let isCompleteCheckbox = document.createElement('input');
        isCompleteCheckbox.type = 'checkbox';
        isCompleteCheckbox.disabled = true;
        isCompleteCheckbox.checked = recipe.isComplete;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${recipe.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteRecipe(${recipe.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isCompleteCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(recipe.name);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(recipe.description);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(recipe.people);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        let textNode4 = document.createTextNode(recipe.cost);
        td5.appendChild(textNode4);

        let td6 = tr.insertCell(5);
        td6.appendChild(editButton);

        let td7 = tr.insertCell(6);
        td7.appendChild(deleteButton);
    });

    recipeList = data;
}