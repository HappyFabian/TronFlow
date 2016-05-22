Feature: FileReaderTests
	In order to avoid file mistakes
	I want to check the functionality of File Reader

@mytag
Scenario: A loaded file reader that still has lines and called the function GetNextLine should return a string.
	Given An existing file <filePathName> that still has lines
	When Called the function GetNextLine
	Then The function should return a string