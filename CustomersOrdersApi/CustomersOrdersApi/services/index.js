var customerService = require('./customerService');

module.exports.getAllCustomers = function (next) {
    customerService.getAllCustomers(function (err, res) {
        if (err) {
           next(err, null);
        }
        else {
            next(null, res);
        }
    });
    // next(null, customerService.getAllCustomers());
};

module.exports.getCustomerById = function (id, next) {
    customerService.getCustomerById(id, function (err, res) {
        if (err) {
            next(err, null);
        }
        else {
            next(null, res);
        }
    });

    //next(null, customerService.getCustomerById(id));
}
