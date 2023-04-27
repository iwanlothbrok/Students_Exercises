

function filterImplementation(arr){
    
const filteredArray = arr.filter(word => word.length % 2 ===0);

return filteredArray;
}

filterImplementation(['Madrid', 'Smolyan', 'Rome']);