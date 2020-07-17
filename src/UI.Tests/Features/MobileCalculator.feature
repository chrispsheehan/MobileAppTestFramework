Feature: Mobile_Calculator

    I would like to check that this app can add

Background: Check the app has loaded
    Given The app has loaded and is responsive

Scenario: Add_Two_And_Two_Corectly
    When I add two and two
    Then I should see four
    