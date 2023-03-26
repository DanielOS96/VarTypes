# CoinCollectorDemo

A simple Unity project demonstrating the concepts of value and reference types, as well as the stack and heap, in the context of a basic coin collecting game. The player moves around the scene to collect coins and increase their score.

## Game Mechanics

- The player moves using the arrow keys or the WASD keys.
- Coins are scattered around the scene.
- When the player collides with a coin, the coin is collected, and the player's score increases.
- The GameManager script manages the game state and the player's score.

## Scripts

This project contains three main C# scripts:

1. **PlayerController.cs**: Controls the player's movement using a Rigidbody component.
2. **Coin.cs**: Handles the behavior of the coins, including the OnTriggerEnter event to detect player collision and updating the score.
3. **GameManager.cs**: Manages the game state and the player's score, showcasing the use of value and reference type variables and their relationship with the stack and heap.

## Setup

1. Clone this repository or download the project files.
2. Open the project in Unity.
3. Open the SampleScene from the Assets/Scenes folder.
4. Click the Play button to test the game in the Unity editor.
