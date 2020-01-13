var customersController = require('./customersController');

module.exports.start = function (app) {
    customersController.start(app);
};