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

## Getting Started

1. Clone the repository
2. Build and run the console application
3. Follow code requirements for future web app migration

---

## License

This project is for educational purposes.
