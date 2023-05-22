

function specifiedArray(arr, n) {

    const indexes = [];

    for (let index = 0; index < arr.length; index++) {
        for (let j = 0; j < arr.length; j++) {

            let numberToCheck = arr[index] + arr[j];
            if (numberToCheck === n) {
                indexes.push(index);
                indexes.push(j);
                return indexes;
            }
        }
    }
    return [];
}

console.log(specifiedArray([2,3], 15 ));