const mongoose = require('mongoose');

const customersSchema = new mongoose.Schema({
  
  name : {type: String, required: true},
  email: {type: String, required: true}

},{timestamps: true});

const Customers = mongoose.model('Customers', customersSchema);

module.exports = Customers;