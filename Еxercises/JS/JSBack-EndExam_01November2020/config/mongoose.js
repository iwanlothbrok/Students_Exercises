const mongoose = require('mongoose');
const {DB_URI} = require('./config')

    mongoose.connect(DB_URI,{userNewUrlParser: true, useUnifiedTopology: true});

    const db = mongoose.connect;