#pragma once
#include <SQLAPI.h>
#include <vector>


using namespace System;
using namespace std;
using namespace RideC;
using namespace UserC;

namespace dbhelp
{
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
