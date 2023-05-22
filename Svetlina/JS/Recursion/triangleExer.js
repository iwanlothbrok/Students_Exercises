
function invertedTriangle(n){
    
    if(n === 0){
        return " ";
    }

    console.log("*".repeat(n));
    return invertedTriangle(n-1);
}

invertedTriangle(5);