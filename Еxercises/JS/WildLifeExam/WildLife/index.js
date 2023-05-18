const express = require('express');
const expressConfig = require('./config/express');
const databaseConfig = require('./config/database');
const routesConfig = require('./config/routes');


start();

async function start() {
    const app = express();

    expressConfig(app); 
    await databaseConfig(app);
    routesConfig(app);
    
    // renders the home view
    app.get('/',(req,res) => res.render('home', {layout : false}));
    
    // starting server on port 3001
    app.listen(3001, () =>console.log('Server is listening'));
}