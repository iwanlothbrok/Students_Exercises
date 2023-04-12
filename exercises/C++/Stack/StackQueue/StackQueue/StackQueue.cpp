#include <iostream>

using namespace std;

struct StackNode {
    int data;
    StackNode* next;
};

struct Stack {
    StackNode* top;
};

struct QueueNode {
    int stackNumber;
    QueueNode* next;
};

struct Queue {
    QueueNode* front;
    QueueNode* rear;
};

void push(Stack& s, int data) {
    StackNode* newNode = new StackNode;
    newNode->data = data;
    newNode->next = s.top;
    s.top = newNode;
}

int pop(Stack& s) {
    if (s.top == nullptr) {
        cerr << "Error: stack is empty" << endl;
        exit(1);
    }
    int data = s.top->data;
    StackNode* temp = s.top;
    s.top = s.top->next;
    delete temp;
    return data;
}

bool isStackEmpty(Stack s) {
    return s.top == nullptr;
}

void printStack(Stack s) {
    StackNode* temp = s.top;
    while (temp != nullptr) {
        cout << temp->data << " ";
        temp = temp->next;
    }
    cout << endl;
}

void enqueue(Queue& q, int stackNumber) {
    QueueNode* newNode = new QueueNode;
    newNode->stackNumber = stackNumber;
    newNode->next = nullptr;
    if (q.rear == nullptr) {
        q.front = q.rear = newNode;
        return;
    }
    q.rear->next = newNode;
    q.rear = newNode;
}

int dequeue(Queue& q) {
    if (q.front == nullptr) {
        cerr << "Error: queue is empty" << endl;
        exit(1);
    }
    int stackNumber = q.front->stackNumber;
    QueueNode* temp = q.front;
    q.front = q.front->next;
    if (q.front == nullptr) {
        q.rear = nullptr;
    }
    delete temp;
    return stackNumber;
}

bool isQueueEmpty(Queue q) {
    return q.front == nullptr;
}

void printQueue(Queue q) {
    QueueNode* temp = q.front;
    while (temp != nullptr) {
        cout << temp->stackNumber << " ";
        temp = temp->next;
    }
    cout << endl;
}

int main() {
    Stack stacks[3]; // create 3 stacks
    for (int i = 0; i < 3; i++) {
        stacks[i].top = nullptr; // initialize each stack to be empty
    }

    Queue q; // create a queue for the stacks
    q.front = q.rear = nullptr; // initialize queue to be empty

    // enqueue the stacks to be processed
    enqueue(q, 0);
    enqueue(q, 1);
    enqueue(q, 2);
    enqueue(q, 0);
    enqueue(q, 1);
    enqueue(q, 2);

    while (!isQueueEmpty(q)) {
        int stackNumber = dequeue(q);
        if (isStackEmpty(stacks[stackNumber])) {
            cout << "Stack " << stackNumber << " is empty!" << endl;
        }
        else {
            cout << "Popping from stack " << stackNumber << ": ";
            int data = pop(stacks[stackNumber]);
            cout << data << endl;
            printStack(stacks[stackNumber]);
        }
        cout << "Current queue state: ";
        printQueue(q);
        cout << endl;
    }

    return 0;
}

