const express = require('express');
const app = express();

const {PORT} = require('./config/config');
//require('./config/mongoose')(app);



app.get('/',(req,res)=>{
})


app.listen(PORT, () => console.log(`server is running on ${PORT}... `));
