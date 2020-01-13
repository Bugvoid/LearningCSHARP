var customerRepository = require('../repositories/customerRepository')

module.exports.getAllCustomers = function () {
    customerRepository.getAll(function (err, res) {
        if (err) {
            next(err, null);
        } else {
            next(null, res);
        }
    });
    //return customerRepository.getAll();
};

module.exports.getCustomerById = function (customerId) {
    customerRepository.getById(customerId, function (err, res) {
        if (err) {
            next(err, null);
        } else {
            next(null, res);
        }
    });
    //return customerRepository.getById(customerId);
};
