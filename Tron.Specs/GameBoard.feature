Feature: GameBoard
	No.

@mytag
Scenario: Create GameBoard
	Given I have width 5, height 6, String 's'
	When I press create a new GameBoard
	Then each tile in the gameboard Should be 's'
