// InheritanceProblems.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
//#include "Animal.h"
//#include "Cat.h"

using namespace std;

class Animal {
protected:
    string name;
    int age;
public:
    Animal() {}
    Animal(string name, int age) {
        this->name = name;
        this->age = age;
    }
    void speak() {
        cout << "I am an animal." << endl;
    }
};

class Dog : public Animal {
private:
    string breed;
public:
    Dog() {}
    Dog(string name, int age, string breed) : Animal(name, age) {
        this->breed = breed;
    }
    void speak() {
        cout << "I am a dog." << endl;
    }
};

class Cat : public Animal {
private:
    string color;
public:
    Cat() {}
    Cat(string name, int age, string color) : Animal(name, age) {
        this->color = color;
    }
    void speak() {
        cout << "I am a cat." << endl;
    }
};

int main() {
    Animal animal("Bob", 5);
    Dog dog("Rufus", 3, "Golden Retriever");
    Cat cat("Whiskers", 2, "Orange");
    animal.speak();
    dog.speak();
    cat.speak();
    return 0;
}