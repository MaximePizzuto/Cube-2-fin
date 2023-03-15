const express = require('express');
const app = express();
const port = 8000;
const hostname = "192.168.43.171";

app.use(express.static('./src/acc'))


// Démarre le serveur à l'adresse 127.0.0.1 sur le port 8000
// Affiche un message dès que le serveur commence à écouter les requêtes
app.listen(port, hostname, () => {
  console.log(`Le serveur tourne à l'adresse http://${hostname}:${port}/`);
})
