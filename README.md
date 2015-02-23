# loki
Released as open source by NCC Group Plc - http://www.nccgroup.com/

Developed by Dave Spencer, david [dot] spencer [at] nccgroup [dot] com

http://www.github.com/nccgroup/Loki

Released under AGPL see LICENSE for more information

## Description

Loki (Limited Obstructive Keyboard Impersonator) has a built in RDP client and uses the tester’s ability to manually type out a file in notepad or some other text editor. The key issue with using notepad is that it is not possible to type out binary data. To combat this we can use a number of encodings such as hex or base 64, the problem with this is that we need a way of decoding them at the other end. Luckily Internet Explorer has a built in base64 decoder used for MIME HTML (.mht) files.
Loki will take a given file, convert it to base64 and using input simulator (https://inputsimulator.codeplex.com/) will type out the .mht file to the text editor in focus.

Loki can be used with Sleipnir (https://github.com/nccgroup/sleipnir) and Fenrir (https://github.com/nccgroup/fenrir)

## Usage
The initial Loki interface is pretty straight forward it consists of 5 input fields and 2 tick boxes. The “RDP server” and “RDP Port” are required fields, these are used to connect to the RDP server. In the case of an RDP Gate being in place the “RDP Gateway” field can be used to specify the address.
The “Metasploit Server” and “Metasploit Port” fields are for  use with Fenrir.
The NLA tick box toggles whether the client uses Network Level Authentication and the Full Screen tick box sets the client to full screen mode.
 
Once connected the interface for using Loki is even simpler as it uses a single drop down menu titled “Loki” with one option – send file, which transmits the file using send keys. 
The first thing to do is get a text editor open (ensuring it is in focus), and select Loki -> Send File (sendkeys). Loki will then ask two questions:

1)	Is the network particularly slow? If yes is selected then the time between key presses is set to 10ms, if no is selected then it uses 3ms instead.

2)	Is the remote browser Internet Explorer? If yes is selected then the file is sent as part of an mht file, if no is selected then the file is sent as part of an embedded image as other browsers do not support the mht format.

If the remote browser is Internet explorer then the format seen will be mht
Once completed the file should be saved as filename.mht and opened with IE, then saved again as “web page, complete” this will create a web page and a directory containing two randomly named tmp files. The extension of the larger of these two files should be changed to that of the transferred file, for example if it was an executable that was transferred, the file becomes mhtC1E4(1).exe

If the remote browser is not Internet Explorer then the format seen will be that of an image embedded in a html page.
This should then be saved as a html page, and opened with whichever browser is installed, right click on the link and select save as and enter the correct file name, in this case sleipnir.exe (Note that IE does not allow this step, hence the two different methods).
