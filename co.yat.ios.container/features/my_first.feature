Feature: Example tests
	As an iOS developer
	I want to have a sample feature file
	Which will allow me to test my interface


  Scenario: View 1
		Given I wait to see "View One"
		And take picture
		
		When I touch the "Goto View Two" button
		Then I wait to see "View Two"
		And take picture
		
		When I touch the "Goto View One" button
		Then I wait to see "View One"
		And take picture