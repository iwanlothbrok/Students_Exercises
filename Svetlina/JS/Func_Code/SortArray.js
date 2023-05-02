function sortArray(arr,condition){

if(condition === 'desc'){
    return arr.sort(function(a, b){return b-a})
}

return arr.sort(function(a, b){return a-b})
}

console.log(sortArray([14, 7, 17, 6, 8], 'asc'));   