function logSecond(n) {
    if (n < 2) {
      return 0;
    } else {
      return Math.floor(1 + (parseInt(logSecond(Math.floor(n / 2))))).toString();
    }
  }

  console.log(logSecond(10)); // Output: "3"
