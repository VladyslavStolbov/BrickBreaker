# BrickBreaker

## Minimum Viable Product (MVP) for a game:
- [ ] Functional Paddle: The player can control the paddle's horizontal movement.
- [ ] Functional Ball: The ball moves and bounces off walls and the paddle.
- [ ] Brick Destruction: The ball destroys bricks upon collision.
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
- [ ] Player Controls
    - [ ] Implement paddle movement:
        - [ ] Write a script to handle paddle movement based on player input (e.g., arrow keys or touch input).
- [ ] Ball Mechanics
    - [ ] Create the ball object:
        - [ ] Instantiate a ball at the start of the game.
        - [ ] Add physics components to the ball.
    - [ ] Implement ball movement:
        - [ ] Write a script to handle the initial ball movement.
        - [ ] Add collision detection with walls and the paddle.
- [ ] Brick Mechanics
    - [ ] Implement brick destruction:
        - [ ] Write a script to handle collisions between the ball and bricks.
        - [ ] Remove destroyed bricks from the scene.
        - [ ] Keep track of the player's score.
- [ ] Game Logic
    - [ ] Implement game over conditions:
        - [ ] Track the number of lives.
        - [ ] End the game when the player runs out of lives.
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
        - [ ] Adjust difficulty by changing brick layouts or ball speed.
        - [ ] Add sound effects and background music.
    - [ ] Optimize performance:
        - [ ] Profile and optimize code for better performance.
