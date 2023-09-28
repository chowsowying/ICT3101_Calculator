Feature: UsingCalculatorFactorial
In order to understand factorials
As a factorial enthusiast
I want to understand a variety of factorial operations

@Factorials
Scenario: Calculating factorial of a number
Given I have a calculator
When I have entered 5 into the calculator and press factorial
Then the factorial result should be 120

@Factorials
Scenario: Calculating factorial of zero
Given I have a calculator
When I have entered 0 into the calculator and press factorial
Then the factorial result should be 1

@Factorials
Scenario: Calculating factorial of a negative number
Given I have a calculator
When I have entered -1 into the calculator and press factorial
Then an error should be displayed saying "Factorial is undefined for negative numbers."
