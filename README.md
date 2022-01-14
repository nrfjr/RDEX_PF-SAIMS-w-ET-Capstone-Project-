=====================================================================

#	RD Export Sales and Inventory Management System with Expense Tracker
	
	version 1.0.0.0 (20/01/2022)
	Created by the students of STI College - GENSAN
	
	1. INTRODUCTION
	2. SOFTWARE AND HARDWARE REQUIREMENTS
	3. DATABASE
	4. INSTALLATION
	5. CLIENT - SIDE SETUP
	
	
=====================================================================

INTRODUCTION

This project is a desktop based system that allow the prawn farm to
manage sales, inventory and expense as well as to assist their transactions.


=====================================================================

HARDWARE AND SOFTWARE REQUIREMENTS

A. HARDWARE REQUIREMENTS
	
	- System Unit (at least 2GB 1866MHz of RAM)
	- Processor (at least Intel Atom 1.66Ghz) 
	- Monitor resolution (at least 1366x768)
	- Input Device (Keyboard, Mouse and etc...)
	- Network Device (Modem, Ethernet Cable) 


B. SOFTWARE REQUIREMENTS	
	
	- Database (at least MySQL Workbench 8.0 CE)
	- Oracle Database Connector(MySQL ODBC ANSI Driver x64)


=====================================================================

DATABASE

database name : rd_saims
default admin account : 
	username : root
	password : root
	

=====================================================================

INSTALLATION

To install this software, you will need a MySQL Workbench(localhost) to run this system.

**Steps to install the MySQL Workbench:
1. Locate the MySQL Workbench Installer in the setup folder or Download the installer file for the latest version of MySQL Workbench in URL(https://dev.mysql.com/downloads/workbench/) and save the file to your computer.
3. Open MySQL Installer for Windows.
6. It will ask for permission; when it does, click Yes. The installer will then open. Now, it will ask to choose the setup type. Here, select Custom.
7. Click on Next. With this, you will install MySQL server, MySQL Workbench, and MySQL shell.
8. Open MySQL Servers, select the server you want to install, and move it to the  Products/Features to be installed window section. Now, expand Applications, choose MySQL Workbench and MySQL shell. Move both of them to ‘Products/Features to be installed’.
9. Click on the Next button. Now, click on the Execute button to download and install the MySQL server, MySQL Workbench, and the MySQL shell.
10. Once the product is ready to configure, click on Next. Under Type and Networking, go with the default settings and select Next.
11. For authentication, use the recommended strong password encryption.
12. Set your MySQL Root password and click on next.
13. Go for the default windows service settings and under apply configuration, click on execute. Once the configuration is complete, click on finish.
14. Complete the installation. This will now launch the MySQL Workbench and the MySQL Shell.
	Once MySQL Workbench is installed, select the Local instance and enter the password.
	Now, you can use the MySQL query tab to write your SQL queries. 


**Steps to setup database:

1. Run and Open your MySQL Workbench
2. create a database schema "rd_saims"
3. goto server then select Data Import
4. import the database file "RD_SAIMS.sql"
5. open and login to the system.


**Steps to install the system:

1. Run the Setup.msi file
2. A window will prompt if you 'allow to make change to your computer' then click 'OK'
3. Run the Setup.exe to start the installed application.
4. The system will start and setting will appear to allow configuration base on database setting.


=====================================================================

CLIENT - SIDE SETUP

**Steps to setup client-side computer:

1. Install the Oracle Database Connector in the client computer.
2. Open the ODBC Data Source Administrator.
3. Click 'Add' under User DSN Tab.
4. Select 'MySQL ODBC ANSI Driver' and click Finish.
5. Enter the Server IP Address on  TCP/IP Server Field
6. Enter Username and Password provided by the server.
7. Click 'Test' to test the connection, if the connection is successful then select the database 'rd_saims' otherwise, start from step 5.
8. Click Add and OK to finish.


======================================================================
