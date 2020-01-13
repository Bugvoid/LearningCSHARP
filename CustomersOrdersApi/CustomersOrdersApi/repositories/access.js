var mongoDb = require('mongodb').MongoClient;
var connectionString = 'mongodb://localhost:27017/customers';
var database = null;

module.exports.getDbHandle = function (next) {
    if (!database) {
        mongoDb.connect(connectionString, { useNewUrlParser: true, useUnifiedTopology: true }, function (err, db) {
            if (err) {
                console.log(err);
                next(err, null);
            } else {
                database = db;
                next(err, database);
            }
        });
    } else {
        next(null, database);
    }
};

