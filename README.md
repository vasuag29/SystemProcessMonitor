# SystemProcessMonitor
A tool that can monitor the data (bytes) usage of any process that is running on the system.

***************************************
About the project and the tool
***************************************

The user friendly tool provides the user a feature to monitor the memory usage of system process, that can be selected by the user.
The memory usage data is monitored after every sample rate interval which, by the way, can be specified by the user.
The memory usage data is stored together into a single file (XLSX/CSV/TSV, as selected by the user) and the file is saved when the user presses the STOP button.

The tool is pretty straight forward: 
1. Check the processes that you wish to monitor
2. Select sampling rate
3. Select the output path of the file to be saved
4. Select the file type
5. Click Start
6. Click Stop when you wish to stop the monitor process and the file will be saved.

The tool is useful for detecting memory leaks and memory usage anomalies.
One can simply monitor processes for intervals and then they can easily plot a graph to assess the memory leaks.

**********************************
Known bugs and future improvements
**********************************
- The 'EXIT' button in the menu strip is does not work as desired.
- When you close the tool by clicking on the 'Close' button on top right corner, the tool is not closed as desired.
- The progress bar is not working.
- Sometimes if a user has selected way too many processes for monitoring (say more than 15), the saved data may not be accurate. For this,   multithreading and locking mechanism shall be applied as a future improvement.
- Since we have used a generic data processor class that implements a generic interface, we can add the data analytics part inside the tool   itself. This shall be considered as a future addition.

**********************************
How to use build and use the tool
**********************************
- I have added only the required .cs files and the UI project, and the project was developed in visual studio 2017 community edition.
- To build the project, create an empty visual studio project and add the 4 different folders inside, namely: Business Layer, View Layer,     Persistence Layer, Common

- The project structure is like this: 

![alt text](https://github.com/vasuag29/SystemProcessMonitor/blob/master/Project%20Structure.PNG)


- Now, after the folders are created, add the projects and files as shown in the image. Now add the appropriate references to the 'Common' folder.
- Finaly, set the UI project as startup project and build the solution.


