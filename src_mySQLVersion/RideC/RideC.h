// RideC.h

#pragma once

using namespace System;
using namespace std;

namespace RideC {

	public ref class Ride {
	public:
		Ride(int, int, int, String^, String^, String^, String^);
		Ride(int, int, int, int, String^, String^, String^);
		int getRideID();
		int getNumSpots();
		int getDepTime();
		int getCost();
		String^ getName();
		String^ getDestLocation();
		String^ getDepLocation();
		//bool createRide(int, int, int, String^, String^, String^);

	private:
		int rideID;
		int numSpots;
		int depTime;
		int cost;
		String^ name;
		String^ destLocation;
		String^ depLocation;
		String^ emailID;

	};

	public ref class InvalidRideException
	{
	public:
		InvalidRideException(String^);
		String^ what();

	private:
		String^ message;
	};
}
