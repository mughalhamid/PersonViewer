# 🌤️ Angular Weather Forecast Challenge

## 🎯 Objective
Build an **Angular application** that fetches weather forecast data from an API and visualizes it using **Chart.js**.  
The app should display a **line chart** representing the temperature forecast.

---

## 📋 Requirements

### 🏠 Home Screen
- Create a home page that lists the following forecast options:
  - **District of Columbia Forecast (LWX)**
  - **Kansas Forecast (TOP)**
- Each option should navigate to its respective route:
  - `/weather/LWX` for District of Columbia  
  - `/weather/TOP` for Kansas

---

### 🌐 API Integration
- Use an **Angular service** to make HTTP requests and fetch forecast data from these endpoints:
  - **Kansas:** `https://api.weather.gov/gridpoints/TOP/31,80/forecast`
  - **District of Columbia:** `https://api.weather.gov/gridpoints/LWX/31,80/forecast`
- Parse the JSON response and extract the **temperature data** for visualization.

---

### 📊 Data Visualization
- Implement a dedicated **Chart component** that renders a **line chart** using **Chart.js**.
- Display the chart on the weather view (`/weather/:id`) with clear labels and data points.
- Customize the chart’s appearance, including:
  - Axis labels  
  - Line and background colors  
  - Tooltips for better data insight  

---

## ✅ Expected Outcome
A responsive and visually appealing Angular app that allows users to:
- Select a forecast location  
- Fetch live weather data  
- View temperature forecasts as an interactive **Chart.js line chart**

---

### 🛠️ Suggested Tech Stack
- **Frontend:** Angular 17+
- **Charts:** Chart.js
- **Styling:** TailwindCSS / SCSS (optional)

---

### 💡 Bonus (Optional)
- Add
