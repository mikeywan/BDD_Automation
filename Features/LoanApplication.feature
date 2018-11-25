Feature: LoanApplication
	In order to buy something nice now
	As a cash poor customer
	I want to borrow money so I don't have to wait

@smoke @daily
Scenario: Application completed successfully
	Given I am on the loan application screen
	And I enter a first name of Sarah
	And I enter a second name of Smith
	And I select that I have an existing loan account
	And I confirm my acceptance of the terms and conditions
	When I submit my application
	Then I should see the applicaiton complete confirmation for Sarah

@regression @weekly
Scenario: Cannot submit application unless terms and conditions accepted
	Given I am on the loan application screen
	And I enter a first name of Gentry
	And I enter a second name of Jones
	And I select that I have an existing loan account
	When I submit my application
	Then I should see an error message telling me I must accept the terms and conditions
