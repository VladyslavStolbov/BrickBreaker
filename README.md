# BrickBreaker

![](https://geps.dev/progress/60)

## Minimum Viable Product (MVP) for a game:
- [X] Functional Paddle: The player can control the paddle's horizontal movement.
- [X] Functional Ball: The ball moves and bounces off walls and the paddle.
- [X] Brick Destruction: The ball destroys bricks upon collision.
- [ ] Scoring System: Keep track of the player's score.
- [ ] Lives System: Implement a basic lives system.

## ToDo:
- [X] Project Setup
    - [X] Create a new Unity project.
    - [X] Set up your project structure:
        - [X] Create folders for assets (e.g., Materials, Prefabs, Scenes, Scripts).
        - [X] Import any necessary assets (textures, sound effects, etc.).
- [X] Scene Setup
    - [X] Design the game scene:
        - [X] Create the game board using Unity's GameObjects.
        - [X] Add a paddle at the bottom of the screen.
        - [X] Place bricks in a grid pattern at the top of the screen.
        - [X] Set up the camera and lighting.
- [X] Player Controls
    - [X] Implement paddle movement:
        - [X] Write a script to handle paddle movement based on player input (e.g., arrow keys or touch input).
- [X] Ball Mechanics
    - [X] Create the ball object:
        - [X] Instantiate a ball at the start of the game.
        - [X] Add physics components to the ball.
    - [X] Implement ball movement:
        - [X] Write a script to handle the initial ball movement.
        - [X] Add collision detection with walls and the paddle.
- [X] Brick Mechanics
    - [X] Implement brick destruction:
        - [X] Write a script to handle collisions between the ball and bricks.
        - [X] Remove destroyed bricks from the scene.
        - [X] Keep track of the player's score.
- [ ] Game Logic
    - [ ] Implement game over conditions:
        - [X] Track the number of lives.
        - [X] End the game when the player runs out of lives.
    - [ ] Create a game manager:
        - [ ] Manage game state (start, playing, game over).
        - [ ] Reset the game when needed.
- [ ] UI
    - [ ] Design and implement the user interface:
        - [ ] Add a score display.
        - [ ] Show the number of lives remaining.
        - [ ] Include a game over screen.
- [ ] Testing and Debugging
    - [ ] Test the game thoroughly:
        - [ ] Ensure all mechanics work as intended.
        - [ ] Debug any issues that arise during testing.
- [ ] Polish and Optimization
    - [ ] Refine game elements:
        - [ ] Fine-tune paddle and ball movement.
        - [ ] Adjust difficulty by changing brick layouts or ball speed
        - [ ] Add a different amount of score for different type of bricks.
        - [ ] Add sound effects and background music.
    - [ ] Optimize performance:
        - [ ] Profile and optimize code for better performance.
