Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Reliability
Scenario: Calculating Current Failure Intensity
Given I have a calculator
When I have entered the initial failure intensity is 10 failures/cpu-hr and It has experienced 50 failures and it will experience 100 failures in infinte time into the calculator and press Current failure intensity
Then the Current failure intensityresult should be 5 failures/cpu-hr

@Reliability
Scenario: Calculating Average Number of expected failure
Given I have a calculator
When I have entered the initial failure intensity is 10 failures/cpu-hr and It has experienced 50 failures and it will experience 100 failures in infinte time and failures are 10 CPU-hr into the calculator and press Average Number of expected failure
Then the Average Number of expected failure result should be 63 failures/cpu-hr
