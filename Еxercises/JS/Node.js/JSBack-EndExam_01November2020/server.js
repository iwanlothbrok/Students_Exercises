const express = require('express');
const app = express();

const {PORT} = require('./config/config');
require('./config/mongoose');


app.get('/',(req,res)=>{
    res.send('hello from /')
})

app.listen(PORT, () => console.log(`server is running on ${PORT}... `));
