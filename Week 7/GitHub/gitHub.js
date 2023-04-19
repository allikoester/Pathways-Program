async function getRepos() {
  // build API call string
  let apiString = "https://api.github.com/users";
  let userName = document.getElementById("userNameInput").value;
  apiString = `${apiString}/${userName}/repos`;
  console.log(apiString);

  //make the call
  let response = await fetch(apiString);
  let repos = "";

  //If call goes through / is valid
  if (response.status >= 200 && response.status <= 299) {
    let jsonData = await response.json();

    for (let aRepo in jsonData) {
      repos +=
        "<p><a href=" +
        jsonData[aRepo].html_url +
        ">" +
        jsonData[aRepo].name +
        "</a></p>";
    }
  }
  //else error
  else {
    repos = `<p>Error. Cannot access. Status: ${response.status}.`;
  }

  //display data
  document.getElementById("userName").innerHTML = `Repo List for ${userName}:`;
  document.getElementById("repoList").innerHTML = repos;
  document.getElementById("userNameInput").value = "";
}
