const mongoose = require('mongoose');

const cartsSchema = new mongoose.Schema({

  customerId: {type: String, required: true},
  productId : {type: String, required: true},
  quantity: {type: Number, required: true}

},{timestamps: true});

const Carts = mongoose.model('Carts', cartsSchema);

module.exports = Carts;