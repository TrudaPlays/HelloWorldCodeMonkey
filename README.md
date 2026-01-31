Calculator variable type decision

I didn't end up using float at all in the calculator, as float is even less precise than double which is less precise than decimal and so didn't really fit with a calculator. Floats are best used in game development for speed where a bit of error is completely acceptable as speed of rendering is crucial. An interesting note that it is exactly the opposite of decimal which focuses on precise calculations while performing very slowly wherease float performs the calculations with great speed but with often much more rounding error than even double let alone decimal.

I decided to use decimal for all of the variables that will hold the user-inputted values for the addition, subtraction etc...The initial result variable was assigned as a decimal, but then when I printed the result I turned the result into a double so that it would round off nicely. The decimal value will not round off so the user would be left with a value like 0.6666666666 for 2 / 3. The way I did it resulted in very good precision in the calculations themselves, with the end result having a nice rounding off at the end. 2 / 3 becomes 0.6666666666666667 instead of abruptly cutting off at a random 6.

I decided to use decimal for the entirety of the sales tax calculation as without it the monetary values would have been off and my final value would not have been correct. 

I used int for the variable that stored the user's choice of 1, 2, 3, 4, 5, or 6 for choosing what operation to use. I had to use a try/except block because of this to check if the user inputted gibberish or in fact inputted 'exit' to leave the calculator.

My decisions on where and how to use decimal and double in my calculations resulted in that I was able to give maximum precision to the calculations themselves, and then give a nice clean result that rounded off after enough decimal places to put across a repeating decimal. 2/3 for example has enough 6s that you can see it is a repeating decimal that would go on forever except for the fact that the double variable type rounds up one of the 6s to a 7 for the final output.
