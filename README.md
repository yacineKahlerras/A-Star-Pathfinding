![Design and Development](https://github.com/yacineKahlerras/A-Star-Pathfinding/blob/main/PathExample.jpg)

# About
this is an A* pathfinder that can use area preferences (like sticking to a road and avoinding mud areas for example) by having movement penalties associated with certain areas that you can put into a layer

# Video Showcase
this is a video showcasing the different stuff that you can do with it


<a href="https://www.youtube.com/watch?feature=player_embedded&v=wNiQDz2-Mu8
" target="_blank"><img src="https://github.com/yacineKahlerras/A-Star-Pathfinding/blob/main/PathExample.jpg" 
alt="IMAGE ALT TEXT HERE" width="240" height="150" border="180" /></a>

# Tutorial

### I - Setting Up the environement

create a platform and obstacles and ADD colliders to them and group them into layers (for example : Grass, Mud, Road..ect)

### II - Setting up the Pathfinder

1 - create an empty game object and name it A* (or whatever you like)

2 - Add a script called 'Grid' to it and set up its parameters as you want them to be

### III - Setting up the seeker and the target

1 - create a cube or any other mesh with a collider and add the script 'Unit' to it and set up its parameters as you like

2 - for the target field in the 'Unit' script you can add the transform of the object that you want your seeker to seek
