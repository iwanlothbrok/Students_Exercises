function fibonacci(n, a = 0, b = 1) {
    if (n === 0) {
      return a;
    } else if (n < 0) {
      return fibonacci(n + 1, b - a, a);
    } else {
      return fibonacci(n - 1, b, a + b);
    }
  }
  
  
  console.log(fibonacci(-21));