function decimalToBinary(num) {
    if (num <= 1) {
      return num.toString();
    }
    
    return decimalToBinary(Math.floor(num / 2)) + (num % 2).toString();
  }

  decimalToBinary(15);