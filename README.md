# Angular Challenge 

## Objective 
Create an Angular app that fetches data from an API and visualizes it using Chart.js. The app 
should display a line chart representing the data. 

## Requirements 

Make a home screen that has the following list of weather forecasting options: 
- District of Columbia Forecast  ( LWX ) 
- Kansas Forecast ( TOP ) 
- Each option should redirect to  /weather with their corresponding identifier. ( Example: /weather/LWX, /weather/TOP ) 
- Fetch data from an API endpoint using an HTTP request in an Angular service and 

retrieve the temperatures forecasted from the response. 

- KANSAS: https://api.weather.gov/gridpoints/TOP/31,80/forecast
- COLUMBIA: https://api.weather.gov/gridpoints/LWX/31,80/forecast 

Parse the JSON response and extract the necessary data for the chart 
Implement a component that renders a line chart using Chart.js library 
Display the chart on a view in the Angular app, showing the data in a visually appealing 
manner 

Customize the appearance of the chart, including labels, colors, and tooltips 
