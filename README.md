# Rock, Paper, Scissors App_

#### _Rock, Paper, Scissors App, 4/25/18_

#### By _**Andrew Lupton**_

## Description

_An app for two people to play the children's game, "Rock, Paper, Scissors." The objective is to "play" or show the sign which outranks your opponent's sign._

* _The program should accept an input from each play, for each turn, concurrently._
  * _Ex: player1 plays: rock && player2 plays: paper_

* _If the players play different signs, the program should determine the winning player based on the following rules: Rock > Scissors; Rock < Paper; Paper < Scissors._
  * _Ex: input: player1 plays: rock && player2 plays: scissors ; output: player1 is the winner_
  * _Ex: input: player1 plays: rock && player2 plays: paper ; output: player2 is the winner_
  * _Ex: input: player1 plays: paper && player2 plays: rock ; output: player1 is the winner_
  * _Ex: input: player1 plays: paper && player2 plays: scissors ; output: player2 is the winner_
  * _Ex: input: player1 plays: scissors && player2 plays: paper ; output: player1 is the winner_
  * _Ex: input: player1 plays: scissors && player2 plays: rock ; output: player2 is the winner_

* _The program should declare a draw if both players play the same sign._
  * _Ex: input: player1 plays: rock && player2 plays: rock ; output: the turn is declared a draw_
  * _Ex: input: player1 plays: paper && player2 plays: paper ; output: the turn is declared a draw_
  * _Ex: input: player1 plays: scissors && player2 plays: scissors ; output: the turn is declared a draw_

* _The program should return the result of the turn to the players._

* _The program should reset after each turn so that the players can play again._  



## Setup/Installation Requirements

* _Clone or download the repository._
* _Open the console and move to the RockPaperScissors project directory_
* _Execute "dotnet restore" in the console._
* _Execute "dotnet run" in the console._
* _Open a web browser._
* _Navigate to "localhost:5000" into the address bar._

## Known Bugs

_Currently the app doesn't have a front end._

## Support and contact details

_If you have any questions, email me at aflupton@gmail.com_

## Technologies Used

_C#/.NET, HTML, CSS/Bootstrap_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Andrew Lupton_**
