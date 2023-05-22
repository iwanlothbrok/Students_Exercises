function lcm([a, b]) {
    function gcd(x, y) {
      if (y === 0) {
        return x;
      } else {
        return gcd(y, x % y);
      }
    }
  
    function lcmHelper(x, y) {
      if (x === 0 || y === 0) {
        return 0;
      } else {
        const gcdValue = gcd(x, y);
        return (x * y) / gcdValue;
      }
    }
  
    return lcmHelper(a, b).toString();
  }
  

  console.log(lcm([20,4]));