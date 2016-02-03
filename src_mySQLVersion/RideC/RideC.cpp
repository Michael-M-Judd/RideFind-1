// This is the main DLL file.

#include "stdafx.h"

#include "RideC.h"

using namespace System;
using namespace RideC;

Ride::Ride(int ID, int time, int seats, int money, String^ depLoc, String^ destLoc, String^ Dname)
{
	rideID = ID;
	depLocation = depLoc;
	destLocation = destLoc;
	depTime = time;
	numSpots = seats;
	cost = money;
	name = Dname;
	//TODO: call dphelper to put these items in the in the database
	//TODO: add name to the class diagram/sequence diagram
}

Ride::Ride(int time, int seats, int money, String^ depLoc, String^ destLoc, String^ Dname, String^ email)
{
	depLocation = depLoc;
	destLocation = destLoc;
	depTime = time;
	numSpots = seats;
	cost = money;
	name = Dname;
	emailID = email;
	//TODO: call dphelper to put these items in the in the database
	//TODO: add name to the class diagram/sequence diagram
}

String^ Ride::getName()
{
	return name;
}

String^ Ride::getDepLocation()
{
	return depLocation;
}

String^ Ride::getDestLocation()
{
	return destLocation;
}

int Ride::getDepTime()
{
	return depTime;
}

int Ride::getNumSpots()
{
	return numSpots;
}

int Ride::getCost()
{
	return cost;
}

int Ride::getRideID()
{
	return rideID;
}

/*bool Ride::createRide()
{
	dbHelper db = new dbHelper();
	db.connect();
	bool isCreated = db.createRide(this, String^);
	db.disconnect;
	if (isCreated)
		return true;
	return false;
}*/

InvalidRideException::InvalidRideException(String^ ex) : message(ex) { }

String^ InvalidRideException::what()
{
	return message;
}

//Ride::Ride(int id, int departureTime, int des)