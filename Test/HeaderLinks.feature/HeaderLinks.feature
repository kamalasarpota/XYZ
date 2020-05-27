Feature: HeaderLinks
	In order to view Header pages
	As a user
	I want to be able to click on those links

@HeaderLinks
Scenario Outline: Check Header Pages Loads
	Given I navigate to BBC
	When I click on <Header links>
	Then I see the <Header links> pages
Examples: 
| Header links |
| News         |
| Sport        |
| Weather      |