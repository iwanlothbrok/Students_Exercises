const express = require('express');
const expressConfig = require('./config/express')
 
start();

async function start() {
    const app = express();

    expressConfig(app); 

    // renders the home view
    app.get('/',(req,res) => res.render('home', {layout : false}));
    
    // starting server on port 3001
    app.listen(3001, () => 'Server is listening');
}