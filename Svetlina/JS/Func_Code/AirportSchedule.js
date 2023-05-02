
function airportSchedule(input){

function timeSpan(curr,planeTime){ 

   return (planeTime.getTime() - curr.getTime()) / (1000 * 60); // get time difference in minutes

}

const [currHours, currMinutes] = input[0].split(':');
const currentTime = new Date(); 
currentTime.setHours(currHours);
currentTime.setMinutes(currMinutes);

let airplaneName = input[1];

const [hours, minutes] = input[2].split(':');
const airplaneTime = new Date(); 
airplaneTime.setHours(hours);
airplaneTime.setMinutes(minutes);

let timeDifference = timeSpan(currentTime,airplaneTime);

if (timeDifference > 120) {
    return [];
  } else if (timeDifference > 30) {
    const formattedTime = Math.floor(timeDifference / 60) + ':' + ('0' + Math.floor(timeDifference % 60)).slice(-2);
    return `The ${airplaneName} flight takes off in ${formattedTime} hours`; 
  } else {
    return `Last call for flight ${airplaneName}`; 
  }
}


console.log(airportSchedule(['14:18', 'Sofia - Milano', '15:35']));
// [currentTime, airplaneName, airplaneTime]
// If there are more than 2 hours until passagers flight, you shoudn't print anything. 
// Else if there are more than 30 minutes but less than 2 hours, print "The {airplaneName} flight takes off in {airplaneTime - currentTime} minutes". 
// Else, if there are less than 30 minutes print "Last call for flight {airplaneName}".
// Input values of currentTime and airplaneTime are in format {hours:minutes}.
// Write your solution in an airportSchedule() function.
// Input
// You will receive an array in the following format:
// [currentTime, airplaneName, airplaneTime]
// Output
// Your wrapper airportSchedule() function should return:
// •	If there are more than 2 hours until passagers flight, return empty array ([])
// •	If there are more than 30 minutes but less than 2 hours, print:
// "The {airplaneName} flight takes off in {airplaneTime - currentTime} minutes"
// •	If there are less than 30 minutes print:
// "Last call for flight {airplaneName}".
// Use only pure and first-class functions!
