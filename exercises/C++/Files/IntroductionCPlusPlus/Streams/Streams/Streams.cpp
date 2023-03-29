#include <iostream>
#include <fstream>
#include <string>
#include <bitset>

using namespace std;

int main() {
    //{
        //ofstream of("MyLog.txt"); // Creates a new file for write, if the file didn't exist
        //of << "Experience is the mother of wisdom" << endl;
        //of << 234 << endl;
        //of << 2.3 << endl;
        //of << bitset<8>(14) << endl; // 00001110
    //} // RAII techniche

    //{
        //ofstream of("MyLog.txt"); // Open file for write, clear the context of the file
        //ofstream of("MyLog.txt", ofstream::app); // Move the output pointer to the end of the file 
        //of << "Honesty is the best policy" << endl; // Append to the end of the file 
    //}

    //{  Override in file 
    //ofstream of("MyLog.txt", ofstream::in | ofstream::out);
    //of.seekp(10, ios::beg); // Move the pointer 10 chars after beggining
    //of << "12345"; // Override t5 chars
    //of.seekp(-5, ios::end); // Move the pointer 5 chars before end
    //of << "What is going on here be" << endl;
    //of.seekp(-5, ios::cur); // Move the pointer 5 chars before current possition 
    //}
    
    // Error handling
    //ifstream inf("MyLog.txt");
    //int i;
    //inf >> i; // read one word
    //// Error status: goodbit, badbit, failbit, eofbit
    //inf.good(); // everithing is OK (goodbit == 1)
    //inf.bad(); // Non-recoverable error (badbit == 1)
    //inf.fail(); // failed stream operation. (failbit == 1 badbit == 1)
    //inf.eof(); // End of the file (eofbit == 1)
    //
    //inf.clear(); // Clear all the error status
    //inf.clear(ios::badbit); // sets a new value to the error flag 
    //
    //inf.rdstate(); // read the current status flag
    //24
    ifstream file("input.txt");  // Open the input file
    string line;  // Declare a variable to store each line of text
    int char_count = 0, word_count = 0, line_count = 0;  // Initialize counters to zero

    while (getline(file, line)) {  // Read each line of text from the file
        line_count++;  // Increment the line count
        char_count += line.length();  // Add the number of characters in the line to the character count

        // Count the number of words in the line
        int pos = 0;
        while ((pos = line.find(' ', pos)) != string::npos) {
            word_count++;
            pos++;
        }
        word_count++;  // Add one for the last word in the line
    }

    // Output the results to the console
    cout << "Number of characters: " << char_count << endl;
    cout << "Number of words: " << word_count << endl;
    cout << "Number of lines: " << line_count << endl;

    return 0;
}
