const express = require('express');
const adminBLL = require('../BLL/adminBll');

const router = express.Router();

router.get('/sellers', (req, res) => {
  
  const callBLL = async () => {
    const sellersList = await adminBLL.getAllSellers();
    res.json(sellersList);
  }

  callBLL();

  //res.json({say: "Hi"});
});

router.post('/sellers', (req, res) => {

});

module.exports = router;