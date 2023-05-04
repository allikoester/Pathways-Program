var url = "http://mylogger.io/log";

function log(message) {
  console.log(message);
}

module.exports.log = log; // to make this available outside of this file
