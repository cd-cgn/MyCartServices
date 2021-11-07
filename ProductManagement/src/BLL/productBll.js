const productRepo = require('../Repo/productRepo');

const _productBll = {

  getAllProducts: async () => {

    const productsList = await productRepo.getAllProducts();

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

  addProductToCart: async (prodId, custId) => {

    return await productRepo.addProductToCart(prodId, custId, 1);
  },

  addProductToOrder: async (cartId) => {

    return await productRepo.addProductToOrder(cartId);
  },

  getCartProducts: async (custId) => {

    const productsList = await productRepo.getCartProducts(custId);

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

  getOrdersProducts: async (custId) => {

    const productsList = await productRepo.getOrdersProducts(custId);

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
 
}

module.exports = _productBll;