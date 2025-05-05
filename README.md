# 🌡️ **Temperature Sensor System**

A simple C# console app that simulates a temperature monitoring system using the **Publisher-Subscriber pattern**.

## 📌 **Features**

- Set and change the temperature using a simulated **sensor**.
- Display the current temperature automatically.
- Trigger an **alarm** if the temperature exceeds a configurable threshold.
- Demonstrates principles of **clean architecture** and **SOLID design**.

## 🧠 **Concepts Used**

### Design Pattern:
- **Publisher-Subscriber (Observer)**: The `Sensor` class (Publisher) sends temperature updates, and `Display` and `Alarm` (Subscribers) react to those updates.

### SOLID Principles:
- **Single Responsibility Principle (SRP)**: Each class has a clear, single responsibility.
- **Open/Closed Principle (OCP)**: The system is open for extension (new subscribers can be added) but closed for modification.

## 📁 **Project Structure**

- **Sensor**: Simulates a temperature sensor and publishes temperature events.
- **Display**: Subscribes to temperature changes and displays the current value.
- **Alarm**: Subscribes to temperature changes and triggers an alarm if it exceeds a predefined threshold.
- **Broker**: Acts as a middleman between publishers and subscribers, managing communication.
- **tempargs**: Custom event argument class to pass temperature values between components.

## 📸 **Sample Output**

![Sample Output](https://github.com/user-attachments/assets/42a4931f-4cc4-48d3-b850-b21674d199b3)
