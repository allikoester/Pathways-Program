function validateAndAdd1() {
    // Assign inputs
    var newMinimum = document.forms["submitNumbers"]["minimum"].value;
    var newMaximum = document.forms["submitNumbers"]["maximum"].value;
    var newNumber = document.forms["submitNumbers"]["number"].value;

    // Validate minimum
    if (newMinimum == "") {
        alert("Please enter a minimum value. ");
        return false;
    }

    // validate maximum
    else if (newMaximum == "") {
        alert("Please enter maximum value. ");
        return false;
    }

    // validate min < max
    else if (parseInt(newMinimum) >= parseInt(newMaximum)) {
        alert("Minimum value must be less than maximum")
        return false;
    }

    // validate new number
    else if (newNumber == "") {
        alert("Please enter a number. ")
        return false;
    }
    else if ((parseInt(newNumber) < parseInt(newMinimum)) || (parseInt(newNumber) > (parseInt(newMaximum)))) {
        alert("Please enter a number between the given range. ");
        document.forms["submitNumbers"]["number"].value = "";
        return false;
    }

    // All numbers valid
    else {
        // Add number to the list 
        var tableRef = document.getElementById("numberList");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newNumber;

        var sum = 0; // sum of all numbers in the list
        var count = tableRef.rows.length; // number of numbers in the list 

        // Calculate sum 
        for (aRow = 0; aRow < count; aRow++) {
            sum += parseInt((tableRef.rows[aRow]).innerHTML);
        }

        // Calculate and display the mean
        var theAverage = sum / count;
        var labelRef1 = document.getElementById("theMean");
        labelRef1.innerHTML = theAverage.toFixed(3);

        // Calculate and display the median 
        var theNumbers = [];
        // Add to array
        for (aRow = 0; aRow < count; aRow++) {
            theNumbers.push(parseInt((tableRef.rows[aRow]).innerHTML));
        }
        // sort array
        theNumbers.sort(function (a, b) { return a - b });
        // find middle number
        var theMiddle = Math.trunc(count / 2);
        // if odd number in array middle = median
        if (count % 2 == 1) {
            var newMedian = theNumbers[theMiddle];
            var labelRef1 = document.getElementById("theMedian");
            labelRef1.innerHTML = newMedian.toFixed(3);
        }

        else {
            var newMedian = (theNumbers[theMiddle - 1] + theNumbers[theMiddle]) / 2;
            var labelRef1 = document.getElementById("theMedian");
            labelRef1.innerHTML = newMedian.toFixed(3);
        }

        // Calculate and display the mode
        var modes = [];
        var count = [];
        var number;
        var maxCount = 0;

        for (aRow = 0; aRow < theNumbers.length; aRow++) {
            number = theNumbers[aRow];
            count[number] = (count[number] || 0) + 1;
            if (count[number] > maxCount) {
                maxCount = count[number];
            }
        }

        for (aRow in count)
            if (count.hasOwnProperty(aRow)) {
                if (count[aRow] === maxCount) {
                    modes.push(Number(aRow));
                }
            }


        var labelRef1 = document.getElementById("theMode");
        labelRef1.innerHTML = modes;

        document.forms["submitNumbers"]["number"].value = "";

        document.forms["submitNumbers"]["minimum"].disabled = true;
        document.forms["submitNumbers"]["maximum"].disabled = true;

        return true;
    }
}

function clearAll1() {
    // clear the table
    var tableRef = document.getElementById("numberList");
    tableRef.innerHTML = "";

    // clear mean, median, and mode
    var labelRef1 = document.getElementById("theMean");
    labelRef1.innerHTML = "--";
    var labelRef2 = document.getElementById("theMedian");
    labelRef2.innerHTML = "--";
    var labelRef3 = document.getElementById("theMode");
    labelRef3.innerHTML = "--";

    // clear minimum, maximum, and number inputs
    // enable minimum and maximum 
    document.forms["submitNumbers"]["minimum"].value = "";
    document.forms["submitNumbers"]["minimum"].disabled = false;
    document.forms["submitNumbers"]["maximum"].value = "";
    document.forms["submitNumbers"]["maximum"].disabled = false;
    document.forms["submitNumbers"]["number"].value = "";
}