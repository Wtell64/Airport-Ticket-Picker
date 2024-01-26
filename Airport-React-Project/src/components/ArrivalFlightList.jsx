// src/components/FlightList.js
import React, { useState } from "react";

const ArrivalFlightList = ({ flights, loading, handleSelect }) => {
  return (
    <div className="my-4 p-4 bg-gray-200">
      <h2 className="text-2xl font-bold mb-4">Flight List</h2>
      {loading && <p>Loading...</p>}
      {!loading && flights.length === 0 && <p>No flights found</p>}
      {!loading && flights.length > 0 && (
        <ul>
          {flights.map((flight) => (
            <li key={flight.id} className="mb-2">
              {flight.departureAirline} - {flight.arrivalAirline} -{" "}
              {flight.departureCity} to {flight.arrivalCity} -{" "}
              {flight.departureDate} - {flight.flightLength} - ${flight.price}
              <button
                className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded"
                onClick={() => handleSelect(flight)}
              >
                Select
              </button>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default ArrivalFlightList;
