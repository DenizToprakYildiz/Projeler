#include <Servo.h>



Servo servo;
int triggerPin = 5;
int echoPin = 6;
int servoPin = 8;
long zaman;
int mesafe ;
void setup()
{
  servo.attach(servoPin);
  servo.write(0);
  delay(2000);
  // trigger pinini output olarak seçiyoruz
  pinMode(triggerPin, OUTPUT);
  // echo pinini input olarak seçiyoruz
  pinMode(echoPin, INPUT);
  //serial iletişimi başlatıyoruz
  Serial.begin(9600);
}
void loop()
{ 
  // Trigger pini 0 Volt olarak ayarlıyoruz.
  digitalWrite(triggerPin, LOW);
  delayMicroseconds(2); // Trigger pinini 10 saniye için high olarak ayarlıyoruz ve 5 V gerilim uyguluyoruz.
  digitalWrite(triggerPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(triggerPin, LOW);
  // echoPini okur ve ses dalgası mikrosaniye olarak döndürür.
  
  zaman= pulseIn(echoPin, HIGH);  
  // Mesafe hesaplaması
  
  mesafe = zaman* 0.035 / 2;
  //bundan sonraki iki satır HC-SR04 mesafe sensörünün, anlık olarak yaptığı mesafe ölçümlerinin sonucunu görmemizi sağlar. 
  
  Serial.print("Mesafe: ");
  Serial.println(mesafe);
  if ( mesafe <= 50 )
  {  // mesafe 50 altında ise servo 135 dereceye geliyor.
    servo.write(135);
    delay(3000); // Delay süreleri opsiyoneldir, değiştirilebilir. 
  }else
  {  // değil ise kendine 45 dereceye getiriyor. 
    servo.write(45);
  }
}

