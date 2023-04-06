#include <iostream>
using namespace std;

// Function to calculate the area of a rectangle
int calculateArea(int length, int width) {
    return length * width;
}

// Function to calculate the perimeter of a rectangle
int calculatePerimeter(int length, int width) {
    return 2 * (length + width);
}

int main() {
    int length, width, area, perimeter, totalArea = 0, totalPerimeter = 0;
    cout << "Enter the length and width of each rectangle (or 0 0 to quit):" << endl;
    cin >> length >> width;
    while (length != 0 || width != 0) {
        area = calculateArea(length, width);
        perimeter = calculatePerimeter(length, width);
        cout << "Rectangle area: " << area << endl;
        cout << "Rectangle perimeter: " << perimeter << endl;
        totalArea += area;
        totalPerimeter += perimeter;
        cin >> length >> width;
    }
    cout << "Total area of all rectangles: " << totalArea << endl;
    cout << "Total perimeter of all rectangles: " << totalPerimeter << endl;
    return 0;
}
