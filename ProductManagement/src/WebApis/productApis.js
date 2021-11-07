const express = require('express');
const productBLL = require('../BLL/productBll');

const router = express.Router();

router.get('/user/products', (req, res) => {
  
  const callBLL = async () => {
    const productsList = await productBLL.getAllProducts();
    res.json(productsList);
  }

  callBLL();
});

router.get('/user/cart/:custId', (req, res) => {
  
  const callBLL = async () => {
    const productsList = await productBLL.getCartProducts(req.params.custId);
    res.json(productsList);
  }

  callBLL();
});

router.get('/user/orders/:custId', (req, res) => {
  
  const callBLL = async () => {
    const productsList = await productBLL.getOrdersProducts(req.params.custId);
    res.json(productsList);
  }

  callBLL();
});

router.post('/user/products/:action', (req, res) => {

  console.log(req.params.action, req.query);

  const callBLL = async () => {

    if(req.params.action == 'cart'){
      const isOk = await productBLL.addProductToCart(req.query.prodId, req.query.custId);
      if(isOk) res.status(200).send('success');
    }
    else if(req.params.action == 'order'){
      const isOk = await productBLL.addProductToOrder(req.query.cartId);
      if(isOk) res.status(200).send('success');

    }
    else{
      res.status(404).send('failure');
    }
  }

  callBLL();
});

router.post('/user/Cart', (req, res) => {
  
  const callBLL = async () => {
    const isOk = await productBLL.addProductToCart(req.query.prodId, req.query.custId);
    if(isOk) res.status(200).send('success');
  }

  callBLL();
});


module.exports = router;