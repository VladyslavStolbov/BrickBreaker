# BrickBreaker

## Minimum Viable Product (MVP) for a game

- [X] Functional Paddle: The player can control the paddle's horizontal movement.
- [X] Functional Ball: The ball moves and bounces off walls and the paddle.
- [X] Brick Destruction: The ball destroys bricks upon collision.
- [X] Scoring System: Keep track of the player's score.
- [X] Lives System: Implement a basic lives system.

## Additional features

- [X] Minimal Sound Effects

## ToDo

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
- [X] Game Logic
  - [X] Implement game over conditions:
    - [X] Track the number of lives.
    - [X] End the game when the player runs out of lives.
  - [X] Create a game manager:
    - [X] Manage game state (start, playing, game over).
    - [X] Reset the game when needed.
- [X] UI
  - [X] Design and implement the user interface:
    - [X] Add a score display.
    - [X] Show the number of lives remaining.
    - [X] Include a game over screen.
- [X] Testing and Debugging
  - [X] Test the game thoroughly:
    - [X] Ensure all mechanics work as intended.
    - [X] Debug any issues that arise during testing.
- [X] Polish and Optimization
  - [X] Refine game elements:
    - [X] Fine-tune paddle and ball movement.
- [X] Refactor Code 
