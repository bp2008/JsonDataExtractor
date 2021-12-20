# JsonDataExtractor
A Windows Service that can query a web service for JSON data and write parts of the data to text files.

## Usage
Download a release from the [Releases section](https://github.com/bp2008/JsonDataExtractor/releases).

Extract to a location of your choice.

Run `JsonDataExtractor.exe` and a service manager GUI will appear.

![image](https://user-images.githubusercontent.com/5639911/146843137-e65c2d04-d793-4623-a71a-64e39c7514cc.png)

Use the `Configure` button to configure the application.  The GUI tries to be very self-explanatory.  An example configuration is created by default so that people who learn well by example can get started quickly.


Files are written to the `Files` subdirectory of the application's data folder.

After configuring, click `Install Service` and then `Start Service`.  If you change the configuration, you must stop and start the service again.  If you move the program, you must uninstall and reinstall the service so that Windows knows where you moved the service executable to.

![image](https://user-images.githubusercontent.com/5639911/146843790-01597af6-a42c-4422-a042-55182170f2e8.png)

![image](https://user-images.githubusercontent.com/5639911/146843821-a40223c7-9d5f-4c83-bfa1-786f4c31f0b6.png)

![image](https://user-images.githubusercontent.com/5639911/146843854-b926f81f-d90b-42a1-ad64-001b9df4e3d2.png)

## Building from source

Build from source using Visual Studio 2019 or newer.  My utility library [BPUtil](https://github.com/bp2008/BPUtil) will be required for the application to build.
