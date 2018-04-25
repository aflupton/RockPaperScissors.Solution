# Rock, Paper, Scissors App_

#### _Rock, Paper, Scissors App, 4/25/18_

#### By _**Andrew Lupton**_

## Description

_An app that finds the base Scrabble score of any word entered into the user interface._

* _The program should use the following values to score words given by the user._
  * _Ex: input: "A", "E", "I", "O", "L", "N", "R", "S", "T" ; output: "1 point"_
  * _Ex: input: "D", "G" ; output: "2 points"_
  * _Ex: input: "B", "C", "M", "P" ; output: "3 points"_
  * _Ex: input: "F", "H", "V", "W", "Y" ; output: "4 points"_
  * _Ex: input: "K" ; output: "5 points"_
  * _Ex: input: "J", "K" ; output: "8 points"_
  * _Ex: input: "Q", "Z" ; output: "10 points"_

* _The program should calculate word values by adding together the values of each individual character._

* _The program should only accept standard letters of the English alphabet, and should return an input error for non-alphabetic characters and numbers._
  * _Ex: input: "$369" ; output: "Please enter a standard scrabble word."_
  * _Ex: input: "fr1D4y" ; output: "Please enter a standard scrabble word."_

* _The program should treat lower-case and upper-case letters as equivalent._
  * _Ex: input: "START" || "start" ; output: "Your score is: 5"_

* _The program should handle single-letter inputs._
  * _Ex: input: "i"/"I" or "a"/"A" ; output: "Your score is: 1"_

* _The program should handle multiple-letter inputs._
  * _Ex: input: "esquire" ; output: "Your score is: 16"_



## Setup/Installation Requirements

* _Clone or download the repository._
* _Open the console and move to the ScrabbleScore project directory_
* _Execute "dotnet restore" in the console._
* _Execute "dotnet run" in the console._
* _Open a web browser._
* _Navigate to "localhost:5000" into the address bar._

## Known Bugs

_Currently the app is without a front end._

## Support and contact details

_If you would like to contact me for any further information, email me at aflupton@gmail.com_

## Technologies Used

_C#, HTML, CSS/Bootstrap_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Andrew Lupton_**
