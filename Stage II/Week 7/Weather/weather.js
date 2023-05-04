const buttons = document.querySelectorAll("button");
buttons.forEach((button) => {
  button.addEventListener("click", (event) => {
    getWeatherForcast(button.value);
  });
});

async function getWeatherForcast(forecastLength) {
  let apiString = "https://api.weather.gov/gridpoints/";
  let location = document.getElementById("selectLocation").value;
  apiString = apiString + location + "/forecast";
  console.log(apiString);

  let response = await fetch(apiString);
  let jsonData = await response.json();
  console.log(jsonData);

  document.getElementById("days").innerHTML = "";
  document.getElementById("weather").innerHTML = "";
  document.getElementById("temp").innerHTML = "";

  for (let index = 0; index < forecastLength; index++) {
    document.getElementById("days").innerHTML +=
      jsonData.properties.periods[index].name + "<br><br>";
    document.getElementById("weather").innerHTML +=
      jsonData.properties.periods[index].shortForecast + "<br><br>";
    document.getElementById("temp").innerHTML +=
      jsonData.properties.periods[index].temperature +
      " degrees F" +
      "<br><br>";
  }
}
