# GDIM33 Vertical Slice
## Milestone 1 Devlog
### Devlog Question 1:

The scripting graph that I picked to answer this question was my playerMovement graph, which I have attached to my player character. As the name implies, it is meant to deal with my player character’s side-to-side movement, and the logic behind the player’s jump. It is split into these two sections. The side-to-side movement section of the graph works by defining a set speed variable, which is multiplied by the value of the player’s current x axis. This value is then multiplied further by the player’s current y-axis based on its current velocity. Both values are used together in a vector 2 create node, which is then pushed to a variable called move, which is a vector2 variable. This value is compared to the previous collected input, and if the x axis is greater, the character’s sprite position is faced to the right, as the player is moving to the right. If it is less than the previously collected input data, the player model is flipped to the left, as the player is moving to the left.

The second part of the graph is used for the jumping logic. The logic runs by taking the velocity of the player’s movement from the move variable and waiting for the player to input the jump button, which is the space bar. If this happens, it is used in an if statement with another part of the graph. Another variable, hits, is created as a list of raycast hits, where it is used to detect the player’s collision with the ground and their distance from it. If this distance is greater than 0 and the jump button is pressed, then the player is moved upward with a force for 7.5 in the y axis.

### Devlog Question 2:

<img width="960" height="720" alt="Basic 2D Mega Man-like platformer breakdown_Joshua Paxton-7" src="https://github.com/user-attachments/assets/6a4cd96d-eb13-4f89-875f-7bb980b0427c" />


My breakdown was updated to include my tilemap system, which is used in two different ways. Primarily, the map is used to paint the platforms that the player and the enemy robots will stand on. These platforms have colliders on them that work with the player movement for checking if the player is touching the ground. They can be painted around the game world at my leisure to create the level. The other usage of tilemaps I am using is to paint my enemy robots around the game as if they were a tilemap. By using the game object brush, I can instantiate clones of my enemies wherever I want on my existing tilemap, which includes all of the collision functionality that the original prefab had.

My state machine is used to control three states that my player has. The player is meant to pick up a power up during the level, which will give the player the ability to charge up their shot, which will make it more powerful, faster, and larger. I programmed the logic for how that will work in this state machine, but I haven’t decided what the power up will look like, so I didn’t include it in this milestone. It will be ready by milestone 2. However, the functionality of how it will work is here and working. The state machine has 3 states: not charging, charging, and charged. The not charging state is the start state, and is transitioned into when the player presses the left mouse button. This transitions it into the charging state, which sets up a timer for one and a half seconds, and if the player holds down the button for that amount of time, the shot that should be instantiated will instead come out as a faster, larger bolt shot with a different animation. If the player lets go of the button before this, the shot doesn’t come out. The timer is then reset as it transitions back to the not charged state. 

## Milestone 2 Devlog

### Devlog Question 1:

My complicating gameplay factor in my project is the charge shot that the player is supposed to gain in the game being used to defeat a boss at the end of the level. To build this, I plan on following these steps:

- Place the power up in the level (This involves creating a power up bubble and attaching a script to it that enables the boolean on my script machine. This will allow the player to then charge their shots.)
- Build a boss enemy (I will probably scale up one of my enemies for this milestone before creating a unique boss model. I will also need to attach movement scripts to it, as my current enemies dont move. I also will need to add a health system into the game, so that the charge shot actually helps the player deal more damage to the boss as the complicating gameplay factor.)

### Devlog Question 2:

The breakdown I wrote wasn't too helful for me, as I already knew the general process of what I was going to make. It was nice getting it out on paper, however. For next time, I will probably have a lot more to do that I don't know as well as I knew with this breakdown, in which my breakdown will be more useful in actually figuring out what needs to get done. 

### Devlog Question 3:

I am bridging visual scripting and code in my project in how I am using my charge shot ability pick up. The check for if the player interacts with it is built in c# code in the AbilityChargeCheck.cs script, but it triggers the boolean value in my state machine to change to be true, which allows for the state machine to start cycling through its three states, the no charge state, the charging state, and the charged state. This all allows for my complicating gameplay factor to work, which is getting a new ability to help defeat a boss easier.

<img width="745" height="480" alt="Screenshot 2026-05-15 at 5 14 07 AM" src="https://github.com/user-attachments/assets/1ce8a7c8-8772-4011-a0c8-9f21c591c30c" />

<img width="1395" height="497" alt="Screenshot 2026-05-15 at 5 14 43 AM" src="https://github.com/user-attachments/assets/3116efe7-bd41-4cd5-8721-5ed4b1b750ad" />

### Devlog Question 4:

My tilemap usage should be graded for this question. I built all of the platforms in the game with tilemaps, and I placed all of the non-boss enemies with the GameObject tilemap brush in the tilemap editor.

## Milestone 3 Devlog

<img width="709" height="376" alt="Screenshot 2026-05-28 at 12 53 29 AM" src="https://github.com/user-attachments/assets/5a1c36b4-7bb0-48d3-9431-a6f4bf5d6325" />

1. My ShaderGraph works mainly around the posterize and simple noise nodes, which I learned of by doing research online. The posterize node separates an image into separate UV tones of the same color. In my graph, I set the steps value of the node to 64, which split the tone value into 64 sections. The simple noise node adds random noise to the UV tones, which, from the image from the posterize node, creates a random, pixelated image of different UV tones, which fade in and out. These tones are modulated from multiplying the rain speed, rain density, and rain color variable nodes I added, which set the pixelated image to speed up in how it generates the random noise, sets how much of the pixelated image is shown based on the UV values, and sets the color of the image, respectively. This creates the illusion of falling rain drops from the sky, when it is actually the brightest percentage of UV values being shown. This percentage is about 25% of the brightest noise being shown. I made this into a material, which I then attached to a sprite attached to my camera. I am using the Cinemachine component to move the camera with the player, and now that the camera has the rain material as a child, it moves the rain along with it, showing the rain across the whole game.
2. In terms of my gameplay from my feedback, I made improvements on the general clarity of the game. I added in a flash that shows when an enemy is damaged for clarity. I also added in this flash to the player for when they are damaged as well. I also added in a flash that appears when the player holds down the shoot button for the charge shot ability to show that it is currently being charged. The flash goes away when the player shoots the charge shot. I also made the enemy bullets bigger for clarity’s sake. I have yet to create a screen for when the player dies yet due to my inexperience in it, but I will create it for my next milestone.
3. In terms of new content I added into the game, I added in another type of enemy that shoots back at the player: the Cyborg. This cyborg takes more damage than the standard turret enemies, and can turn around to shoot at the player. This allows the player to actually have a challenge while they traverse the level before the boss battle, as before, the player most likely wouldn’t die before they reach the boss because the normal turret enemies don’t fire back at the player.

## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
Player character model: https://assetstore.unity.com/packages/2d/environments/robot-shooting-game-sprite-free-93902
Charged shot projectile sprite: https://assetstore.unity.com/packages/2d/textures-materials/abstract/warped-shooting-fx-195246
Environment and enemies (purchased): https://assetstore.unity.com/packages/2d/environments/warped-city-2-200208

