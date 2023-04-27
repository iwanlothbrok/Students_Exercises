function duplicatedArray(arr) {
  let result = [];
  let duplicates = {};

  for (let i = 0; i < arr.length; i++) {
    if (duplicates[arr[i]] === undefined) {
      duplicates[arr[i]] = 1;
    } else {
      duplicates[arr[i]]++;
    }
  }

  for (let key in duplicates) {
    if (duplicates[key] > 1) {
      result.push(parseInt(key));
    }
  }

  return result;
}

  
const arr = [1, 2, -2, 4, 5, 4, 7, 8, 7, 7, 71, 3, 6];
const duplicates = duplicatedArray(arr);
console.log(duplicates); // Output: [4, 7]