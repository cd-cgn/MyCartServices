const dbConnection = require('./mongoDBConn');
const Sellers = require('../Model/Sellers');
const Customers = require('../Model/Customers.js');
const Products = require('../Model/Products.js');

dbConnection();

const _adminRepo = {

  getAllSellers: async () => {

    return Sellers.find();
  },

  updateSellers: async (id, action) => {

    if(action === 'Approved'){
      await Sellers.findOneAndUpdate({ _id: id}, {approval: action});
      return true;
    }
    else if(action === 'Delete'){
      await Sellers.findOneAndDelete( { _id : id } );
      return true;
    }
    else{
      return false;
    }
  },

  getAllCustomers: async () => {
    
    return Customers.find();
  },

  getSellerProducts: async (sellerId) => {
    if (sellerId == -1) return Products.find();
    else return Products.find({sellerId: sellerId});
  },

  updateProducts: async (_prod) => {

    const newProd = new Products({
      name: _prod.name,
      quantity: _prod.quantity,
      price: _prod.price,
      sellerId: _prod.sellerId
    });

    await newProd.save();
    return true;
  },
}

module.exports = _adminRepo;