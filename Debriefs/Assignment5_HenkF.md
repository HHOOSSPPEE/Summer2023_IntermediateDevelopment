### **2023 Spring** - Henk F
### *Assignment 5* - Carrion Clone
Link to game: (https://henkfan.itch.io/snake)


## **Debrief**

For this assignment, I was left with the theme of "crawling." Though it may appear very obvious and straightforward, it does present some limitations in space for interesting twists and interpretations, as "crawling" is a verb that describes a specific action. In pursuit of creating a clone of a 2D game that would align with our theme, I discovered that "Carrion" seemed to be the ideal option. The game features a unique and fantastic crawling mechanic, making it synonymous with the theme of crawling. Finding such a perfect match, I decided to settle down and clone this game.
One aspect of my clone that I am really satisfied with is the movement mechanic. Given my skill level, replicating the movement of "Carrion" was no small feat, as it is considerably more complicated compared to many other 2D action games. After hours of investigation and research, my approach to cloning the movement involved creating an array of grappling hooks using Unity’s spring joints and line renderer. The spring joints act like grapples which pull the player towards the destination while the line renderer function handles animation calculations to make it look smooth. Initially, the grappling hooks were quite clunky and didn't function smoothly. However, as I increased the number of hooks and implemented raycasting with a radius for detection instead of a single line, the movement became much more refined and closer to the original game. Apart from the change of raycasting, I also implemented a minor movement where the player object will move towards the cursor when clicked to make the movement feel more responsive. 
While I am content with the current state of movement, I must admit that there are still some details I didn't replicate successfully, such as the procedural animations and precise firing of tentacles, where the monster in Carrion will precisely fire two tentacles when left-clicked. Nevertheless, considering my current skill set, I regard the clone as a success.
Another aspect of my clone that I am proud of is the procedurally generated tentacle animations and tails. This adds on to the juice aspect of my game where the player could feel the fluid speed created by my movement mechanic more vividly.  I learned about these animations from YouTube tutorials, which I found to be incredibly useful. They provided me with a fresh approach to creating animations.
In terms of feedback from my classmates, CY’s comments about color and landmarks were particularly insightful. They helped me reflect on the difficulties of my game where I perhaps should consider more on my accessibility.
If I were to undertake the task of cloning "Carrion" again, I would certainly repeat my process of creating grappling hooks and procedural animations. However, I might also consider altering the sprite to make it appear more monster-like, which would correspond better with the core mechanic of crawling.






## **Self Evaluation**

**Execution** - 5

The game I selected perfectly matched the theme of crawling and I created a close replication of its movement mechanic. I also figured out my own approach to creating movements like this using line renderer and spring joints.

**Scope**  - 5

As I’m mainly focused on the movement mechanic of Carrion, I didn’t over scope my visual aesthetics as I kept it simple and clean. The focus of the clone is clear and vivid where I didn’t spend much time making unnecessary sprites. As we are told to focus on specific aspects of our cloning games, I believe my scope is perfect.

**Overall** - Pass

I successfully created a close clone using my current skill set. The movement created by my approach is nearly identical from the original game. This is undoubtedly a success regarding the goal and objectives of this clone.