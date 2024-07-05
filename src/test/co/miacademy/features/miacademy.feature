Feature: Applying to Mia Prep Online High School

  Scenario: Apply to Mia Prep Online High School
    Given Open Main Page
    When Click on Mia Prep Online High School Link
    Then Verify Mia Prep Online High School Page is opened
    When Click on Apply to Our School Button
    Then Verify Application Form Section "Parent Information" is opened
    When Fill in Parent Information with the following data
      | FirstName | LastName | Email          | Phone       | AddSecondParent | StartDate   |
      | Test      | User     | test@gmail.com | 49123456789 | No              | 01-Aug-2024 |
    And Click Next Button
    Then Verify Application Form Section "Student Information" is opened