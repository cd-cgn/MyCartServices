const mongoose = require('mongoose');

const productsSchema = new mongoose.Schema({
  
  name : {type: String, required: true},
  quantity: {type: Number, required: true},
  price: {type: Number, required: true},
  sellerId: {type: String, required: true}

},{timestamps: true});

const Products = mongoose.model('Products', productsSchema);

module.exports = Products;