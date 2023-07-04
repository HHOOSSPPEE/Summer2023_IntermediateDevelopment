### **2023 Spring** - Chengyu Huang
### *Assignment 3* - collecte
Link to game: (itch link)
https://pigeon-hcy.itch.io/igd-collect

## **Debrief**
In at least 400 words, write a debrief. You must write a reflection on your assignment. In addition to specific requirements stated for the assignment, you must answer the following:

- What did you end up making?
- Which of the game’s aspects did you like about this project?
- What resources and/or comments were most helpful to you?
- What will you repeat or do differently next time?

I ended up with an interactive UI with four elements: volume settings, view currently held cards, and credit, as well as a button that rotates the background to drop cards when the player clicks it. The spinning cards have physical effects, and each time they fall, the position and angle are different. In addition, clicking the button will also increase the counter on the scene by 50, which is used to calculate how much money the player has spent to open the card pack. To convey the theme of collect, I made the game a process of collecting an extremely rare card in magic, and each time the player clicks the open park button, a counter is added to show how much money the player has spent. But no matter how much money the player spends, they can't collect that extremely rare card. What I like most are the cards that spin and fall, which fall at different locations, speeds, angles, and rotation speeds each time. At the same time, every time the player clicks the button, the position of those cards will be reset and then randomized and fall again. Then the better use should be volume control and TA said if something is turned off after execution, the sound will not be played, so should make a gameobject for playing sound effects, so that when closed just play the sound effects on that. The next thing that will definitely be used is the UI and some of my attempts at physics, and those attempts at physics can definitely be used next time. For example, let those cards fall using rigidbody. first of all, in order to make the cards fall slowly, I modified their gravity constants. Let them have a different gravity constant. This will make them fall more slowly. Then I also modified their mass, which will also make them fall more slowly. Then I also modified their rotation angle by rigidbody, in order to make them rotate with time, I got the game time and increase the rotation angle with time, so as to achieve the purpose of rotating with time. I can also use in the next time. The last thing I use is to change the elements on the UI through code, although it's said that here it's just using the button to change it. But I can change things on the UI with code. Meaning I can use this for things like the player's life value.


Please do not answer these questions individually, but include it in a paragraph format.

## **Self Evaluation**
In addition to the debrief, the Self Evaluation is an opportunity for you to talk about your work. You must rate each aspect of your project as a 1 - 5 or Pass/Fail (where appropriate), as well as write a short 1-2 sentence elaboration to justify your score, in the following areas:


**Execution** (Did your project meet the theme you gave it?) - 4

*Write your elaboration within the asterixis*

I think my project is still more in line with my theme collect, because the whole process is still the process of collecting a card. But because of the lack of some background some custom font modification, and does not highlight the collection of the feeling, perhaps the main menu should be the card store, collection interface is the card book. On the theme is still lacking a little.

**Scope** (How well do you feel you scoped your game?) - 4

It was a little bit not what I expected, but actually it was still in the expression of the theme, just like I said before. Because I wanted to express the theme of collect orally, but I still fell a little short, so I deducted a point for myself.

*Write your elaboration within the asterixis*


**Overall** - Pass/Fail Pass

Although there is a lack in the theme but still basically in line with what I imagine, if there is more time I should be able to do better
