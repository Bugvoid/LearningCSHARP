'use strict';
var http = require('http');
var express = require('express');
var controller = require('./controllers');
var app = express();


//var exampleModule = require('./modules/module_example.js');
//var customerController = require('./')
//var ret = exampleModule();

controller.start(app);

var port = process.env.PORT || 1337;
http.createServer(app).listen(port)



//// Observe que estamos enviando HTML de volta, enquanto as APIs RESTful normalmente respondem com JSON.
//// Vamos ver como podemos responder com o Json.Insira o seguinte código após o método get mostrado acima:
////app.get("/customers", function (req, res) {
////    res.whiteHead(200, { 'Content-Type': 'application/json' });
////    res.end('{name: "Great customer", orders: "none yet"}');
////});

//app.get("/customers", function (req, res) {
//    res.set('Content-Type', 'application/json');
//    res.send({ name: "Great Customer", orders: "nome yet" });
//});




