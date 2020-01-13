var databaseAccess = require('./access');

module.exports.getAll = function () {
    databaseAccess.getDbHandle(function (err, db) {
        if (err) {
            next(err, null);
        } else {
            db.colletion("customers").find().toArray(function (err, res) {
                if (err) {
                    next(err, null);
                } else {
                    next(null, res)
                }
            });
        }
    });
    //return { name: "Great Customer", orders: "none yet" };
};
module.exports.getById = function (customerId) {
    databaseAccess.getDbHandle(function (err, db) {
        if (err) {
            next(err, null);
        } else {
            var mongoDb = require('mongodb');
            var BSON = mongoDb.BSONPure;
            var objectId = new BSON.ObjectId(customerId);

            db.colletion("customers").find({ '_id': objectId }).toArray(function (err, res) {
                if (err) {
                    next(err, null);
                } else {
                    next(null, res);
                }
            });
        }
    });
    //return { name: "Great Customer with id " + customerId, orders: "none yet" };
};
