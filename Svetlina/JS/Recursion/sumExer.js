function summing(number){

if(number === 0){

return 0;

}else if(number % 2 !== 0){ // checking if its not even 

    return summing(number - 1);

}else{

    return (number + parseInt(summing(number - 2))).toString();

}
}

summing(10);