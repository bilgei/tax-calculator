## Tests
I have added unit tests and find out some bugs:
- TollFee calculation between 8:30 and 17:00
- Tax calculation for the "a vehicle that passes several tolling stations within 60 minutes is only taxed once." rule.
- There are no exempt applied for busses.

I fixed them all, after writing their tests. (TDD)

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

## Refactoring
With the power of having unit tests, I started to refactor my code and give the project its structure. 

I decided to apply DDD for making the structure more understandable and expandable.

I use Dependency Injection because I don't want my controller to depend on low-level implementation details.

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
