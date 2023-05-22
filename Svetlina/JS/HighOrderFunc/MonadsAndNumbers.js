function monad(matrix) {
    return matrix.flatMap(function(array) {
      return array.map(function(number) {
        return [Math.pow(number, 2)];
      });
    });
  }

  console.log(monad([[1], [2], [3]]));