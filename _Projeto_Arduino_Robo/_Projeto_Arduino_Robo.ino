// C++ code
//
String data; 
void setup()
{


  Serial.begin(9600); 
  // PINOS DO MOTOR A
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);

  // PINOS DO MOTOR B
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  Serial.println("fim setup");
}

void loop()
{



  //COMEÇA A RECEBER VALORES DO BLUETOOTH
  if(Serial.available() > 0){
    /*LE O VALOR DO BLUETOOTH*/
   int data2=Serial.read();
   //data = Serial.read();
   Serial.print(data);
   Serial.print("\n");
   
      if( data2 == 49){
           Serial.print("frente");
           frenteMotorA();
           frenteMotorB();

               
      }

      if( data2==51){
          Serial.print(data2);
            trasMotorA();
           frenteMotorB();
               
      }
      if( data2==52){
          Serial.print(data2);
           frenteMotorA();
           trasMotorB();
               
      }
      
      if( data2==50){
           Serial.print("tras");
           trasMotorA();
           trasMotorB();
               
      }
  
  
  
  
  }

}

void frenteMotorA()
{
  digitalWrite(10, HIGH); // Liga o MotorA no sentido de rotação desejado
  digitalWrite(9, LOW);   // Desliga o outro pino para evitar curto-circuito
}



void trasMotorA()
{
  digitalWrite(10, LOW);  // Inverte a direção do MotorA
  digitalWrite(9, HIGH);  // Desliga o outro pino para evitar curto-circuito
}

void frenteMotorB()
{
  digitalWrite(4, HIGH);  // Liga o MotorB no sentido de rotação desejado
  digitalWrite(3, LOW);   // Desliga o outro pino para evitar curto-circuito
}


void trasMotorB()
{
  digitalWrite(4, LOW);   // Inverte a direção do MotorB
  digitalWrite(3, HIGH);  // Desliga o outro pino para evitar curto-circuito
}

void esquerda(){
  digitalWrite(9, HIGH);
  digitalWrite(10, HIGH);
  digitalWrite(4, HIGH);  // Liga o MotorB no sentido de rotação desejado
  digitalWrite(3, LOW);   // Desliga o outro pino para evitar curto-circuito
}

void direita(){
  digitalWrite(9, HIGH);
  digitalWrite(10, LOW);
  digitalWrite(4, HIGH);  // Liga o MotorB no sentido de rotação desejado
  digitalWrite(3, HIGH);   // Desliga o outro pino para evitar curto-circuito
}

