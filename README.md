# Match!
Tech test done in c# using .net 8 console app and xunit tests.

## Game Setup
1. Choose a number of packs of playing cards, and combine them into a single deck.
2. Shuffle the deck.

## Playing the Game
1. Cards are played sequentially from the top of the deck into the pile.
2. If two cards played sequentially match (see "Match condition" below), the first player to declare "Match!" takes all the cards in the pile. For the purposes of this simulation, the program should choose a random player as having declared "Match!" first.
3. Play then continues with the next card in the deck, starting a new pile. 
4. The game ends when no more cards can be drawn from the deck and no player can declare "Match!". (Any remaining cards in the pile may be discarded.)
5. The player that has taken the most cards is the winner. The game may end in a draw.

## Match Condition
The match condition determines when two cards match for the duration of the game. There are three options:
- The suits of two cards must match  
  *Example:* "3 of hearts" and "5 of hearts" match because they are both hearts.
- The values of two cards must match  
  *Example:* "7 of hearts" and "7 of clubs" match because they both have the value 7.
- Both suit and value must match  
  *Example:* "Jack of spades" only matches another "Jack of spades"

## The Program
As input, the program should ask:
1. How many packs of cards to use for the deck
2. Which match condition to use

It should then simulate the game.

The program should output the results by either declaring the winner, or a draw.

## Glossary
- **Pack**: A complete set of 52 playing cards.
- **Deck**: The set of cards in play. This could be multiple packs, or a subset of cards from a single pack depending on the game being played.
- **Value**: The number or title value associated with a card. EG "one", "queen" or "ace".
- **Suit**: A pack is divided into 4 suits. The possible suits are
  - "clubs" ♣️,
  - "diamonds" ♦️,
  - "hearts" ♥️, and
  - "spades" ♠️

## User Stories
- As a player, I want to choose the number of playing cards packs, So I can control the length of the game.
- As a player, I want to choose the match condition, So I can control the rules of the game.
- As a player, I want to be shown the result of the game, So I know the result.

## Running the Program

### Prerequisites
- .NET SDK 8 installed on your machine.

### How to Run

1. Navigate to the project directory: ```cd CardGame ```

2. Build the game: ```dotnet build```

3. Run the game: ```dotnet run```

4. Follow the on-screen instructions to play the game:
![ALT TEX](https://github.com/bear99a9/CardGame/blob/main/ReadmeImageGame.png "Game ScreenShot")

### How to run the tests

1. Navigate to the project test directory: ```cd CardGame.Test ```

2. Run the tests: ```dotnet Test```

3. Results displayed like:
![ALT TEX](https://github.com/bear99a9/CardGame/blob/main/ReadmeImageTest.png "Testing ScreenShot")

## Improvements/ Todo
- [ ] Refactor out the end of the PlayGame class to use a seperate method make it more testable and reusable.
- [ ] Mock randmoness in the GameServiceShould to correctly test each outcome.
- [ ] Add global error handling.
- [ ] Refactor the for/ foreach loops in the CreateDeck to use a linq statement.
- [ ] The shuffle cards method could use the Fisher–Yates shuffle algorithm to improve performance.
- [ ] Look at the flow in the program.cs and add correct handling of errors and/ or pull the code out into a testable class.
