# PROJECT_STRUCTURE.md

## Folder Structure

```
horror-fps-game/
├── assets/                   # Contains all game assets like models, textures, sounds, etc.
│   ├── models/               # 3D models of characters, props, and environments
│   ├── textures/             # Texture images and maps
│   └── audio/                # Sound effects and music tracks
│
├── src/                     # Source code for the game
│   ├── main/                 # Main game files and logic
│   ├── scenes/               # Different game scenes or levels
│   ├── entities/             # Game entities and components
│   └── utils/                # Utility functions and helpers
│
├── docs/                    # Documentation related to the project
│   ├── design/               # Design documents and assets
│   └── api/                  # API documentation (if applicable)
│
├── tests/                   # Unit tests and integration tests
│   └── mocks/                # Mock data for testing
│
├── build/                   # Build files and outputs
│
├── .gitignore               # Git ignore file
├── LICENSE                   # Project license
└── README.md                 # Project overview and instructions
```

## Organization
- **assets/**: All the media and assets related to the game.
- **src/**: The heart of the game, containing source code and game logic.
- **docs/**: Comprehensive documentation for developers and users.
- **tests/**: Automated tests to ensure code quality and functionality.
- **build/**: Output of the build process is kept here. 

### Notes
- Make sure to keep the structure clean and organized for better collaboration. 
- Update this documentation as needed to reflect the current state of the project.