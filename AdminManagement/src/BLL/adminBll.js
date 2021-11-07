const adminRepo = require('../Repo/adminRepo');

const _adminBll = {

  getAllSellers: async () => {

    const sellerList = await adminRepo.getAllSellers();

    let resList = []; let obj = {};

    sellerList.forEach((ele) => {
      obj =  { 
        id: ele._doc._id.valueOf(),
        ...ele._doc
      };
      delete obj._id
      resList.push( obj);
    });
    
    return resList;
  },

  updateSellers: async (id, action) => {

    return await adminRepo.updateSellers(id, action);
  },

  getAllCustomers: async () => {

    const sellerList = await adminRepo.getAllCustomers();

    let resList = []; let obj = {};

    sellerList.forEach((ele) => {
      obj =  { 
        id: ele._doc._id.valueOf(),
        ...ele._doc
      };
      delete obj._id
      resList.push( obj);
    });
    
    return resList;
  },

  getSellerProducts: async (sellerId) => {

    const productsList = await adminRepo.getSellerProducts(sellerId);

    let resList = []; let obj = {};

    productsList.forEach((ele) => {
      obj =  { 
        id: ele._doc._id.valueOf(),
        ...ele._doc
      };
      delete obj._id
      resList.push( obj);
    });
    
    return resList;
  },

  updateProducts: async (_prod) => {

    return await adminRepo.updateProducts(_prod);
  },

}

module.exports = _adminBll;