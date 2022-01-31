@EndDrive
Feature: Filter

Scenario: Filter returns what I have search
	Given I am in the first page 
	And I tipe in the filter "Ball"
	When I press the "search icon"
	Then the result should be "Ball"