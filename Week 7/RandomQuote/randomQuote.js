const form = document.querySelector("form");
let quoteSelector = document.getElementById("pickALength");
// let quoteLength = quoteSelector.value;

async function getAQuote() {
  let apiString = "https://api.quotable.io/random?";
  let minLength;
  let maxLength;
  let quoteLength = quoteSelector.options[quoteSelector.selectedIndex].value;

  console.log(quoteLength);
  if (quoteLength == "short") {
    minLength = 0;
    maxLength = 50;
  } else if (quoteLength == "medium") {
    minLength = 50;
    maxLength = 300;
  } else {
    minLength = 300;
    maxLength = 1000;
  }
  apiString = `${apiString}minLength=${minLength}&maxLength=${maxLength}`;
  console.log(apiString);

  let response = await fetch(apiString);

  document.getElementById("quote").innerhtml = "";
  document.getElementById("author").innerhtml = "";

  let jsonData = await response.json();
  console.log(jsonData);

  let quote = JSON.stringify(jsonData.content);
  quote = quote.substring(1, quote.length - 1);
  document.getElementById("quote").innerHTML = quote;

  let author = JSON.stringify(jsonData.author);
  //author = author.substring(1, author.length - 1);
  document.getElementById("author").innerHTML = author;

  return true;
}
