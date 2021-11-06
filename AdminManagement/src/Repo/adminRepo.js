const dbConnection = require('./mongoDBConn');
const Sellers = require('../Model/Sellers');

dbConnection();

const _adminRepo = {

  getAllSellers: async () => {
    return Sellers.find();
  }
}

module.exports = _adminRepo;