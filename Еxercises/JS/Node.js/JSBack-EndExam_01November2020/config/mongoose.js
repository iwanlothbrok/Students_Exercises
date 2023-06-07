const mongoose = require('mongoose');
const { DB_URI } = require('./config')

mongoose.connect(DB_URI, { userNewUrlParser: true, useUnifiedTopology: true });

const db = mongoose.connection;

db.on('error', console.error.bind(console, 'connecting error:'));

db.once('open', function () {
    console.log('DB is connected');
})


