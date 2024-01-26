
import React, { useState } from "react";

const SearchForm = ({
  onSearch,
  departureOnlyState,
  arrivalDateState,
  sortByState,
}) => {
  const { departureOnly, setDepartureOnly } = departureOnlyState;
  const { arrivalDate, setArrivalDate } = arrivalDateState;
  const [errorMessage, setErrorMessage] = useState("");
  const { sortBy, setSortBy } = sortByState;

  const handleSubmit = (e) => {
    e.preventDefault();

    setErrorMessage("");
    const departureAirline = e.target.departureAirline.value;
    const departureDate = e.target.departureDate.value;
    const arrivalAirline = e.target.arrivalAirline.value;
    setSortBy(e.target.sortBy.value);

    // Check if any input is empty
    let hasEmptyFields = false;
    if (departureAirline === "") {
      setErrorMessage((prev) => prev + " departure airline");
      hasEmptyFields = true;
    }
    if (departureDate === "") {
      setErrorMessage((prev) => prev + " departure date");
      hasEmptyFields = true;
    }
    if (arrivalAirline === "") {
      setErrorMessage((prev) => prev + " arrival airline");
      hasEmptyFields = true;
    }

    if (hasEmptyFields) {
      e.target.querySelectorAll("input").forEach((input) => {
        if (input.value === "") {
          input.style.border = "1px solid #e53e3e"; 
          setTimeout(() => {
            input.style.border = ""; 
          }, 2000);
        }
      });
      return;
    }
    onSearch({
      departureAirline,
      departureDate,
      arrivalAirline,
      sortBy,
    });
  };

  const handleDepartureOnly = () => {
    setDepartureOnly(!departureOnly);
    setArrivalDate(departureOnly ? "" : undefined);
  };

  return (
    <>
      <div className="mb-6 p-6 bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700">
        <h2 className="text-4xl font-extrabold dark:text-white mb-3">
          Flight Search
        </h2>
        <form onSubmit={handleSubmit} className="grid grid-cols-3 gap-4">
          <div className="col-span-1">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Departure Airline:
            </label>
            <input
              type="text"
              name="departureAirline"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
            />
          </div>
          <div className="col-span-1">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Departure Date:
            </label>
            <input
              type="date"
              name="departureDate"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
            />
          </div>
          <div className="col-span-1">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Arrival Airline:
            </label>
            <input
              type="text"
              name="arrivalAirline"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
            />
          </div>
          {departureOnly && (
            <div className="col-span-1">
              <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
                Return Date:
              </label>
              <input
                type="date"
                name="arrivalDate"
                value={arrivalDate}
                className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                onChange={(e) => setArrivalDate(e.target.value)}
              />
            </div>
          )}

          <div className="col-span-1">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Sort By:
            </label>
            <select name="sortBy" className="border p-1">
              <option value="departuretime">Departure Time</option>
              <option value="flightlength">Flight Length</option>
              <option value="price">Price</option>
            </select>
          </div>
          <div className="col-span-1 flex items-center mb-4">
            <label className="mr-3 ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">
              Return Flight:
            </label>
            <input
              type="checkbox"
              name="isDepartureOnly"
              checked={departureOnly}
              onChange={handleDepartureOnly}
              className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"
            />
          </div>
          <div className="col-span-1">
            <button
              type="submit"
              className="bg-blue-500 text-white p-2 rounded"
            >
              Search
            </button>
          </div>
        </form>
        {errorMessage !== "" && (
          <div
            className="mt-4 p-4 mb-4 text-sm text-red-800 rounded-lg bg-red-50 dark:bg-gray-800 dark:text-red-400"
            role="alert"
          >
            <span class="font-medium">
              <b>Following inputs need to be filled:</b> {errorMessage}
            </span>
          </div>
        )}
      </div>
    </>
  );
};

export default SearchForm;
