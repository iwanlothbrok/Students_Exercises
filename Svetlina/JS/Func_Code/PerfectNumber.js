function perfectNumber(num) {
    let sum = 0;
    for (let i = 1; i < num; i++) {
      if (num % i === 0) {
        sum += i;
      }
    }
    if (sum === num) {
      return "It is a perfect number";
    } else {
      return "It is not a perfect number";
    }
  }

  console.log(perfectNumber(6));