#include <iostream>
#include <fstream>
#include <string>

int main()
{
    /*
        Create a program that reads a text file and replaces all 
        occurrences of a certain word with another word. 
        The program should write the modified text to a new file.
    */

    ifstream input_file("input.txt");  // Open the input file
    ofstream output_file("output.txt");  // Open the output file
    string search_word = "hello";  // Set the word to search for
    string replace_word = "goodbye";  // Set the word to replace with
    string line;  // Declare a variable to store each line of text

    while (getline(input_file, line)) {  // Read each line of text from the input file
        size_t pos = 0;
        while ((pos = line.find(search_word, pos)) != string::npos) {  // Find the search word in the line
            line.replace(pos, search_word.length(), replace_word);  // Replace the search word with the replace word
            pos += replace_word.length();  // Advance the position past the replace word
        }
        output_file << line << endl;  // Write the modified line to the output file
    }

    input_file.close();  // Close the input file
    output_file.close();  // Close the output file
}
