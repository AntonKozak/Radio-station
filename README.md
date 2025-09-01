# How to Start the App and Open Swagger

1. Open a terminal in the `src/RadioStationApi` directory.
2. Run the app with:

```bash
dotnet run
```

3. Once running, open your browser and go to:

- http://localhost:5001/swagger/index.html

4. Use the Swagger UI to explore and test the API endpoints for schedule data.

# Radio Station Scheduler

An assignment project for building a scheduling system for a radio station. The station runs a 24/7 stream, featuring live sessions, pre-recorded spoken material, and music. This system helps the station function smoothly by automating and managing its broadcast schedule.

---

## Features

- Schedule content up to seven days in advance
- 24/7 continuous streaming
- Automatic fallback to music when no other content is scheduled
- Support for:
  - Pre-recorded reportage
  - Live studio sessions (with host/guest logic and studio selection)

---

## Scheduling Rules

| Rule           | Description                                                     |
| -------------- | --------------------------------------------------------------- |
| Calendar Days  | New day starts at 24:00                                         |
| Stream         | Runs 24 hours per day                                           |
| Fallback       | Music plays if no other content is scheduled                    |
| Content Types  | Pre-recorded reportage, Live studio sessions                    |
| Studio Booking | Studio 1 for single host (cheaper), Studio 2 for other sessions |
| Guest Sessions | Additional cost for guest transport                             |

---

## Code Requirements

- Start as a console application (web app coming soon)
- Focus on scheduling classes, avoid direct Console usage in core logic
- Economy tracking is not required (may be added later)
- Use strong typing (classes) for all scheduled data
- Daily schedule can be represented as a list of lists

---

## How the Code Works

The project is structured to model a radio station's scheduling system using strong typing and modular design:

- **Entities**: Core classes like `ScheduleEntry` and `DailySchedule` represent scheduled content and daily schedules. Each entry includes type (music, live session, reportage), timing, host/guest, and studio info.
- **Interfaces**: The `IScheduler` interface defines methods for adding schedule entries and retrieving schedules for a week or a specific day.
- **Services**: The `SchedulerService` implements scheduling logic, manages a weekly schedule, and ensures fallback to music when no other content is scheduled. It loads mock data for demonstration and testing.
- **Mock Data**: The `MockScheduleData` class provides sample schedules for a week, including live sessions, reportage, and music fallback, so you can visualize and test the system.
- **Controllers**: The `ScheduleController` exposes API endpoints to view the weekly and daily schedule. Swagger UI is enabled for easy API testing and visualization.

To see the schedule data, run the web API and open Swagger UI in your browser. You can interact with endpoints to get the weekly or daily schedule, all powered by mock data for demonstration.

---

## License

This project is for educational purposes.
