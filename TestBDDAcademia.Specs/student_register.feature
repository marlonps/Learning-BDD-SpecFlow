Feature: student_register
	In order to check if a student is registered
	As a gym teacher
	I want to check if a student is already registered

@mytag
Scenario: Student is registered
	Given "Jorge" is registered
	When I consult "Jorge"'s data
	Then I should receive information about "Jorge"'s Name
