#Word Counter

### _The program takes both a single word, and a sentence from the user as input and then returns a number corresponding with the number of times the inputted word appears in the inputted sentence._04/26/2019_

### _***Kevin Garvey***_

## Description

_Specifications:
*1) The WordObject constructor creates a new instance of the WordCounter object..
input: WordCounter newWordCounter = new WordCounter("cat", "The cat came back.");
output: newWordCounter.GetType() == WordCounter;
*2) The WordObject returns the inputted word and sentence using getter methods.
output: newWordCounter.GetWord() == "cat";, newWordCounter.GetSentence() == "The cat came back.";
*3) The WordObject takes a single lower-case character as a 'Word' argument and a lower-case string as a 'Sentence' argument and returns the number of times the character appears in the word.
input: WordCounter newWordCounter = new WordCounter("c", "cat");
output: 2;
*4) The WordObject takes an upper-case character as a 'Word' argument and a lower-case string as a 'Sentence' argument and returns the number of times the character appears in the word (regardless of casing).
input: WordCounter newWordCounter = new WordCounter("C", "cat");
output: 1;
*5) The WordObject takes a lower-case character as a 'Word' argument and a mixed-case string as a 'Sentence' argument and returns the number of times the character appears in the word (regardless of casing).
input: WordCounter newWordCounter = new WordCounter("c", "Cat");
output: 1;
*6) The WordObject takes a multiple character word as a 'Word' argument and a single string as a 'Sentence' argument and returns the number of times the character appears in the word.
input: WordCounter newWordCounter = new WordCounter("cat", "Does the cat from 'The Cat in the Hat' have a real name?");
output: 2;

## Known Bugs

## Support and contact details

_Please contact me at kmgarvey279@gmail.com if you have any questions or comments._

## Technologies Used

_C#_
_Mono_
_.Net_
### License

_This software is licensed under the MIT license._
Copyright (c) 2019 **_{Kevin Garvey}_**
