#include <iostream>
using namespace std;

class Shape {
public:
    virtual void draw() = 0;
};

class Circle : public Shape {
public:
    void draw() {
        cout << "Drawing a circle." << endl;
    }
};

class Square : public Shape {
public:
    void draw() {
        cout << "Drawing a square." << endl;
    }
};

int main() {
    Circle circle;
    Square square;
    Shape* shapes[] = { &circle, &square };
    for (int i = 0; i < 2; i++) {
        shapes[i]->draw();
    }
    return 0;
}