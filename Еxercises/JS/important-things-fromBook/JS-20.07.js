

//-- HOW TO CHANGE SPACE WITH '-' AND REMOVE EVERY SPACE IF YOU WANT 01
const string = "Restaurants in Hanalei";
// with regex
//const urlFriendly = string.replace(/ /g, "_");
const urlFriendly = string.replaceAll(' ', "_");

//console.log(urlFriendly);


//-- CREATING A NEW INSTANCE OF A OBJECT TO NOT MUTATE THE CURRENT INFORMATION ABOUT IT 02

let color_lawn = {
    title: "lawn",
    color: "#00FF00",
    rating: 0
};

const rateColor = function (color, rating) {
    return Object.assign({}, color, { rating: rating });
};
//console.log(rateColor(color_lawn, 5).rating); // 5
//console.log(color_lawn); // 0 IT IS WITH THE OLDER DATA AND NOTHING WAS CHANGED

//-- HOW TO NOT MUTATE ARRAY 03

let list = [{ title: "Rad Red" }, { title: "Lawn" }, { title: "Party Pink" }];

const addColor = (title, list) => [...list, { title }]; // WHEN YOU USE THE CURRENT FUNCTION YOU ARE ADDING

//console.log(addColor("Glam Green", list).length); // 4
//console.log(list.length); // 3


//-- HOW TO NOT MUTATE OBJECT 04

const frederick = {
    name: "Frederick Douglass",
    canRead: false,
    canWrite: false
   };
   const selfEducate = person => ({
    ...person,
    canRead: true,
    canWrite: true
   });
   console.log(selfEducate(frederick));
   // even after the function nothing was changed
   console.log(frederick);


   //-- H