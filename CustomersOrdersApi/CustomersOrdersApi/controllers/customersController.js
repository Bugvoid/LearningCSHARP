var customerService = require('../services');

module.exports.start = function (app) {
    app.get("/", function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/html' });
    res.end("<html><body><p> Hello from the application root</p></body></html>");
});


    app.get("/customers", function (req, res) {
        res.send("Luan Castro Alves");


        //customerService.getAllCustomers(function (err, customers) {
        //    if (err) {
        //        res.status(400).send(err);
        //    }
        //    else {
        //        res.set('Content-Type', 'application/json');
        //        res.status(200).send(customers);
        //    }
        //});
    });

    app.get("/customers/:id", function (req, res) {
        var customerId = req.params.id;
        //res.send({ name: "Great Customer with id " + customerId, orders: "none yet" });
        customerService.getCustomerById(customerId, function (err, customer) {
            if (err) {
                res.status(400).send(err);
            } else {
                res.set('Content-Type', 'application/json');
                res.status(200).send(customer);
            };
        });

    });
};

