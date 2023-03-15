const http = require('http');
const app = require('./app');

//Création du port pour le serveur web
app.set('port', process.env.PORT || 3080);
const server = http.createServer(app);
server.listen(process.env.PORT || 3080);