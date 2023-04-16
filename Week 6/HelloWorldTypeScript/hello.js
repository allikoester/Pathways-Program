"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function myFunction() {
    var newName = "";
    newName = document.getElementById("fname").value;
    document.getElementById("greeting").innerHTML = "More Greetings " + newName + " !";
}
