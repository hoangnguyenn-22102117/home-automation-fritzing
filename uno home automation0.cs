#define RELAY_ON 0
#define RELAY_OFF 1
#define RELAY_1 4
char data = 0;
void setup() {
// đẩu ra
pinMode(RELAY_1, OUTPUT);
// chỉnh relay sẽ tắt theo mặc định, hoặc khi ấn reset
digitalWrite(RELAY_1, RELAY_OFF);
Serial.begin(9600);
Serial.print(“Nhap: 1 de mo den. 0 de tat den”);
}
void loop() {
if (Serial.available() &gt; 0) {
data = Serial.read(); //Đọc giá trị nhập vào và lưu trữ thành dữ liệu biến
Serial.print(data); //In giá trị vào Serial Monitor
Serial.print(“\n”); //Dòng mới
if(data == ‘1’){
digitalWrite(RELAY_1, RELAY_ON);
Serial.println(“Bóng đèn đã được BẬT.”);
}
else if(data == ‘0’){
digitalWrite(RELAY_1, RELAY_OFF);
Serial.println(“Bóng đèn đã được TẮT.”);
}
}
}