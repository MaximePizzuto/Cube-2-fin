const express = require('express');
const app = express();
const path = require ('path');


//Fonction qui affiche la page principale 
app.use(express.static(path.join(__dirname, "views")));
//Fonction qui affiche les images et le CSS sur toutes les pages
app.use(express.static(path.join(__dirname, "public")));
//Méthode get pour afficher la deuxième page
app.get('/page', function(req, res) {
  res.sendFile(path.join(__dirname, '/page.html'));
});
//Méthode get pour afficher la troisième page
app.get('/graphique', function(req, res) {
  res.sendFile(path.join(__dirname, '/graphique.html'));
});


module.exports = app;