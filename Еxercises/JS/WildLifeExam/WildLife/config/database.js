const mongoose = require('mongoose');
const User = require('../models/User');

const dbName = 'wildlife';
// how the db server should look 
const connectionString = `mongodb://127.0.0.1:27017/${dbName}`;

module.exports = async () => {
  try {
    await mongoose.connect(connectionString, {
      useNewUrlParser: true,
      useUnifiedTopology: true,
    });

    console.log('Connected to database');

    mongoose.connection.on('error', (err) => {
      console.log('Database error:', err);
    });

  } catch (err) {
    console.log('Error connecting to database:', err);
    process.exit(1);
  }
};
