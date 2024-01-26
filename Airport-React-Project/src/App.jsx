import React, { useState, useEffect, useRef } from "react";
import axios from "axios";
import SearchForm from "./components/SearchForm";
import FlightList from "./components/FlightList";

function App() {
  const [departureFlights, setDepartureFlights] = useState([]);
  const [arrivalFlights, setArrivalFlights] = useState([]);
  const [departureLoading, setDepartureLoading] = useState(false);
  const [arrivalLoading, setArrivalLoading] = useState(false);
  const [selectedDepartureId, setSelectedDepartureId] = useState();
  const [arrivalDate, setArrivalDate] = useState("");
  const [departureOnly, setDepartureOnly] = useState(false);
  const [sortBy, setSortBy] = useState();

  const handleDepartureSelect = (flightId) => {
    setSelectedDepartureId(flightId);
    searchArrivalFlights({
      departureFlightId: flightId,
      departureDateofReturnFlight: arrivalDate,
      sortBy: sortBy,
    });
  };

  const handleArrivalSelect = (flightId) => {
    // Handle Arrival Flight if needed in future
  };

  // const searchArrivalFlights = async ({
  //   flightId,
  //   //arrivalDate
  // }) => {
  //   departureDateofReturnFlight = arrivalDate; //set needed variable for the call
  //   setSelectedDepartureId(flightId); // set flight id
  //   setArrivalLoading(true); // set the loading screen
  //   try {
  //     const response = await axios.get("http://localhost:5000/flight/arrival", {
  //       params: {
  //         firstFlightId: departureFlightId,
  //         departureDateofReturnFlight: departureDateofReturnFlight,
  //       },
  //     });
  //     setArrivalFlights(response.data);
  //   } catch (error) {
  //     console.error("Error fetching arrival flights:", error);
  //   } finally {
  //     setArrivalLoading(false);
  //   }
  // };

  const searchDepartureFlights = async ({
    departureAirline,
    departureDate,
    arrivalAirline,
    sortBy,
  }) => {
    setDepartureLoading(true);

    try {
      const response = await axios.get(
        "http://localhost:5000/flight/departure",
        {
          params: { departureAirline, departureDate, arrivalAirline, sortBy },
        }
      );
      setDepartureFlights(response.data);
    } catch (error) {
      console.error("Error fetching departure flights:", error);
    } finally {
      setDepartureLoading(false);
    }
  };

  const searchArrivalFlights = async ({
    departureFlightId,
    departureDateofReturnFlight,
    sortBy,
  }) => {
    setArrivalLoading(true);
    try {
      const response = await axios.get("http://localhost:5000/flight/arrival", {
        params: {
          firstFlightId: departureFlightId,
          departureDateofReturnFlight: departureDateofReturnFlight,
          sortBy: sortBy,
        },
      });
      setArrivalFlights(response.data);
    } catch (error) {
      console.error("Error fetching arrival flights:", error);
    } finally {
      setArrivalLoading(false);
    }
  };

  // useEffect(() => {
  //   searchDepartureFlights({
  //     departureAirline: "EVA Air",
  //     departureDate: "2024-04-10",
  //     sortBy: "price",
  //     arrivalAirline: "China Airlines",
  //   });
  // }, []); // Initial load

  return (
    <div className="App p-4">
      <SearchForm
        onSearch={searchDepartureFlights}
        departureOnlyState={{ departureOnly, setDepartureOnly }}
        arrivalDateState={{ arrivalDate, setArrivalDate }}
        sortByState={{ sortBy, setSortBy }}
      />
      <FlightList
        flights={departureFlights}
        loading={departureLoading}
        handleSelect={handleDepartureSelect}
        title={"Departure Flights"}
        isDeparture={!departureOnly}
      />
      {selectedDepartureId && (
        <FlightList
          flights={arrivalFlights}
          loading={arrivalLoading}
          handleSelect={handleArrivalSelect}
          title={"Arrival Flights"}
          isDeparture={departureOnly}
        />
      )}
    </div>
  );
}

export default App;
