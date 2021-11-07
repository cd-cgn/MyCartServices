const express = require('express');

const app = express();

//    Body Parser Middleware, required for handling post request body
app.use(express.json());
app.use(express.urlencoded({ extended : false }));


//    Include Web Apis
app.use('/', require('./src/WebApis/productApis'));


//    Launch Web Server
const PORT = process.env.PORT || 7000;
app.listen(PORT, () => { console.log(`Now Listening on port ${PORT}`)});