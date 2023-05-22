

function wrap(r){

    function pi(){
        return Math.PI;
    }


    function area(r){
        return pi() * (r**2);
    }

    return area(r).toFixed(3);
}


console.log(wrap(5));