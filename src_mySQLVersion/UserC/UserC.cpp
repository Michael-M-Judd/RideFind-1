// This is the main DLL file.

#include "stdafx.h"
#include "UserC.h"
#include <string>
#include <ctime>
#include <list>
#include <msclr\marshal_cppstd.h>
#include <SQLAPI.h>
//sorry
using namespace System;
using namespace UserC;
using namespace RideC;

UserException::UserException(String^ m) : message(m) {} //end user exception constructor

String^ UserException::what() {
	return message;
} //end user exception method

  //Constructors for user class
User::User(String^ name, String^ email, String^ password, String^ location, bool check) : name(name), emailId(email), password(password), location(location), driverCheck(check) {
	//TODO: Add exception check 
}//End constructor used to register a new user 

User::User(String^ email, String^ password) : emailId(email), password(password) {
	//TODO: Add exception check
	//TODO: Add the setters for location and name attributes
}//End constructor used to register a new user


 //Accessors for attributes
String^ User::getName() { return name; }
String^ User::getPassword() { return password; }
String^ User::getEmail() { return emailId; }
String^ User::getLocation() { return location; }
bool User::driveCheck() { return driverCheck; }

//Mutators for name and location (which will be obtained from the database) 
void User::setName(String^ name) {
	//TODO:  Call database helper to retreive this matching name from the database and then set it
}//End setName mutator 

void User::setLocation(String^ location) {
	//TODO: Call database helper to retrieve this matching location from the database and then set it
}//End setLocation mutator 

User::~User() {
	//TODO: Does this destructor actually work?!? 
}//End deconstructor 

bool User::emailUser(String^ emailId) {
	//TODO:  Get Xi to explain how to automate sending an email 
	return true;
}// End emailUser method

bool User::bookRide(int rideId) {
	//TODO: Connect bookRide with database helper to update the database
	return true;
}//End bookRide method

resultErrorException::resultErrorException(String^ m) :message(m) {}
userExistingException::userExistingException(String^ m) : message(m) {}
noUserIDException::noUserIDException(String^ m) : message(m) {}
notADriverException::notADriverException(String^ m) : message(m) {}
carFullException::carFullException(String^ x) : message(x) {}

String^ resultErrorException::what() {
	return message;
}

String^ carFullException::what() {
	return message;
}

String^ notADriverException::what() {
	return message;
}

String^ noUserIDException::what() {
	return message;
}
String^ userExistingException::what() {
	return message;
}

//forward declaration
SAConnection con;
//TODO: need to test:
//will global declaration work?or need to declare locally in every function?
SACommand cmd;

dBHelper::dBHelper() {}

void dBHelper::Connect() {
	try {
		con.Connect(
			"satya.caslab.queensu.ca", //db name
			"poplar", //username
			"rideshare", //password
			SA_Oracle_Client);
		cmd.setConnection(&con); //set once? or need to associate in every function?
	}
	//catch connection error
	catch (SAException &m) {
		try {
			con.Rollback();
		}
		catch (SAException &)
		{
			//catch network error
		}
	}

}
void dBHelper::Disconnect() {
	if (cmd.isOpened()) {
		cmd.Close();
	}
	if (con.isConnected()) {
		try {
			con.Disconnect();
		}
		catch (SAException &m) {
			//catch disconnect exception
		}
	}
}

char* dBHelper::convertStr(String^ managed) {
	int size = managed->Length + 1;
	char cStr[20] = { 0 };
	if (size < sizeof(cStr))
		sprintf(cStr, "%s", managed);
	/*msclr::interop::marshal_context context;
	std::string stdStr = context.marshal_as<std::string>(managed);
	return stdStr;*/
	return cStr;
}
int dBHelper::createAUser(String^ Uname, String^ ID, String^ password, bool driverCheck) {
	Connect();
	//test if the email has not been registered
	cmd.setCommandText(
		"Select email_address from User_Account Where email_address=:1");
	/*msclr::interop::marshal_context context;
	std::string email = context.marshal_as<std::string>(newUser.getEmail());
	*/
	char* email = convertStr(ID);
	//char* email = new char[temp.length() + 1];
	//strcpy(email, temp.c_str());
	cmd.Param(1).setAsString() = SAString(email);

	cmd.Execute();
	if (cmd.FetchFirst())
	{
		return 0;
		//userExistingException^ exc = gcnew userExistingException("Email Already Registered!");
		//throw exc;
	}

	//user's attributes are different from the table in the db
	//need to make changes to db or user class
	cmd.setCommandText(
		//attributes insertion based on the db attributes
		//"Insert into User_Account(emailId, first_name, last_name, gender, driver_status, birthday, profile_pic, password) values(:1, :2, :3, :4, :5, :6, :7, :8");

		"Insert into User_Account(:email_address, :name,:driver_status, :password)");

	char* name = convertStr(Uname);
	//char* name = new char[tempName.length() + 1];
	//strcpy(name, tempName.c_str());

	//char* Loc = convertStr(newUser.getLocation());
	//char* Loc = new char[tempLoc.length() + 1];
	//strcpy(Loc, tempLoc.c_str());
	char* Pass = convertStr(password);

	cmd << SAPos("email_address") << email << SAPos("name") << name << SAPos("driver_status") << driverCheck << SAPos("password") << Pass;
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {
		return 0;
	}
	//delete[] email;
	//delete[] name;
	//delete[] Loc;
	Disconnect();
	return 1;
}

bool dBHelper::authentication(String^ userId, String^ password) {
	Connect();
	cmd.setCommandText(
		"Select email_address,password from User_Account Where emailId=:1");
	char* cUserId = convertStr(userId);
	//char* cUserId = new char[tempId.length() + 1];
	//strcpy(cUserId, tempId.c_str());
	//cmd.Param(1).setAsString() = cUserId;
	cmd << cUserId;
	//if there is result fetched then we can compare

	char* cPassword = convertStr(password);
	//char* cPassword = new char[tempPassword.length() + 1];
	//strcpy(cPassword, tempPassword.c_str());

	if (cmd.FetchFirst()) {
		//compare password
		if (cmd.Field("password").asString() == cPassword) {
			return true;
		}
		else {
			return false;
		}
	}
	else {
		//throw email entered that has not been registered
		//noUserIDException^ exc = gcnew noUserIDException("The email entered has not been registered!");
		//throw exc;
		return false;
	}
	Disconnect();
}
bool dBHelper::getUserRoles(User user) {
	Connect();
	cmd.setCommandText("Select driver_status from User_Account Where emailId=:1");

	char* email = convertStr(user.getEmail());
	//char* email = new char[temp.length() + 1];
	//strcpy(email, temp.c_str());

	cmd.Param(1).setAsString() = email;
	cmd.Execute();
	if (cmd.FetchFirst()) {
		return cmd.Field("driver_status");
	}


	//delete[] email;
	Disconnect();

}
bool dBHelper::createARide(Ride ride, String^ emailID) {
	Connect();
	cmd.setCommandText(
		"Select driver_status from User_Account Where email_address=:1"
		);

	char* email = convertStr(emailID);
	//char* email = new char[temp.length() + 1];
	//strcpy(email, temp.c_str());

	cmd.Param(1).setAsString() = email;
	cmd.Execute();
	if (cmd.FetchFirst() == false) {
		notADriverException^ exc = gcnew notADriverException("You don't have the right to create a ride!");
		throw exc;
	}
	cmd.setCommandText(
		"Insert into RideListings listing_departure_date=:1, departure_location=:2, destination_location=:3, empty_seat=:4, listing_pirce=:5, Driver_Account_driver_id=:6)"
		);
	//convert Departure location 
	char* depLoc = convertStr(ride.getDepLocation());
	//char* depLoc = new char[tempDep.length() + 1];
	//strcpy(depLoc, tempDep.c_str());

	//conver destination
	char* desLoc = convertStr(ride.getDestLocation());
	//char* desLoc = new char[tempDes.length() + 1];
	//strcpy(desLoc, tempDes.c_str());

	cmd.Param(1).setAsLong() = ride.getDepTime();
	cmd.Param(2).setAsString() = depLoc;
	cmd.Param(3).setAsString() = desLoc;
	cmd.Param(4).setAsLong() = ride.getNumSpots();
	cmd.Param(5).setAsLong() = ride.getCost();
	cmd.Param(6).setAsString() = email;
	//cmd << SAPos("listing_departure_date") << ride.getDepTime() << SAPos("departure_location").setAsString() << depLoc << SAPos("destination_location") << desLoc << SAPos("empty_seat") << ride.getNumSpots() << SAPos("listing_price") << ride.getCost() << SAPos("Driver_Account_driver_id") << email;
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {

	}

	//delete[] email;
	//delete[] depLoc;
	//delete[] desLoc;
	Disconnect();
	return true;
}
//FRONT END: how the parameters are passed in?
/*list<Ride> getRideListing() {
Connect();
cmd.setCommandText(
"SELECT * FROM RideListings ORDER BY ridelisting_departure_date ASC"
);
try {
cmd.Execute();
con.Commit();
}
catch (SAException &m) {

}
list<Ride> rideList;
while (cmd.FetchNext()) {
Ride r = new Ride(cmd.Field(""));
rideList->Add(r);
}
return rideList;
}*/

//not done
bool dBHelper::bookARide(int rideID, String^ emailID)
{
	Connect();
	cmd.setCommandText(
		"SELECT empty_seat FROM RideListings WHERE listing_id = :1"
		);
	cmd.Param(1).setAsLong() = rideID;
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {

	}
	if (cmd.FetchFirst()) {
		cmd.setCommandText(
			"INSERT INTO booking(booking_id,Ridelistings_listing_id, User_Account_user_id) VALUES(:1,:2)"
			);
		cmd.Param(1).setAsLong() = (long)rideID;

		char* email = convertStr(emailID);
		//char* email = new char[temp.length() + 1];
		//strcpy(email, temp.c_str());

		cmd.Param(2).setAsString() = SAString(email);
		try {
			cmd.Execute();
			con.Commit();
		}
		catch (SAException &m) {

		}
	}
	else
	{
		notADriverException^ exc = gcnew notADriverException("Car is already full, sorry, maybe you will get on the next one");
		throw exc;
	}
}

int dBHelper::getDriverRating(User u)
{
	Connect();
	cmd.setCommandText(
		"SELECT current_rating FROM Driver_Account WHERE emailId =:1");
	char* email = convertStr(u.getEmail());
	//char* email = new char[temp.length() + 1];
	//strcpy(email, temp.c_str());
	cmd.Param(1).setAsString() = SAString(email);
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {

	}
	int driverRating;
	if (cmd.FetchFirst()) {
		driverRating = cmd.Field("current_rating").asLong();
	}
	else {
		resultErrorException^ exc = gcnew resultErrorException("no rating found!");
		throw exc;
	}

	//delete[] email;
	Disconnect();
	return driverRating;
}

bool dBHelper::addDriverRating(int rating, User u)
{
	Connect();
	cmd.setCommandText(
		"UPDATE Driver_Account SET current_rating =:1 WHERE emailId =: 2");
	cmd.Param(1).setAsLong() = long(rating);
	char* email = convertStr(u.getEmail());
	//char* email = new char[temp.length() + 1];
	//strcpy(email, temp.c_str());
	cmd.Param(2).setAsString() = SAString(email);
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {

	}
	//delete[] email;
	Disconnect();
	return true;
}

int dBHelper::getNumberOfSeats(Ride r)
{
	Connect();
	//string statement = "SELECT empty_seat FROM rideListings WHERE listing_id = " + r.listingID;
	cmd.setCommandText(
		"SELECT empty_seat FROM rideListings WHERE listing_id =:1");
	cmd.Param(1).setAsLong() = r.getRideID();
	int numSeats;
	try {
		cmd.Execute();
		con.Commit();
	}
	catch (SAException &m) {

	}
	if (cmd.FetchFirst()) {
		numSeats = cmd.Field("empty_seat").asLong();
	}
	else {
		resultErrorException^ exc = gcnew resultErrorException("no number of seats found!");
		throw exc;
	}
	Disconnect();
	return numSeats;
}

bool dBHelper::deleteExpiredRide(Ride r)
{
	Connect();
	//delete ride SQL

	//DELETE * FROM RideListings
	//Where listing_id = Ride.listing_id 
	//DELETE * FROM Listing_Booking
	//WHERE listing_id = Ride.listing_id


	//test if the email has not been registered
	cmd.setCommandText(
		"Select listing_departure_date from User_Account Where listing_id=:1");
	cmd.Param(1).setAsLong() = r.getRideID();
	cmd.Execute();
	// current date/time based on current system
	time_t now = time(0);
	// convert now to string form
	char* dt = ctime(&now);

	if (cmd.Field("listing_departure_date") <  dt) {
		//user's attributes are different from the table in the db
		//need to make changes to db or user class
		cmd.setCommandText(
			//attributes insertion based on the db attributes
			//"Insert into User_Account(emailId, first_name, last_name, gender, driver_status, birthday, profile_pic, password) values(:1, :2, :3, :4, :5, :6, :7, :8");
			//get password is private CAN'T ACCESS
			"DELETE * FROM Listing_Booking WHERE listing_id =:1");
		cmd.Param(1).setAsLong() = r.getRideID();
		try {
			cmd.Execute();
			con.Commit();
		}
		catch (SAException &m) {

		}
		Disconnect();
	}
	return true;
}
 /*
 bool Driver::createRide(Ride aRide) {
 //TODO: Connect createRide with database helper to update the database
 }//End createRide method
 */
/*bool User::createUser()
{
	return true;
}*/