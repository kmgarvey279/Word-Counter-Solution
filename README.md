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

#### The MIT License

#### Copyright (c) 2019 Kevin Garvey & Ian Christner

Permission is hereby granted, free of charge,
to any person obtaining a copy of this software and
associated documentation files (the "Software"), to
deal in the Software without restriction, including
without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom
the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice
shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
