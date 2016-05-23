Feature: GameBoard
	No.

@mytag
Scenario: Create GameBoard
	Given I have width 5, height 6, String 's'
	When I create a new GameBoard
	Then each tile in the gameboard Should be 's'

Scenario: Mark Spot
	Given I have a GameBoard of width 5, height 6, with initial value of 's'
	When I mark spot x 0 y 0 and spot x 3 y 3 with 'a'
	Then Spot x 0 y 0 and spot x 3 y3 should be 'a'