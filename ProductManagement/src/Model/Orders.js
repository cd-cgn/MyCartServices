const mongoose = require('mongoose');

const ordersSchema = new mongoose.Schema({

  customerId: {type: String, required: true},
  productId : {type: String, required: true},
  quantity: {type: Number, required: true}

},{timestamps: true});

const Orders = mongoose.model('Orders', ordersSchema);

module.exports = Orders;