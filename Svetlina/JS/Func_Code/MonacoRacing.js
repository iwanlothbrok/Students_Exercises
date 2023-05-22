
function distance(km){
    const speed = 187;

    function result(hours){
         return (speed * hours).toFixed(2);
    }

    function minToHours(min) {
        return min / 60;
    }

    return result(minToHours(km));
}

console.log(distance(10));
