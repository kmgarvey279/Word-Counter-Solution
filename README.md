# _Word-Counter_

#### _The program takes both a single word, and a sentence from the user as input and then returns a number corresponding with the number of times the inputted word appears in the inputted sentence, 04/26/2019_

#### _***Kevin Garvey***_

## Description

_Specifications:
*1) The RepeatCounter constructor creates a new instance of the RepeatCounter object. This only tests whether the object itself was successfully constructed and not any of the object's values or methods. It is therefore the simplest possible test.
input: RepeatCounter newRepeatCounter = new RepeatCounter("cat", "The cat came back.");
output: newRepeatCounter.GetType() == RepeatCounter;
*2) The RepeatCounter returns the inputted word using getter methods. This pair of tests are the next to be performed because they only checks that the inputted arguments are successfully passed into the object and that the getter methods are functioning correctly.
input: newRepeatCounter.GetWord();
output: "cat";
*3)The RepeatCounter returns the inputted sentence using getter methods. This pair of tests are the next to be performed because they only checks that the inputted arguments are successfully passed into the object and that the getter methods are functioning correctly.
input: newRepeatCounter.GetSentence();
output: "The cat came back.";
*4) The RepeatCounter takes a single lower-case character as a 'Word' argument and a single lower-case character as a 'Sentence' argument and returns '1' if both are identical. This is the first test to perform computations on the inputted values and uses identical values to make sure that the basic functionality to check for matches is in place.
input: RepeatCounter newRepeatCounter = new RepeatCounter("c", "c");
output: 1;
*5) The RepeatCounter takes a single lower-case character as a 'Word' argument and a single lower-case character as a 'Sentence' argument and returns 'false' if both are different. This confirms that the program can return true negatives as well as the previously demonstrated true positives.
input: RepeatCounter newRepeatCounter = new RepeatCounter("c", "d");
output: false;
*6) The RepeatCounter takes identical strings in both the 'Word' parameter and the 'Sentence' parameter and returns 'true'. This is a more complex version of the single character test and evaluates the ability of the program to loop over identical strings and correctly identify their equivalence.
input: RepeatCounter newRepeatCounter = new RepeatCounter("cat", "cat");
output: true;
*7) The RepeatCounter takes different strings in both the 'Word' parameter and the 'Sentence' parameter and returns 'false'. Like the single character test, this tests that the program can identify both true negatives and true positives.
input: RepeatCounter newRepeatCounter = new RepeatCounter("cat", "dog");
output: false;
*8) The RepeatCounter takes a single lower-case character as a 'Word' argument and a lower-case string as a 'Sentence' argument and returns the number of times the character appears in the word. This tests that the counter is able to correctly track the number of matching characters.   
input: RepeatCounter newRepeatCounter = new RepeatCounter("c", "The cat came back.");
output: 2;
*9) The RepeatCounter takes an upper-case character as a 'Word' argument and a lower-case string as a 'Sentence' argument and returns the number of times the character appears in the word (regardless of casing). This is slightly more complex then the previous test because it is case insensitive.
input: RepeatCounter newRepeatCounter = new RepeatCounter("C", "The Cat in the Hat came back.");
output: 2;
*10) The RepeatCounter takes a multiple character string as a 'Word' argument and a multiple word string as a 'Sentence' argument and returns the number of times the word appears in the sentence. This looks at matching words rather then just characters and combines all of the previously tested behavior.
input: RepeatCounter newRepeatCounter = new RepeatCounter("cat", "Does the cat from 'The Cat in the Hat' have a real name?");
output: 2;
*11) The RepeatCounter takes a multiple character string as a 'Word' argument and a multiple word string as a 'Sentence' argument and returns the number of times the word appears in the sentence without including instances in which the word appears as part of a longer word.
input: RepeatCounter newRepeatCounter = new RepeatCounter("cat", "The word 'concatenate' can be created by concatenating  'con' + 'cat' + 'enate'.");
output: 1;_

## Known Bugs

_n/a_

## Support and contact details

_Please contact me at kmgarvey279@gmail.com if you have any questions or comments._

## Technologies Used

_C#_
_Mono_
_.Net_

### License

_This software is licensed under the MIT license._
Copyright (c) 2019 **_{Kevin Garvey}_**
