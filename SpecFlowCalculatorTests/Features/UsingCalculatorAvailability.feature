Feature: UsingCalculatorAvailability
In order to calculate MTBF, MTTR, MTTF, and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
Given I have a calculator
When I have entered 200 hours for MTTF and 50 hours for MTTR into the calculator and press MTBF
Then the MTBF result should be 250 hours

@Availability
Scenario: Calculating Availability
Given I have a calculator
When I have entered 210 hours for MTBF and 200 hours for MTTF into the calculator and press Availability
Then the availability result should be 95.2%

@Availability
Scenario: Calculating MTTR
Given I have a calculator
When I have entered 250 hours of total downtime and 5 failures into the calculator and press MTTR
Then the MTTR result should be 50 hours

@Availability
Scenario: Calculating MTTF
Given I have a calculator
When I have entered 1000 hours and 5 failures into the calculator and press MTTF
Then the MTTF result should be 200 hours






