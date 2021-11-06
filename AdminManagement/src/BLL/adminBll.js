const adminRepo = require('../Repo/adminRepo');

const _adminBll = {

  getAllSellers: async () => {
    
    return await adminRepo.getAllSellers();
  }
}

module.exports = _adminBll;