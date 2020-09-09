# Key Generator

Title: CD Key Generator
Difficulty: 3
Description: Create a program which generates keys for an application that you may put on a
CD. Classic example would be the keys you use for installation of a major software product from
Microsoft or Adobe. Have the user specify the length of keys and the types of characters they
can use in the key (only letters, letters & numbers, just numbers, any special characters). It will
then generate a random key value that can also be verified. In addition, create the mechanism
for validating the generated key.
Tips: This is all about generating random strings using a known procedure or algorithm. There
are many algorithms out there used to generate hashes or random passwords. This would be
no different EXCEPT you need to know how it is created and then know how to
decipher/validate it. Start with a small string and a known encryption algorithm that is easy to
decipher and build up from there. Something as simple as a Ceasar or Vigenere cipher could be
used to encrypt a special word with a salt (like the current time). Then decipher it to see if that
works. Once you have a model working, you can then build off of that with a more complex
procedure.
Added Difficulty: Try linking this newly generated key to a specific binary version. For instance a
key you generated for version 1.0 of your product would then not work for version 2.0.
 
