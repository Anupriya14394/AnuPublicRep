Feature: MMTDomesticTravel
	
@mytag
Scenario: MakeMyTrip DomesticTravel 
	Given Open the Chrome browser
	And User has entered the URL
	When I Fill in From and To city 
	Then Close the browser
