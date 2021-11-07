const express = require('express');
const adminBLL = require('../BLL/adminBll');

const router = express.Router();

router.get('/sellers', (req, res) => {
  
  const callBLL = async () => {
    const sellersList = await adminBLL.getAllSellers();
    res.json(sellersList);
  }

  callBLL();
});

router.post('/sellers', (req, res) => {

  const callBLL = async () => {
    const isOk = await adminBLL.updateSellers(req.body.id, req.body.action);
    if(isOk) res.status(200).send('success');
  }

  callBLL();
});

router.get('/customers', (req, res) => {
  
  const callBLL = async () => {
    const customersList = await adminBLL.getAllCustomers();
    res.json(customersList);
  }

  callBLL();
});

router.get('/products/:sellerId', (req, res) => {

  const callBLL = async () => {
    const productsList = await adminBLL.getSellerProducts(req.params.sellerId);
    res.json(productsList);
  }

  callBLL();
});

router.post('/products', (req, res) => {

  const callBLL = async () => {
    const isOk = await adminBLL.updateProducts(req.body);
    if(isOk) res.status(200).send('success');
  }
  
  callBLL();
});


module.exports = router;