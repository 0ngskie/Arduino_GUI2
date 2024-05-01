#include <Servo.h>
Servo myServo;

// LED Arduino Value
int led01 = 5;
int led02 = 6;
int led03 = 3;
int emergencyLED = 2;

// buzzer Value
int buzzerPin = 4;

// GUI Value
String Data;
char d1;
String x;

//Servo Value
int servoVal;

// LED GUI Value
int blueLedVal;
int redLedVal;
int yellowLedVal;

//Buzzer Sound Value
int emergencyVal;
int policeVal;

// LED Function Value
boolean blinkMode = false;
int selectedLed = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  
  myServo.attach(A5);
  
  pinMode(led01, OUTPUT);
  pinMode(led02, OUTPUT);
  pinMode(led03, OUTPUT);
  pinMode(emergencyLED, OUTPUT);
  
  pinMode(buzzerPin, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    Data = Serial.readString();
    d1 = Data.charAt(0);
    switch(d1){

      // servo Controller
      case 'A':
      x = Data.substring(1);
      servoVal = x.toInt();
      myServo.write(servoVal);
      break;
      
      case '0':
      myServo.write(0);
      break;

      // Blue LED Brightness Controller
      case 'B':
      x = Data.substring(1);
      blueLedVal = x.toInt();
      analogWrite(led01, blueLedVal);
      break;
      
      // Red LED Brightness Controller
      case 'R':
      x = Data.substring(1);
      redLedVal = x.toInt();
      analogWrite(led02, redLedVal);
      break;

      // Yellow LED Brightness Controller
      case 'Y':
      x = Data.substring(1);
      yellowLedVal = x.toInt();
      analogWrite(led03, yellowLedVal);
      break;

      case 'S':
      blinkMode = false;
      break;

      case 'L':
      blinkMode = true;
      break;

      
      // Buzzer Controller
      case 'E':
      x = Data.substring(1);
      emergencySiren();
      break;
      
      case 'P':
      x = Data.substring(1);
      policeSiren();
      break;
    }
  }
  //Will fix on this Soon
  if (blinkMode) {
    static unsigned long lastMillis = 0;
    static bool ledState = false;
    unsigned long currentMillis = millis();
    if (currentMillis - lastMillis >= 500) { // Blink interval: 500 ms
      lastMillis = currentMillis;
      ledState = !ledState;
      digitalWrite(selectedLed, !digitalRead(selectedLed));
    }
  }
}
void emergencySiren(){
  int delayCount = 100;
  
  for(int i  = 0; i < 20; i++){
  digitalWrite(emergencyLED, HIGH);
  tone(buzzerPin, 2000);
  delay(delayCount);
  digitalWrite(emergencyLED, LOW);
  tone(buzzerPin, 5000);
  delay(delayCount);
  }
  noTone(buzzerPin);
}
void policeSiren(){
  int lowFreq = 3400;
  int highFreq = 4000;

  for(int i = lowFreq; i <= highFreq; i++){
    tone(buzzerPin, i);
  }
  delay(5);
  for(int i = highFreq; i >= lowFreq; i--){
    tone(buzzerPin, i);
  }
  delay(5);
  noTone(buzzerPin);
}
