Jerrod Packard
January 11, 2024
Mini Challenge Eight to Ten - Endpoints
Created a web api with five endpoints; one that outputs a magic 8 ball response from 8 unique responses; three endpoints for a number guessing game that accepts user input and outputs a response if the user's number is higher or lower than the number guessed, and another endpoint for a restaurant picker that accepts user input and outputs a randomly generated restaurant.
Peer review: 
Peer review comments: 









Pseudo Code:
Magic 8 Ball:
    We will need to accept user input for a question.
    We will need to create an array filled with 8 strings of unique responses.
    We will need to create a randomly generated number between 0 and 7.
    We will need to output one of the 8 responses.

Guess It:
    We will need to accept user input for user's guess and validate that it is a number.
    We will need to randomly generate a number between 1 and 10 for easy mode, 1 and 50 for medium mode, and 1 and 100.
    We will need to compare user input with randomly generated number.
    We will need to output if the user input is higher, lower, or equal to randomly generated number.

Restaurant Picker:
    We will need to accept user input for a category.
    We will need to create three arrays each filled with 10 restaurants.
    We will need to create a randomly generated number between 0 and 9.
    We will need to output one of the 10 restaurants of the category the user chose.