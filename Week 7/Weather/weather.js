async function getWeatherForcast() {
  let apiString = "https://api.weather.gov/gridpoints/";
  let location = document.getElementById("selectLocation").value;
  apiString = apiString + location + "/forecast";
  console.log(apiString);

  let response = await fetch(apiString);
  let jsonData = await response.json();

  for (let index = 0; index < 3; index++) {
    document.getElementById("days").innerHTML +=
      jsonData.properties.periods[index].name + "<br><br>";
    document.getElementById("weather").innerHTML +=
      jsonData.properties.periods[index].shortForecast + "<br><br>";
    document.getElementById("temp").innerHTML +=
      jsonData.properties.periods[index].temperature + "<br><br>";
  }
}
