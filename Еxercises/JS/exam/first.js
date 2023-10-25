export function rounds_won( results ) {

    let firstWinner = 0;
    let secondWinner = 0;
   for (var i = 0; i < results.length; i++){
       if(results[i] === '1'){
           firstWinner++;
       }else{
           secondWinner++;
       }
   }
   console.log(firstWinner > secondWinner ? firstWinner : secondWinner);
}


rounds_won([1,2,1,2,1])