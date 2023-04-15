function validateAndAdd() {
    // Assign inputs
    var newMinimumString = document.getElementById('minimum').value;
    var newMinimum;
    var newMaximumString = document.getElementById('maximum').value;
    var newMaximum;
    var newNumberString = document.getElementById('number').value;
    var newNumber;
    // Validate minimum
    if (newMinimumString == "") {
        alert("Please enter a minimum value. ");
        return false;
    }
    else
        newMinimum = parseInt(newMinimumString);
    // validate maximum
    if (newMaximumString == "") {
        alert("Please enter maximum value. ");
        return false;
    }
    else
        newMaximum = parseInt(newMaximumString);
    // validate min < max
    if (newMinimum >= newMaximum) {
        alert("Minimum value must be less than maximum");
        return false;
    }
    // validate new number
    if (newNumberString == "") {
        alert("Please enter a number. ");
        return false;
    }
    else
        newNumber = parseInt(newNumberString);
    if ((newNumber < newMinimum) || (newNumber > newMaximum)) {
        alert("Please enter a number between the given range. ");
        document.getElementById('number').value = "";
        return false;
    }
    // All numbers valid
    else {
        // Add number to the list 
        var tableRef = (document.getElementById("numberList"));
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newNumber.toString();
        var sum = 0; // sum of all numbers in the list
        var count = tableRef.rows.length; // number of numbers in the list 
        // Calculate sum 
        for (var aRow = 0; aRow < count; aRow++) {
            sum += parseInt((tableRef.rows[aRow]).innerHTML);
        }
        // Calculate and display the mean
        var theAverage = sum / count;
        var labelRef = document.getElementById("theMean");
        labelRef.innerHTML = theAverage.toFixed(3);
        // Calculate and display the median 
        var theNumbers = [];
        // Add to array
        for (var aRow = 0; aRow < count; aRow++) {
            theNumbers.push(parseInt(tableRef.rows[aRow].innerHTML));
        }
        // sort array
        theNumbers.sort(function (a, b) { return a - b; });
        // find middle number
        var theMiddle = Math.trunc(count / 2);
        // if odd number in array middle = median
        if (count % 2 == 1) {
            var newMedian = theNumbers[theMiddle];
            labelRef = document.getElementById("theMedian");
            labelRef.innerHTML = newMedian.toFixed(3);
        }
        else {
            var newMedian = (theNumbers[theMiddle - 1] + theNumbers[theMiddle]) / 2;
            labelRef = document.getElementById("theMedian");
            labelRef.innerHTML = newMedian.toFixed(3);
        }
        // Calculate and display the mode
        var modes = [];
        var counts = [];
        var number = void 0;
        var maxCount = 0;
        for (var aRow = 0; aRow < theNumbers.length; aRow++) {
            number = theNumbers[aRow];
            counts[number] = (counts[number] || 0) + 1;
            if (counts[number] > maxCount) {
                maxCount = counts[number];
            }
        }
        for (var aRow in counts)
            if (counts.hasOwnProperty(aRow)) {
                if (counts[aRow] === maxCount) {
                    modes.push(Number(aRow));
                }
            }
        labelRef = document.getElementById("theMode");
        labelRef.innerHTML = modes.toString();
        document.getElementById('number').value = "";
        document.getElementById('minimum').disabled = true;
        document.getElementById('maximum').disabled = true;
        return true;
    }
}
function clearAll() {
    // clear the table
    var tableRef = document.getElementById("numberList");
    tableRef.innerHTML = ' ';
    // clear mean, median, and mode
    var labelRef1 = document.getElementById("theMean");
    labelRef1.innerHTML = "--";
    var labelRef2 = document.getElementById("theMedian");
    labelRef2.innerHTML = "--";
    var labelRef3 = document.getElementById("theMode");
    labelRef3.innerHTML = "--";
    // clear minimum, maximum, and number inputs
    // enable minimum and maximum 
    document.getElementById('minimum').value = "";
    document.getElementById('minimum').disabled = false;
    document.getElementById('maximum').value = "";
    document.getElementById('maximum').disabled = false;
    document.getElementById('number').value = "";
}
