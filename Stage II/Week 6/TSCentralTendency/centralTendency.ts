function validateAndAdd(): boolean {
    // Assign inputs
    let newMinimumString: string = (document.getElementById('minimum') as HTMLInputElement).value;
    let newMinimum: number;
    let newMaximumString: string = (document.getElementById('maximum') as HTMLInputElement).value;
    let newMaximum: number;
    let newNumberString: string = (document.getElementById('number') as HTMLInputElement).value;
    let newNumber: number;

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
        alert("Minimum value must be less than maximum")
        return false;
    }

    // validate new number
    if (newNumberString == "") {
        alert("Please enter a number. ")
        return false;
    }
    else
        newNumber = parseInt(newNumberString);

    if ((newNumber < newMinimum) || (newNumber > newMaximum)) {
        alert("Please enter a number between the given range. ");
        (document.getElementById('number') as HTMLInputElement).value = "";
        return false;
    }

    // All numbers valid
    else {
        // Add number to the list 
        const tableRef: HTMLTableElement = (document.getElementById("numberList")!) as HTMLTableElement;
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newNumber.toString();

        let sum: number = 0; // sum of all numbers in the list
        let count = tableRef.rows.length; // number of numbers in the list 

        // Calculate sum 
        for (let aRow = 0; aRow < count; aRow++) {
            sum += parseInt((tableRef.rows[aRow]).innerHTML);
        }

        // Calculate and display the mean
        let theAverage = sum / count;
        let labelRef = document.getElementById("theMean")!;
        labelRef.innerHTML = theAverage.toFixed(3);

        // Calculate and display the median 
        let theNumbers: number[] = [];
        // Add to array
        for (let aRow = 0; aRow < count; aRow++) {
            theNumbers.push(parseInt(tableRef.rows[aRow].innerHTML));
        }
        // sort array
        theNumbers.sort(function (a, b) { return a - b });
        // find middle number
        let theMiddle = Math.trunc(count / 2);
        // if odd number in array middle = median
        if (count % 2 == 1) {
            let newMedian = theNumbers[theMiddle];
            labelRef = document.getElementById("theMedian")!;
            labelRef.innerHTML = newMedian.toFixed(3);
        }

        else {
            let newMedian = (theNumbers[theMiddle - 1] + theNumbers[theMiddle]) / 2;
            labelRef = document.getElementById("theMedian")!;
            labelRef.innerHTML = newMedian.toFixed(3);
        }

        // Calculate and display the mode
        let modes: number[] = [];
        let counts: number[] = [];
        let number: number;
        let maxCount = 0;

        for (let aRow = 0; aRow < theNumbers.length; aRow++) {
            number = theNumbers[aRow];
            counts[number] = (counts[number] || 0) + 1;
            if (counts[number] > maxCount) {
                maxCount = counts[number];
            }
        }

        for (let aRow in counts)
            if (counts.hasOwnProperty(aRow)) {
                if (counts[aRow] === maxCount) {
                    modes.push(Number(aRow));
                }
            }


        labelRef = document.getElementById("theMode")!;
        labelRef.innerHTML = modes.toString();

        (document.getElementById('number') as HTMLInputElement).value = "";

        (document.getElementById('minimum') as HTMLInputElement).disabled = true;
        (document.getElementById('maximum') as HTMLInputElement).disabled = true;

        return true;
    }
}

function clearAll() {
    // clear the table
    let tableRef = document.getElementById("numberList")!;
    tableRef.innerHTML = ' ';

    // clear mean, median, and mode
    const labelRef1 = document.getElementById("theMean")!;
    labelRef1.innerHTML = "--";
    const labelRef2 = document.getElementById("theMedian")!;
    labelRef2.innerHTML = "--";
    const labelRef3 = document.getElementById("theMode")!;
    labelRef3.innerHTML = "--";

    // clear minimum, maximum, and number inputs
    // enable minimum and maximum 
    (document.getElementById('minimum') as HTMLInputElement).value = "";
    (document.getElementById('minimum') as HTMLInputElement).disabled = false;
    (document.getElementById('maximum') as HTMLInputElement).value = "";
    (document.getElementById('maximum') as HTMLInputElement).disabled = false;
    (document.getElementById('number') as HTMLInputElement).value = "";
}