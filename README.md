# Cube-2-Projet-Raspberry

*Etapes pour mise en place raspberry*

*Schéma de montage*

![image](https://user-images.githubusercontent.com/112614700/224771992-39abd109-a997-4a36-87b3-9d8b925f7781.png)

![image](https://user-images.githubusercontent.com/112614700/224772718-27626bc3-ecd6-4f22-829c-7894d6a10fee.png)

*---- 1er code de test des led's : ----

import machine
import utime
led1 = machine.Pin(2, machine.Pin.OUT)
led2 = machine.Pin(3, machine.Pin.OUT)
led3 = machine.Pin(4, machine.Pin.OUT)
led4 = machine.Pin(5, machine.Pin.OUT)
led5 = machine.Pin(6, machine.Pin.OUT)
led6 = machine.Pin(7, machine.Pin.OUT)
led7 = machine.Pin(8, machine.Pin.OUT)
led8 = machine.Pin(9, machine.Pin.OUT)
led9 = machine.Pin(10, machine.Pin.OUT)
led10= machine.Pin(11, machine.Pin.OUT)
#Botones
b1 = machine.Pin(16, machine.Pin.IN, machine.Pin.PULL_DOWN)
b2 = machine.Pin(17, machine.Pin.IN, machine.Pin.PULL_DOWN)
b3 = machine.Pin(18, machine.Pin.IN, machine.Pin.PULL_DOWN)
b4 = machine.Pin(19, machine.Pin.IN, machine.Pin.PULL_DOWN)
def led_sequence (a,b,c,d,e,f,g,h,i,j):
    led1.value(a)
    led2.value(b)
    led3.value(c)
    led4.value(d)
    led5.value(e)
    led6.value(f)
    led7.value(g)
    led8.value(h)
    led9.value(i)
    led10.value(j)

while True:
    if b1.value() == 1:
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(1,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(1,1,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,1,1,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,1,1,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,1,1,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,1,1,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,1,1,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,1,1,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,1,1,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,1,1)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.5)
        led_sequence(0,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,1,1)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,1,1,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,1,1,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,1,1,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,1,1,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,1,1,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,1,1,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,1,1,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(1,1,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(1,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.5)
        
    if b2.value() == 1:
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,1,1,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,1,1,1,1,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,1,1,0,0,1,1,0,0)
        utime.sleep(0.03)
        led_sequence(0,1,1,0,0,0,0,1,1,0)
        utime.sleep(0.03)
        led_sequence(1,1,0,0,0,0,0,0,1,1)
        utime.sleep(0.03)
        led_sequence(1,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.03)
        led_sequence(1,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.5)
        led_sequence(1,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.03)
        led_sequence(1,1,0,0,0,0,0,0,1,1)
        utime.sleep(0.03)
        led_sequence(0,1,1,0,0,0,0,1,1,0)
        utime.sleep(0.03)
        led_sequence(0,0,1,1,0,0,1,1,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,1,1,1,1,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,1,1,0,0,0,0)
        utime.sleep(0.03)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.5)
        
    if b3.value() == 1:
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,1,1,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,1,1,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,1,1,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,1,1,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,1,1,0,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,1,1,0,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,1,1,0)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
    if b4.value() == 1:
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,0,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,0,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,0,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,0,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,1,0,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,1,1,0,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,1,1,1,0,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,1,1,1,1,0)
        utime.sleep(0.02)
        led_sequence(1,1,1,1,1,1,1,1,1,1)
        utime.sleep(1)
        led_sequence(0,1,1,1,1,1,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,1,1,1,1,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,1,1,1,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,1,1,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,1,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,1,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,1,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,1,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,0,1)
        utime.sleep(0.02)
        led_sequence(0,0,0,0,0,0,0,0,0,0)
        utime.sleep(0.5)
*---- ======================================== ----

* 1er affichage sur écran LCD  

![image](https://user-images.githubusercontent.com/112614700/224830709-a37a282c-7182-4612-8eb9-4ce47ac722de.png)

* 2eme affichage sur écran LCD 

![image](https://user-images.githubusercontent.com/112614700/224830910-1158e007-6716-4555-b094-9b8ec2dae79f.png)

* 1ere affichage sur ordinateur 

![image](https://user-images.githubusercontent.com/112614700/224831074-98ce5195-e00d-4bad-9491-5b6a82a13aba.png)

* 2eme bout de code test  

// IMPORT LIB EXTERNES
// Import du microFramework express https://expressjs.com/fr/
const express = require('express')
// Import de l'ODM mongoose https://mongoosejs.com/
const mongoose = require('mongoose')

// IMPORT INTERNES
// Import des modèles, un modèle est Élément qui contient les données ainsi que de la logique en rapport avec les données 
const raspberryModel = require('./models')

// On créée une instance d'express "app"
const app = express()

const port = 3000

// Permet à express de récupèrer du json en post
app.use(express.urlencoded({ extended: true }));
app.use(express.json());

// Route par défaut (/)
app.get('/', (req, res) => {
    // On retourne à l'aide de res
  res.send('Hello World! ❤️❤️❤️❤️😭👌💻👌👌👌')
})

// Lors d'un get sur la route /leds
// On cherche à obtenir depuis notre raspberry l'état des leds de ce dernier
// la fonction est asynchrone, car on attend les actions avec la bdd
app.get('/leds', async(req, res) => {
    // On récupère le paramètre mac passé en get
    let mac = req.query.mac
    
    if(mac){
        // On vérifie s'il existe déjà en bdd, sinon on le créé avec des valeurs
        // par défaut
        let raspberry = await raspberryModel.findOne({"mac":mac})
        if(!raspberry){
            raspberry = await raspberryModel.create(
                {
                "mac":mac,
                "nom":mac, 
                etatLeds:[,
                    {
                        label:"Jaune",
                        etat:true
                    },
                    {
                        label:"Vert",
                        etat:true
                    },
                    {
                        label:"Rouge",
                        etat:true
                    },
                ]})
        }
        // on met à jour la date de dernière connexion
        raspberry.dateDerniereConnexion=Date.now()
        // On sauvegarde notre objet (à jour)
        await raspberry.save()
        // on retourne le tableau etatLeds pour traitement par le raspberry
        let result = raspberry.etatLeds
        res.send(result)
    }else{
        res.send({'result':null})
    }    
})

// Récupère l'ensemble des raspberrys présents en base
app.get('/raspberries', async(req,res)=>{
    let raspberries = await raspberryModel.find()
    res.send(raspberries)
})

// On récupère un raspberry en particulier à partir de son id passé en paramètre
app.get('/raspberry/:id', async(req,res)=>{
    let id = req.params.id
    let toReturn={}
    
    if(id){
        let raspberry = await raspberryModel.findById(id)
        if(raspberry){
            toReturn=raspberry
        }
    }

    res.send(toReturn)
})

// On met à jour l'état des LEDs d'un raspberry
// L'id du raspberry à modifier est passé en param
// le contenu d'etatLeds (contient les 3 valeurs des leds) est passé dans le body du post
// au format json
app.post('/raspberry/:id/ledsChange', async (req, res)=>{
    // Je recherche le raspberry en bdd
    let raspberry = await raspberryModel.findById(req.params.id)
    if(raspberry){
        // Je remplace la propriété etatLeds de l'objet raspberry par le JSON envoyé en post
        raspberry.etatLeds=req.body
        // mongoose ne détecte pas nativement les modification "deep" il faut lui indiquer ce que l'on a modifié
        raspberry.markModified('etatLeds')
        // on sauvegarde en base nos modifs
        await raspberry.save()
    }
})

// On récupère les informations d'identification à la bdd depuis les variables d'environnement
let userBdd=process.env.MONGO_INITDB_ROOT_USERNAME
let passwordBdd=process.env.MONGO_INITDB_ROOT_PASSWORD 
// On essaye de se connectzer à la base de donnée
mongoose
  .connect("mongodb://mongo:27017/ledsDB", { 
    "authSource": "admin",
    "useNewUrlParser": true,
    "useUnifiedTopology": true,
    "user": userBdd,
    "pass": passwordBdd
   })
  .then(() => {
    // On lance un serveur qui écoute sur le port définit au début du fichier
    app.listen(port, () => {

        console.log(`Example app listening on port ${port}`)
      
      })
  })
