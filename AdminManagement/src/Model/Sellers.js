const mongoose = require('mongoose');

const sellersSchema = new mongoose.Schema({
  
  name : {type: String, required: true},
  email: {type: String, required: true},
  approval: {type: String, required: true}

},{timestamps: true});

const Sellers = mongoose.model('Sellers', sellersSchema);

module.exports = Sellers;