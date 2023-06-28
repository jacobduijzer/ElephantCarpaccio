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
2. Item Input
```text
    As a user 
    I want to see the number of items I entered
    So I know my item input is working correctly
```
3. Price per Item
```text
    As a user
    I want to see the price per item I entered
    So I know my price per item input is working correctly
```
4. Total price calculation (without tax)
```text
    As a user
    I want to see the total price (tax excluded)
    By using the following formula: number of items * price per item
    So I know the total price calculation works correctly
```
5. Total price calculation (with fixed tax percentage of 6.85%)
```text
    As a user 
    I want to see the total price, calculated with a fixed tax percentage
    By using the following formula: (number of items * price per item) * ((100 + tax value) / 100)
    So I can verify the tax calculation is correct
```
6. 2-Letter state code
```text
    As a user 
    I want to see the 2-letter state code I entered
    So I know my 2-letter state code input is working correctly
```
7. View tax rate table
```text
    As a user 
    I want to see the table with states and tax rates
    So I can verify my tax rates are correct
```
8. Tax for entered state
```text
    As a user
    I want to see the tax rate for the state I entered
    So I know that the tax lookup works correctly
```
9. Total price calculation including tax
```text
    As a user 
    I want to see the complete calculation including tax
    So I can use my application to calculate the total order price
```
10. Calculating a discount when ordering more than $1000 (fixed discount rate)
```text
    As a customer ordering for more than $1000 of items
    I want a discount of 3% be calculated
    So I pay less
```
11. View discount rate table
```text
    As a user 
    I want to see the table with discount rates
    So I can verify that my discount rates are correct
```
12. Total price calculation, with tax and discount
```text
    As a customer
    I want to see my total price, regarding discounts and taxes
    Which is calculated by the following formula: discount price + state tax
    So I know the final price of my order
```