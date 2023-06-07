// importing the express
const express = require('express');
//importing handlebars
const handlebars = require('handlebars');

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

// configure
app.engine('handlebars', handlebars({ defaultLayout: 'main' }));
app.set('view engine', 'handlebars');

// setting our project to work with handlebars
app.set('view engine','hbs');

// setting server with this path '/' to respond 
app.get('/',(req,res) => {c
// the normal way to render to page
// res.send('Hello world from express!')


// and you have have for example title 
// you could send it like this 
let title = "Hello from hbs";
// the way to render with handlebars
res.render('home', {layout: false}, title);

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