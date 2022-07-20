## Entry Point
I have added an Restful endpoint with a HttpPost method: 

```bash
https://localhost:44389/api/calculate/tax
```

The request body should be like:

```json
{
    "VehicleType":"Car",
    "DateTimes":["2013-01-14 06:30:00", "2013-01-14 07:30:00", "2013-01-14 17:30:00"]
}
```

## Further Development
- Input data validation (Vehicle parameter is a string, the user can write anything.)
- Behavioral Tests
- Error Handling
- Logging
- Threading (API should be used by many users at the same time. And it should have been prepared for that.)
- API Authentication
- Healthchecks (monitoring)
- Database 
- Docker
