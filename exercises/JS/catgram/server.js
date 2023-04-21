// importing the express
const express = require('express');

// instance of express
const app = express();

// setting server with this path '/' to respond 
app.get('/',(req,res) => {
console.log('Hello from console');

res.send('Hello world from express!')
})

// setting the server to listen on 5000
app.listen(5000,() => console.log('Server is listening on port 5000'));