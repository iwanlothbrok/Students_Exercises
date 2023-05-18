
const mongoose = require('mongoose');
require('../models/User')


const dbName = 'wildlife'
const connectionString = `mongodb://localhost:27017/${dbName}`;

module.exports = async (app) => {
    try{
        await mongoose.connect(connectionString, {
            useNewUrlParser: true,
            useUnifiedTopology: true
        });


        mongoose.connection.on('error',(err) => {
            console.log('Database error');
        })
        
    } catch(err){
        console.log('Error connection to database');
        process.exit(1);
    }
}