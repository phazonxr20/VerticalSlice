# GDIM33 Vertical Slice
## Milestone 1 Devlog
### Devlog Question 1:

The scripting graph that I picked to answer this question was my playerMovement graph, which I have attached to my player character. As the name implies, it is meant to deal with my player character’s side-to-side movement, and the logic behind the player’s jump. It is split into these two sections. The side-to-side movement section of the graph works by defining a set speed variable, which is multiplied by the value of the player’s current x axis. This value is then multiplied further by the player’s current y-axis based on its current velocity. Both values are used together in a vector 2 create node, which is then pushed to a variable called move, which is a vector2 variable. This value is compared to the previous collected input, and if the x axis is greater, the character’s sprite position is faced to the right, as the player is moving to the right. If it is less than the previously collected input data, the player model is flipped to the left, as the player is moving to the left.

The second part of the graph is used for the jumping logic. The logic runs by taking the velocity of the player’s movement from the move variable and waiting for the player to input the jump button, which is the space bar. If this happens, it is used in an if statement with another part of the graph. Another variable, hits, is created as a list of raycast hits, where it is used to detect the player’s collision with the ground and their distance from it. If this distance is greater than 0 and the jump button is pressed, then the player is moved upward with a force for 7.5 in the y axis.

### Devlog Question 2:

My breakdown was updated to include my tilemap system, which is used in two different ways. Primarily, the map is used to paint the platforms that the player and the enemy robots will stand on. These platforms have colliders on them that work with the player movement for checking if the player is touching the ground. They can be painted around the game world at my leisure to create the level. The other usage of tilemaps I am using is to paint my enemy robots around the game as if they were a tilemap. By using the game object brush, I can instantiate clones of my enemies wherever I want on my existing tilemap, which includes all of the collision functionality that the original prefab had.

My state machine is used to control three states that my player has. The player is meant to pick up a power up during the level, which will give the player the ability to charge up their shot, which will make it more powerful, faster, and larger. I programmed the logic for how that will work in this state machine, but I haven’t decided what the power up will look like, so I didn’t include it in this milestone. It will be ready by milestone 2. However, the functionality of how it will work is here and working. The state machine has 3 states: not charging, charging, and charged. The not charging state is the start state, and is transitioned into when the player presses the left mouse button. This transitions it into the charging state, which sets up a timer for one and a half seconds, and if the player holds down the button for that amount of time, the shot that should be instantiated will instead come out as a faster, larger bolt shot with a different animation. If the player lets go of the button before this, the shot doesn’t come out. The timer is then reset as it transitions back to the not charged state. 

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
