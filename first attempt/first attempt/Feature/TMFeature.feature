Feature: TMFeature

As a TurnUp protal admin
I would like to create, edit and delete time and material records
So that I can manage employee' time and materials successfully


Scenario: create time&material records with valid details
	Given I login to turnup portal successfully
	When I navigate to Time&Material page
	And I create a new time/material record
	Then A new T&M record should be create successfully
