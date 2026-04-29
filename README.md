# 🚀 Mars Rover Terminal App

A command-line application that simulates controlling rovers exploring the surface of Mars. Built using test-driven development (TDD), this project focuses on clean architecture, problem-solving, and scalable design.

## 📖 Overview

This application models a grid-based plateau on Mars where multiple rovers can be deployed, navigated, and controlled using a sequence of commands.
Each rover receives instructions to rotate and move across the plateau, with its final position output once all commands have been executed.

## ✨ Features

- Create a configurable plateau (grid-based)
- Deploy multiple rovers with defined starting positions
- Process movement instructions (L, R, M)
- Sequential rover execution (avoids collisions in future extensions)
- Final position output for each rover
- Built using test-driven development (TDD)

## 🧠 How It Works

### Plateau

Represented as a grid with coordinates starting at (0,0)

Upper boundary is defined by user input

### Rover Position

Each rover has:

X and Y coordinates

A facing direction: N, S, E, W to represent North, South, East, West (the four cardinal compass points) respectively

```
Example
0 0 E
```

### Instructions
Command	Action

L	 = Rotate 90° left

R	 = Rotate 90° right

M	 = Move forward one grid point

▶️ Example Input
```
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
```

✅ Example Output
```
1 3 N
5 1 E
```

## 🛠️ Tech Stack
- C# 
- .NET
- NUnit (for testing)

## 📈 What I Learned

- Applying TDD in a real project
- Breaking down complex problems into manageable logic
- Designing clean, maintainable classes (Rover, Plateau, Navigation)
- Handling state and movement logic effectively

## 🚧 Future Improvements

- Collision detection between rovers
- Obstacle handling on the plateau
- User-friendly CLI interface
- Visual representation of the grid
- Logging and error handling improvements

## 💡 Why I Built This

I created this project as part of my software development training to strengthen my problem-solving skills and gain experience building structured, testable applications. It also helped me understand how to translate real-world rules into clean, maintainable code.

## ▶️ How to Run

- Clone the repository
- Open in your preferred IDE (e.g. Visual Studio)
- Build the solution
- Run the application via terminal

## 👩‍💻 Author

Jodie McLaughlin
