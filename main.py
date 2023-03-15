from machine import Pin, I2C        #importing relevant modules & classes
from time import sleep
import bme280       #importing BME280 library
from lcdi2c import LCDI2C
 
i2c=I2C(0,sda=Pin(16), scl=Pin(17), freq=400000)    #initializing the I2C method
lcd = LCDI2C( i2c, 0x27, 2, 16 )
lcd.backlight()

 
while True:
    bme = bme280.BME280(i2c=i2c)          #BME280 object created
    lcd.print(bme.values[0])
   
    sleep(6)           #delay of 6s


