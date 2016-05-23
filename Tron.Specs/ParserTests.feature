Feature: ParserTests
	In order to check parser features
	creeation of parser class


Scenario: I received up movement for player red
	Given the input 'rojo:arriba'
	When Input is parsed
	Then The function should return a 'Up' movement and 'rojo' Player

Scenario: I received down movement for player blue
	Given the input 'azul:abajo'
	When Input is parsed
	Then The function should return a 'Down' movement and 'azul' Player

Scenario: I received right movement for player red
	Given the input 'rojo:derecha'
	When Input is parsed
	Then The function should return a 'Right' movement and 'rojo' Player

Scenario: I received left movement for player blue
	Given the input 'azul:izquierda'
	When Input is parsed
	Then The function should return a 'Left' movement and 'azul' Player

