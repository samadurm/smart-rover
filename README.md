# Smart Rover
Project for MakeUC Hackathon 2020.

# Authors:
Micah Samaduroff <br>
Wei Xuan <br>
Chokpisit Kasemphaibulsuk <br>
Arnav Komaragiri <br>

# Introduction
Smart Rover is a Mars rover simulation that allows the user to navigate a real location on Mars. We chose the Curiosity Rover landing site from a sattelite photo from  https://trek.nasa.gov/mars, and converted that into a terrain. We then created a Rover model in Blender and added that to our simulation. Currently working is forward and horizontal movement, and camera movement is disabled for now. The Rover is equipped with a front camera which serves the operators viewpoint. <br>
<br>
Our goal for this project was to try to solve for the extreme latency involved with communicating with a Rover from Earth to Mars. Our idea was to implement a Machine Learning model into our simulation (thus the name Smart Rover), so that the operator could give coordinates to the rover, and it would go to those coordinates while avoiding craters, pits, rocks, etc. <br>
<br> 
However our hackathon was only 24 hours, and none of us had experience with Unity or C#. We ran out of time before we were able to integrate the Machine Learning model, and had some pitfalls with the movement. What we have working was submitted to the hackathon: https://devpost.com/software/smart-rover

# Technologies
- Unity
- C#
- Blender

# Launch
1. Ensure you have Unity installed
2. Clone this repository
3. Run the project from Unity
