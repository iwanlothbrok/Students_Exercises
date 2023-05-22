


function bubbleSort(arr){

for (let i = 0; i < arr.length; i++) {
for (let j = 1; j < arr.length - i; j++) {

        if(arr[j-1] > arr[j]){
            let temp = arr[j - 1];

            arr[j - 1] = arr[j];
            arr[j] = temp;
        }
    }    
}

return arr;
}

console.log(bubbleSort([5, 2, 3]));