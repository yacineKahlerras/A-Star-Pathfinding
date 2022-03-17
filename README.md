![Design and Development](https://github.com/yacineKahlerras/A-Star-Pathfinding/blob/main/PathExample.jpg)

# About
this is an A* pathfinder that can use area preferences (like sticking to a road and avoinding mud areas for example) by having movement penalties associated with certain areas that you can put into a layer

# Video Showcase
this is a video showcasing the different stuff that you can do with it


<a href="https://www.youtube.com/watch?feature=player_embedded&v=wNiQDz2-Mu8
" target="_blank" rel="noopener noreferrer"><img src="https://github.com/yacineKahlerras/A-Star-Pathfinding/blob/main/PathExample.jpg" 
alt="IMAGE ALT TEXT HERE" width="240" height="150" border="180" /></a>

# Tutorial

### I-Creating Spline

1- Create an empty object in the scene and add the script to it called SplineComponent (Assets/SplineMeshGenerator/Scripts/SplineComponent.cs)

2- Now You can modify the spline by selecting one of the Anchor points and moving them or The Control points once the anchor point is selected

3- SHIFT + LEFT-CLICK = adds an anchor point to the spline

4- In the spline component Buttons :
  * Closed = you can select it to choose between an open or closed spline
  * Center arround object = re-posiotions spline to the transform position of the object
  * Flatten x/y/z = flattens the spline on one of the axes
  * Change color = changes the color for one of the spline elements

5- To Make an object follow the spline just see the Paper and Train examples in the sample scene

### II-Making a spline mesh

1- Create an ampty object with a mesh filter on it and give it a flat 3D shape

2- Now add a SplineMesh script to it that you'll find in (Assets/SplineMeshGenerator/Scripts/Mesh/SplineMesh.cs)

3- Now Select the vertices of the flat 3D shape and then give it how many edge loops do you want in the mesh and the Threshhold angle for the shape's smootheness

4- Press Play to see the shape that is created, you can also scale the edge loops in the inspector

5- See the Mesh Generator example in the Sample Scene
