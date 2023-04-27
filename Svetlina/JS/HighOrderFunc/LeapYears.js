
//(year % 4 === 0 && year % 100 !== 0) || year % 400 === 0)

function leapYears(arr){
return arr.filter((year => year % 4 === 0 && year % 100 !== 0) || year % 400 === 0);
}

leapYears([2012, 2004, 2003]);