# Elephant Carpaccio

The [Elephant Carpaccio exercise](https://alistair.cockburn.us/coming-soon/) is a great way for software people to practice & learn how to break stories into really thin vertical slices. It also leads to interesting discussions about quality and tech practices. The exercise was invented by Alistair Cockburn. We’ve cofacilitated it a bunch of times and we encourage people to run it everywhere. This is a detailed (shu-level) facilitation guide based on how Alistair runs it plus some minor adaptations from Henrik. The exercise takes 90-120 minutes, and scales well. We normally do it with 10-20 people but have also done it with groups up to 30. 

## Links

Because the original documents might disappear, I've created PDF's out of the original documents. I have added links to the original documents too.

* [Exercise (PDF)](./docs/ElephantCarpaccioExercise.pdf)
* [Handout (PDF)](./docs/ElephantCarpaccioHandout.pdf)
* [Official Exercise document](https://docs.google.com/document/d/1TCuuu-8Mm14oxsOnlk8DqfZAA1cvtYu9WGv67Yj_sSk/pub)
* [Official Handout](https://docs.google.com/document/d/1Ls6pTmhY_LV8LwFiboUXoFXenXZl0qVZWPZ8J4uoqpI/edit)

## User stories

1. Project Setup
```text
    As a developer
    I want to see a "Hello, Customer!" message
    So I know my setup is working
```
2. Number of items as input parameter
```text
    As a developer
    I want to be able to provide the calculator with a number of items
    So I know I can use user input for my calculator
```
3. Price per item as input parameter
```text
    As a developer
    I want to be able to provide the calculator with a price per item 
    So I know I can use user input for my calculator
```
4. Total price calculation (without tax) with input parameters
```text
    As a user
    I want to see the total price (tax excluded)
    By using the following formula: number of items * price per item
    So I know the total price calculation works correctly
```
5. Number of Items as user input
```text
    As a user 
    I want to see my input, the number of items, being used by the calculator
    So I know my item input is working correctly
```
6. Price per Item as user input
```text
    As a user
    I want to see the my input, the price per item, being used by the calculator
    So I know my price per item input is working correctly
```
7. Total price calculation (with fixed tax percentage of 6.85%)
```text
    As a user 
    I want to see the total price, calculated with a fixed tax percentage
    By using the following formula: (number of items * price per item) * ((100 + tax value) / 100)
    So I can verify the tax calculation is correct
```
8. Tax percentage as input parameter, used for calculation
```text
    As a developer
    I want to be able to provide the calculator with a tax amount
    So I know I can use user input for my calculator
```
9. 2-Letter state code as input to select tax rate
```text
    As a user 
    I want to enter a 2-letter state code and see the corresponding tax rate being used
    So I can calculate the correct tax for the retail price
```
10. Calculating a discount when ordering, using multiple discount rates
```text
    As a customer ordering 
    I want a discount, based on the total amount of my order
    So I pay less
```
11. Creating a menu with options
```text
    As a user
    I want my application to have a menu with options
    So I can use it for calculations or close the application
```
12. View tax rate table
```text
    As a user 
    I want to have a menu option to see all tax rates
    So I can verify my tax rates are correct
```
13. View discount rate table
```text
    As a user 
    I want to have a menu option to see all discount rates
    So I can verify that my discount rates are correct
```
14. Tax rates from a json file
```text
    As a developer 
    I want to select tax rates from a json file
    So I can change the rates without changing the application
```
15. Discount percentages from a json file
```text
    As a developer 
    I want to select discount percentages from a json file
    So I can change the discount percentages without changing the application
```