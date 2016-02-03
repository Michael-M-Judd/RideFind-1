// User_Mine.h

#pragma once
#include <string>
#include <SQLAPI.h>
#include <vector>

using namespace System;
using namespace std;
using namespace RideC;

namespace UserC {

	//The general user exception 
	public ref class UserException {
	public:
		UserException(String^);
		String^ what();
	private:
		String^ message = gcnew String("");
	};

	public ref class User {
	public:
		User(String^, String^, String^, String^, bool);   //Constructor used to register (Parameters are Name, email, password, location)
		User(String^, String^); //Constructor used to sign in 	

		String^ getName(); //Accessor, returns name
		String^ getEmail(); //Accessor, returns emailID 
		String^ getLocation(); //Accessor, returns location 
		bool driveCheck();
		//bool createUser();
		void setLocation(String^ location); //Mutator, used to obtain the location value from the database when signing in 
		void setName(String^ name); //Mutator, used to obtain the name value from the database from signing in 
		String^ getPassword(); //Accessor, returns password, made private since this is security info

							   /*The following methods are the functional methods in the user class*/
		bool emailUser(String^ emailId); //Sends a message to another user
		bool bookRide(int rideId); //Used to book a ride
								   // TODO: Code overloaded search methods once ride class exists
		virtual ~User(); //Deconstructor 
						 // TODO: Code overloaded search methods once ride class exists
						 //vector <Ride>(); //will be overloaded
	private:
		String^ name;
		String^ emailId;
		String^ password;
		String^ location;
		bool driverCheck;
		
								   //vector <Ride>(); //will be overloaded
	};

	public ref class resultErrorException {
	public:
		resultErrorException(String^);
		String^ what();
	private:
		String^ message;
	};
	public ref class notADriverException
	{
	public:
		notADriverException(String^);
		String^ what();
	private:
		String^ message;
	};

	public ref class noUserIDException
	{
	public:
		noUserIDException(String^);
		String^ what();
	private:
		String^ message;
	};

	public ref class userExistingException
	{
	public:
		userExistingException(String^);
		String^ what();
	private:
		String^ message;
	};

	public ref class carFullException
	{
	public:
		carFullException(String^);
		String^ what();
	private:
		String^ message;
	};

	public ref class dBHelper
	{
	public:
		//changing some return methods to void
		//catching connection and query exceptions should be done in backend
		dBHelper();
		//void MarshalString(String^, string&);
		void Connect();
		void Disconnect();
		int createAUser(String^ Uname, String^ ID, String^ password, bool driverCheck); //TODO
		bool authentication(String^, String^); //done
		bool getUserRoles(User); //TODO
								 //vector<Ride> getRideListing(); //TODO
		bool createARide(Ride, String^); //done
		bool bookARide(int, String^); //TODO
									  //String^ getEmail(User); //TODO
		int getDriverRating(User); // TODO
		bool addDriverRating(int, User); //TODO
		int getNumberOfSeats(Ride); //TODO
		bool deleteExpiredRide(Ride); //TODO
		char* convertStr(String^);
	private:
		//SAConnection con;
		//SACommand cmd;
		String^ registeredUserID;
		String^ registeredPassword;


	};
}
