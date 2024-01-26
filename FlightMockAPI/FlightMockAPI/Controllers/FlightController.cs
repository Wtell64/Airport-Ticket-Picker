using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FlightController : ControllerBase
{
    private static List<Flight> flights = new List<Flight>
{

    new Flight
    {
        Id = 1,
        DepartureAirline = "Delta Air Lines",
        ArrivalAirline = "American Airlines",
        DepartureCity = "Chicago",
        ArrivalCity = "Dallas",
        DepartureDate = "2024-04-10T09:00:00",
        FlightLength = "3 hours",
        Price = 420.50m,
    },

    new Flight
    {
        Id = 2,
        DepartureAirline = "United Airlines",
        ArrivalAirline = "Southwest Airlines",
        DepartureCity = "Denver",
        ArrivalCity = "Seattle",
        DepartureDate = "2024-05-05T09:00:00",
        FlightLength = "4 hours",
        Price = 380.75m,
    },
    new Flight
    {
        Id = 3,
        DepartureAirline = "British Airways",
        ArrivalAirline = "Lufthansa",
        DepartureCity = "London",
        ArrivalCity = "Frankfurt",
        DepartureDate = "2024-06-20T09:00:00",
        FlightLength = "2.5 hours",
        Price = 550.25m,
    },

    new Flight
    {
        Id = 4,
        DepartureAirline = "Qantas",
        ArrivalAirline = "Air Canada",
        DepartureCity = "Sydney",
        ArrivalCity = "Toronto",
        DepartureDate = "2024-07-15T09:00:00",
        FlightLength = "16 hours",
        Price = 650.80m,
    },

    new Flight
    {
        Id = 5,
        DepartureAirline = "Qatar Airways",
        ArrivalAirline = "Saudi Arabian Airlines",
        DepartureCity = "Doha",
        ArrivalCity = "Riyadh",
        DepartureDate = "2025-01-15T09:00:00",
        FlightLength = "2 hours",
        Price = 500.50m,
    },

    new Flight
    {
            Id = 6,
        DepartureAirline = "Lufthansa",
        ArrivalAirline = "Swiss International Air Lines",
        DepartureCity = "Munich",
        ArrivalCity = "Zurich",
        DepartureDate = "2025-02-05T09:00:00",
        FlightLength = "1 hour",
        Price = 380.20m,
    },
    new Flight
    {
                Id = 7,
        DepartureAirline = "Alitalia",
        ArrivalAirline = "Iberia",
        DepartureCity = "Rome",
        ArrivalCity = "Madrid",
        DepartureDate = "2025-03-20T09:00:00",
        FlightLength = "2.5 hours",
        Price = 420.80m,
    },

    new Flight
    {
        Id = 8,
        DepartureAirline = "Air India",
        ArrivalAirline = "Jet Airways",
        DepartureCity = "Delhi",
        ArrivalCity = "Mumbai",
        DepartureDate = "2025-04-10T09:00:00",
        FlightLength = "2 hours",
        Price = 300.60m,
    },

    new Flight
    {
        Id = 9,
        DepartureAirline = "Aer Lingus",
        ArrivalAirline = "Ryanair",
        DepartureCity = "Dublin",
        ArrivalCity = "London",
        DepartureDate = "2025-05-15T09:00:00",
        FlightLength = "1.5 hours",
        Price = 180.90m,
    },

    new Flight
    {
            Id = 10,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Taipei",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T10:30:00",
        FlightLength = "1 hours",
        Price = 550.90m,
    },

        new Flight
    {
        Id = 11,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Taipei",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T10:40:00",
        FlightLength = "5 hours",
        Price = 590.90m,
    },
    new Flight
    {
        Id = 12,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Taipei",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T09:00:00",
        FlightLength = "10 hours",
        Price = 990.90m,
    },
    new Flight
    {
        Id = 13,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T12:31:00",
        FlightLength = "4 hours",
        Price = 100.90m,
    },
    new Flight
    {
        Id = 14,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Taipei",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T18:30:00",
        FlightLength = "4 hours",
        Price = 888.90m,
    },
        new Flight
    {
        Id = 15,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T13:31:00",
        FlightLength = "1 hours",
        Price = 177.90m,
    },
            new Flight
    {
        Id = 16,
        DepartureAirline = "EVA Air",
        ArrivalAirline = "China Airlines",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T19:31:00",
        FlightLength = "2 hours",
        Price = 177.90m,
    },
    new Flight
    {
        Id = 17,
        DepartureAirline = "China Airlines",
        ArrivalAirline = "EVA Air",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T19:31:00",
        FlightLength = "2 hours",
        Price = 177.90m,
    },
        new Flight
    {
        Id = 18,
        DepartureAirline = "China Airlines",
        ArrivalAirline = "EVA Air",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T19:31:00",
        FlightLength = "1 hours",
        Price = 207.90m,
    },
      new Flight
    {
        Id = 13,
        DepartureAirline = "China Airlines",
        ArrivalAirline = "EVA Air",
        DepartureCity = "Honkong",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T12:31:00",
        FlightLength = "4 hours",
        Price = 100.90m,
    },
    new Flight
    {
        Id = 14,
        DepartureAirline = "China Airlines",
        ArrivalAirline = "EVA Air",
        DepartureCity = "Taipei",
        ArrivalCity = "Beijing",
        DepartureDate = "2024-04-10T18:30:00",
        FlightLength = "4 hours",
        Price = 888.90m,
    },

};

    [HttpGet("departure")]
    public IActionResult GetDepartureFlights(string? departureAirline = "EVA Air",
        string? departureDate = "2024-04-10",
        string? arrivalAirLine = "China Airlines",
        string sortBy = "price")
    {
        IEnumerable<Flight> requestedFlights = flights;

        if (departureAirline != null)
        {
            requestedFlights = requestedFlights.Where(x => x.DepartureAirline == departureAirline);
        }
        if (departureDate != null)
        {
            // Use DateTime.Date for date-only comparison
            requestedFlights = requestedFlights
                .Where(x => DateTime.Parse(x.DepartureDate).Date == DateTime.Parse(departureDate).Date);
        }
        if(arrivalAirLine != null)
        {
            requestedFlights = requestedFlights.Where(x => x.ArrivalAirline == arrivalAirLine);
        }

        switch (sortBy.ToLower())
        {
            case "departuretime":
                requestedFlights = requestedFlights.OrderBy(f => DateTime.Parse(f.DepartureDate));
                break;
            case "flightlength":
                requestedFlights = requestedFlights.OrderBy(f => ParseFlightLength(f.FlightLength));
                break;
            case "price":
                requestedFlights = requestedFlights.OrderBy(f => f.Price);
                break;
            default:
                return BadRequest("Invalid sort parameter. Use 'departuretime', 'flightlength', or 'price'.");
        }

        return Ok(requestedFlights);
    }

    [HttpGet("arrival")]
    public IActionResult GetReturnFlights(
    string departureDateofReturnFlight,
    int firstFlightId,
    string sortBy)
    {
        IEnumerable<Flight> requestedFlights = flights.Where(x => x.Id != firstFlightId);

        var firstFlight = flights.FirstOrDefault(x => x.Id == firstFlightId);

        if (firstFlight == null)
        {
            return BadRequest("Invalid departure flight ID");
        }
        
        if (firstFlight.DepartureAirline != null) //reverse direction of original flight
        {
            requestedFlights = requestedFlights.Where(x => x.ArrivalAirline == firstFlight.DepartureAirline);
        }
        if(firstFlight.ArrivalAirline != null) 
        {
            requestedFlights = requestedFlights.Where(x => x.DepartureAirline == firstFlight.ArrivalAirline);
        }
        if (departureDateofReturnFlight != null)
        {
            if (DateTime.Parse(departureDateofReturnFlight).Date == DateTime.Parse(firstFlight.DepartureDate).Date)
            {

                var minArrivalDateTime = DateTime.Parse(firstFlight.DepartureDate)
                               .AddHours(ParseFlightLength(firstFlight.FlightLength));


                requestedFlights = requestedFlights.Where(x => DateTime.Parse(x.DepartureDate) > minArrivalDateTime);
            }
            else
            {
                requestedFlights = requestedFlights
    .Where(x => DateTime.Parse(x.DepartureDate).Date == DateTime.Parse(departureDateofReturnFlight).Date);
            }


        }

        switch (sortBy.ToLower())
        {
            case "departuretime":
                requestedFlights = requestedFlights.OrderBy(f => DateTime.Parse(f.DepartureDate));
                break;
            case "flightlength":
                requestedFlights = requestedFlights.OrderBy(f => ParseFlightLength(f.FlightLength));
                break;
            case "price":
                requestedFlights = requestedFlights.OrderBy(f => f.Price);
                break;
            default:
                return BadRequest("Invalid sort parameter. Use 'departuretime', 'flightlength', or 'price'.");
        }

        return Ok(requestedFlights);
    }


   


    private static double ParseFlightLength(string flightLength)
    {
        // Assuming flightLength is in the format "X hours" or "Y minutes"
        var parts = flightLength.Split(' ');
        if (parts.Length == 2 && double.TryParse(parts[0], out var value))
        {
            return parts[1].ToLower() == "hours" ? value : value / 60; // Convert minutes to hours
        }

        // Fallback to a default value if parsing fails
        return 0;
    }
}

// Flight.cs
public class Flight
{
    public int Id { get; set; }
    public string DepartureAirline { get; set; }
    public string ArrivalAirline { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public string DepartureDate { get; set; }
    public string FlightLength { get; set; }
    public decimal Price { get; set; }
}

