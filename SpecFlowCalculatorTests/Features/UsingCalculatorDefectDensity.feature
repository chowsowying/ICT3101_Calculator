Feature: UsingCalculatorDefectDensity

In order to assess the quality of the software and track the growth of our codebase over time
As a system quality engineer
I want to calculate the defect density of a system and the new total number of Shipped Source Instructions (SSI) for successive releases

@DefectDensity
Scenario: Calculating defect density
Given I have a calculator
When I have entered 150 defects and 60 KLOC into the calculator
Then the defect density result should be 2.5 defects/KLOC

Scenario: Calculating SSI for the second release
Given I have a calculator
When I have entered 60 KLOC as the initial size, 10 KLOC changed, 30% of it modified, and 1 KLOC deleted
Then the SSI result should be 66 KLOC

