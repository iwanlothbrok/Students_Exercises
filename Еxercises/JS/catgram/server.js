// importing the express
const express = require('express');

// instance of express
const app = express();

// we are showing in url /static/something 
// everything from foulder public
// static == public
app.use('/static', express.static('public'));

// we are sayomg that everything in public is accsessable 
// and you can accsess it with this url 
// localhost:your html file name 
app.use(express.static('public'));


// setting server with this path '/' to respond 
app.get('/',(req,res) => {
console.log('Hello from console');

res.send('Hello world from express!')
})
// reouting with params 
app.get('/cats/:id',(req,res) => {

    // regex validator 
    if(/\d+/.test(req.params.id)){

    }

    res.send('Hello world from express!')
    })


    // downloading file
app.get('/anything',(req,res) => {
    // __dirname + the path
    // we are getting the current path
    res.download('give the path of the file')
    })

     // redirect
app.get('/anything',(req,res) => {
    res.redirect('path of the redirect')
    })
// setting the server to listen on 5000
app.listen(5000,() => console.log('Server is listening on port 5000'));