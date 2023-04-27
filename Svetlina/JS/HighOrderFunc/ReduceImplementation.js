
function reduceImplementation(arr){

return arr.reduce((acc,curr) =>{
    return acc + curr
}, 0);
}

reduceImplementation([1, 2, 3]);