Feature: Example tests
	As an iOS developer
	I want to have a sample feature file
	Which will allow me to test my interface


  Scenario: Default
		Given I am on View One
    Then I should see "View One"
		
  Scenario: View Transition
		Given I am on View One
		And I touch "Show View Two"
    Then I wait to see "View Two"