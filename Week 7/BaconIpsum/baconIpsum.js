async function getBaconipsum() {
  // first build the API call string by starting with the URL ----
  // LINES 2 - 7 create end point. Method, headers, and data not needed
  let apiString = "https://baconipsum.com/api/";
  // next add the parameters to the string using the drop down lists
  let theNewParagraphs = document.getElementById("newParagraphs").value;
  let theNewType = document.getElementById("newType").value;

  apiString = `${apiString}?type=${theNewType}&paras=${theNewParagraphs}`;
  alert(apiString); // show the API string

  // now make the API call to the web service using the string and store what is returned in response
  let response = await fetch(apiString);
  // have to use await
  //fectch(apiString) makes the call and have to await response
  // reponse is the RAW JSON response

  // finally, print the response in the various formats
  document.getElementById("myRawData").innerHTML = ""; // clear what was previously shown
  document.getElementById("myFormattedData").innerHTML = ""; // clear what was previously shown

  let jsonData = await response.json(); // read the response as JSON
  // put in JSON object
  // can do await to wait until fully converted

  // stringify and print out the JSON object in the RawData section
  document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
  // stringigy --> taks JSON object and converts to string to be able to put in HTML

  // loop through the JSON object one paragraph at a time and print each in the FormattedData section
  for (let para in jsonData) {
    document.getElementById("myFormattedData").innerHTML +=
      "<p>" + jsonData[para] + "</p>";
  }

  return true;
}
