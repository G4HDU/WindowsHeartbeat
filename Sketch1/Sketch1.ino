/*
 Name:		Sketch1.ino
 Created:	12/29/2015 10:12:18 AM
 Author:	barry
*/
/*
Serial Event example

When new serial data arrives, this sketch adds it to a String.
When a newline is received, the loop prints the string and
clears it.

A good test for this is to try it with a GPS receiver
that sends out NMEA 0183 sentences.

Created 9 May 2011
by Tom Igoe

This example code is in the public domain.

http://www.arduino.cc/en/Tutorial/SerialEvent

*/

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete

void setup() {
	// initialize serial:
	Serial.begin(9600);
	// reserve 200 bytes for the inputString:
	inputString.reserve(200);

	pinMode(13, OUTPUT);
}

void loop() {
	// print the string when a newline arrives:
	if (stringComplete) {
		//Serial.println(inputString);
		if (inputString == "heart") {
			flashLed();

		}
		// clear the string:
		inputString = "";
		stringComplete = false;

	}
	//flashLed();
	//digitalWrite(13, HIGH);
}

/*
SerialEvent occurs whenever a new data comes in the
hardware serial RX.  This routine is run between each
time loop() runs, so using delay inside loop can delay
response.  Multiple bytes of data may be available.
*/
void serialEvent() {
	while (Serial.available()) {
		// get the new byte:
		char inChar = (char)Serial.read();

		// if the incoming character is a newline, set a flag
		// so the main loop can do something about it:
		if (inChar=='\n' ) {
			stringComplete = true;
		}
		else {
			// add it to the inputString:
			inputString += inChar; 
		}
	}
}

void flashLed() {
	static boolean ledState ;
	ledState = !ledState;
	Serial.write("ACK\n");
	if (ledState) {
		//Serial.println("true");

	}
	else {
		//Serial.println("false");

	}
	digitalWrite(13, (ledState?HIGH:LOW));
}
