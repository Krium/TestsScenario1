Feature: LogIn Tests
As a carrier provider, 
I want a username/password login on the tracking website, 
so that only genuine customers can access their tracking data.

	@testid-1
Scenario: Checks that for not-registered users displays login screen when they want to get access to website  
	Given Not-registered user opens 'http://traking.com' page
	Then User checks that he is presented with a login screen on 'http://traking.com/login' page
	
	@testid-2
Scenario: Checks that user can logged in to the website with valid credentials
	Given Not-registered user opens 'http://traking.com' page
	And User checks that he is presented with a login screen on 'http://traking.com/login' page
	When User enter a valid username 'userfortrack'
	And User enter a valid password 'pasTrack12'
	And User click on LogIn button
	Then User checks that he is logged in successfully and 'http://traking.com/profilePage' is opened and keyword 'Welcome' is dispayed