const mongoose = require('mongoose');

const mongoDBConn = () => {

  console.log(`Starting Mongo DB Connection : `);

  const dbURI = 'mongodb://localhost:27017/MyCart';

  mongoose.connect(dbURI)
    .then(() => { console.log(`Success!`)})
    .catch((err) => console.log(`Failed with Error: ${err.message}`));
}

module.exports = mongoDBConn;