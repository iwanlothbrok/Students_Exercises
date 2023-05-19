
// EXPRESS CONFIGURATION
const express = require('express');
const { create: handlebars } = require('express-handlebars');
const session = require('express-session');
const userSession = require('../middleware/userSession');

module.exports = (app) => {
     
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

    app.use(userSession());
} 