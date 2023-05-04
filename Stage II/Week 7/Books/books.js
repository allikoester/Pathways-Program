async function getAuthorInfo() {
  let apiString = "https://openlibrary.org/authors/";
  let author = document.getElementById("authors").value;
  apiString = `${apiString}${author}.json`;
  console.log(apiString);

  let response = await fetch(apiString);
  let jsonData = await response.json();

  console.log(jsonData);

  document.getElementById("bio").innerHTML = "";
  document.getElementById("birthdate").innerHTML = "";
  document.getElementById("moreInfo").innerHTML = "";

  let bio = JSON.stringify(jsonData.bio);
  bio = bio.substring(1, bio.length - 1);
  document.getElementById("bio").innerHTML = bio;

  let birthdate = JSON.stringify(jsonData.birth_date);
  birthdate = birthdate.substring(1, birthdate.length - 1);
  document.getElementById("birthdate").innerHTML = birthdate;

  let moreInfo = JSON.stringify(jsonData.wikipedia);
  moreInfo = moreInfo.substring(1, moreInfo.length - 1);
  document.getElementById(
    "moreInfo"
  ).innerHTML = `<p> <a href="${moreInfo}" target="_blank">${jsonData.name}</a></p>`;
}
