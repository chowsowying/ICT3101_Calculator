Feature: UsingCalculatorLogReliability

In order to predict the rate of failure and expected failure in the software
As a system quality engineer
I want to use the Musa Logarithmic model to calculate the current failure intensity and calculate the average number of expected failures


@LogReliability
Scenario: Calculating current failure intensity using Musa Log model
Given I have a calculator
When I have entered 10 as lambda0, 0.02 as tether,and 50 as mu into the calculator
Then the failure intensity result should be 3.68


@LogReliability
Scenario: Calculating expected number of failures using Musa Log model
Given I have a calculator
When I have entered 10 as lambda0, 0.02 as tether, and 10 as tau into the calculator
Then the expected failures result should be 55

