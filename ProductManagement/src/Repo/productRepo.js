const dbConnection = require('./mongoDBConn');
const Products = require('../Model/Products.js');
const Carts = require('../Model/Carts.js');
const Orders = require('../Model/Orders.js');

dbConnection();

const _productRepo = {

  getAllProducts: async () => {
    return Products.find();
  },

  addProductToCart: async (custid, prodId, quantity) => {

    const newCart = new Carts({
      customerId: custid,
      productId: prodId,
      quantity: quantity
    });

    await newCart.save();
    return true;
  },

  addProductToOrder: async (cartId) => {

    const cartDoc = await Carts.findOne({_id : cartId});

    const newOrder = new Orders({
      customerId: cartDoc.customerId,
      productId: cartDoc.productId,
      quantity: cartDoc.quantity
    });

    await newOrder.save();
    return true;
  },

  getCartProducts: async (custId) => {
    return Carts.find({customerId: custId});
  },

  getOrdersProducts: async (custId) => {
    console.log(custId)
    return Orders.find({customerId: custId});
  },

}

module.exports = _productRepo;