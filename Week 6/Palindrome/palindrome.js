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
    //Else enteries are valid. Check is palindrome and add to list.
    else {
        if (newNumber == 1) {

            list1Palindrome(newWord);
        }
        else {
            list2Palindrome(newWord);
        }
        //Erase form fields
        document.forms["myForm"]["word"].value = "";
        document.forms["myForm"]["number"].value = "";
        return true;
    }
}

function list1Palindrome(string) {
    let j = string.length - 1;
    for (let i = 0; i < j / 2; i++) {
        let x = string[i];
        let y = string[j - i];
        if (x == y) {
            var tableRef = document.getElementById("list1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = string + " is a palindrome.";
        }
        else {
            var tableRef = document.getElementById("list1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = string + " is NOI a palindrome.";
        }
    }
}

function list2Palindrome(string) {
    let reverseString = "";
    for (let i = string.length - 1; i >= 0; i--) {
        reverseString += string[i];
    }
    if (reverseString == string) {
        var tableRef = document.getElementById("list2");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = string + " is a palindrome.";
    }
    else {
        var tableRef = document.getElementById("list2");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = string + " is NOT a palindrome.";
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