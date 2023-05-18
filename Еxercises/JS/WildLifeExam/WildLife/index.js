const express = require('express');
const { create: handlebars } = require('express-handlebars');
const session = require('express-session');


start();

async function start() {
    const app = express();


    app.engine('.hbs', handlebars({
        extname: '.hbs',
    }).engine);
    
    // setting to user hbs for views 
    app.set('view engine', '.hbs');

    // using the the express static for the static files
    //using the express.static middleware.
    app.use('/static', express.static('static'));

    // setting the sessions and the cookies
    app.use(session({
        secret:'secret',
        resave: 'false',//Specifies whether the session should be saved even if it's not modified.
        saveUninitialized: true, //  a new session will be created even if no data has been added to it.
        cookie:{
            secure: 'auto' // (HTTPS or HTTP).
        }
    }));    

    app.use(express.urlencoded({extended:true}));

    // renders the home view
    app.get('/',(req,res) => res.render('home', {layout : false}));

    // starting server on port 3001
    app.listen(3001, () => 'Server is listening');
}