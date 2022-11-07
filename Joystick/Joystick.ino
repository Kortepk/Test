/*
// Первая версия программы на вывод цветов
char commandValue; // данные, поступаемые с последовательного порта
int r = 3, g = 6, b = 7, ledPin = 13; // встроенный светодиод

void setup() {
  pinMode(ledPin, OUTPUT); // режим на вывод данных
  pinMode(r, OUTPUT); // режим на вывод данных
  pinMode(g, OUTPUT); // режим на вывод данных
  pinMode(b, OUTPUT); // режим на вывод данных
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    commandValue = Serial.read();
    Serial.write(commandValue);
  }

  switch(commandValue) {
    case '3':
      digitalWrite(r, HIGH); // включаем светодиод
      digitalWrite(ledPin, HIGH);
      break;
    case '2':
      digitalWrite(g, HIGH); // включаем светодиод
      break;
    case '1':
      digitalWrite(b, HIGH); // включаем светодиод
      break;
    default:
      digitalWrite(ledPin, LOW); // в противном случае выключаем
      digitalWrite(r, LOW);
      digitalWrite(g, LOW);
      digitalWrite(b, LOW);
  }
  delay(10); // задержка перед следующим чтением данных
}
*/

// Динамическое изменение цвета
#define R 6
#define G 5
#define B 3
#define ledPin 13
int brg = 0, r=0, g=0, b=0, t;

int recdata[10];
int bytes = 0;

String s;

void setup() {
  pinMode(ledPin, OUTPUT); // режим на вывод данных
  pinMode(R, OUTPUT); // режим на вывод данных
  pinMode(G, OUTPUT); // режим на вывод данных
  pinMode(B, OUTPUT); // режим на вывод данных
  Serial.begin(9600);
  Serial.setTimeout(100);
}

void loop() {
  if (Serial.available() > 1) {
    char str[11];
    int amount = Serial.readBytesUntil(";", str, 11);
    str[amount] = NULL;
    
    int data[3];         // буфер интов
    int count = 0;        // счётчик интов
    char* offset = str;   // указатель для работы
    while (true) {
       data[count++] = atoi(offset); // пишем число в буфер
       offset = strchr(offset, ','); // поиск следующей запятой
       if (offset) offset++;         // если это не NULL - продолжаем
       else break;                   // иначе покидаем цикл
     }
        
    r = data[0];
    g = data[1];
    b = data[2];

   for (int i = 0; i < count; i++) Serial.println(str);
    
    //digitalWrite(ledPin, HIGH);
  }

  
  
  analogWrite(R, r);
  analogWrite(G, g);
  analogWrite(B, b);
  delay(1); // задержка перед следующим чтением данных
}
