
function validateAndAdd() {
    //Assign inputs
    var newWord = document.forms["myForm"]["word"].value;
    var newNumber = document.forms["myForm"]["number"].value;

    //Validate inputs
    //Validate word. Error message if nothing entered.
    if (newWord == "") {
        alert("Please enter a word to add to list.");
        return false;
    }
    //Validate number. Error message if invalid. 
    else if ((newNumber != 1) && (newNumber != 2)) {
        alert("Please enter either a 1 or 2 to assign to list. ")
        document.forms["myForm"]["number"].value = "";
        return false;
    }
    //Else enteries are valid. Add to list.
    else {
        if (newNumber == 1) {
            var tableRef = document.getElementById("list1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = newWord;
        }
        else {
            var tableRef = document.getElementById("list2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = newWord;
        }
        //Erase form fields
        document.forms["myForm"]["word"].value = "";
        document.forms["myForm"]["number"].value = "";
        return true;
    }
}

function clearList1() {
    var tableRef = document.getElementById("list1");
    tableRef.innerHTML = " ";
}

function clearList2() {
    var tableRef = document.getElementById("list2");
    tableRef.innerHTML = " ";
}