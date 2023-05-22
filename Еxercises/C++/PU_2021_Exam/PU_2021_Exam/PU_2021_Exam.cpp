// PU_2021_Exam.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

// we are creating the struct item 
struct Item {
    int id;
    char name[20];
    double price;
    int quantity;
    int type;
    string code;

} items[2000]; // setting to be array with max 2000 items


void addItem(int n)
{
    for (int i = 0; i < n; i++)
    {
        items[i].id = i + 1;
        cin.ignore();

        cout << "Please enter item's name: \n";
        // cin getline because name its char[]
        cin.getline(items[i].name, 20);

        cout << "Please enter item's price: \n";
        cin >> items[i].price; 
        
        cout << "Please enter item's quantity: \n";
        cin >> items[i].quantity;

        cout << "Please enter item's type: \n";
        cin >> items[i].type;

        items[i].code = to_string(items[i].id) + items[i].name[0] + items[i].name[1] + to_string(items[i].type);
    }
}

void nameOrderAsc(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (strcmp(items[j].name, items[j + 1].name) > 0) // first is bigger 
            {
                Item temp = items[j];
                items[j] = items[j++];
                items[j+1] = temp;
            }
        }
    }
}

void totalPriceOrderAsc(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (items[j].price * items[i].quantity > items[j].price * items[i].quantity ) // first is bigger 
            {
                Item temp = items[j];
                items[j] = items[j++];
                items[j + 1] = temp;
            }
        }
    }
}

int main()
{
    int n;
    cout << "Add how many items you want: \n";
    cin >> n;

    addItem(n);


}

//За всеки артикул, трябва да се въведат(съхранят) :
//     Пореден номер на въвеждане;
// Име на артикул(знаков низ с дължина от 2 до 20 символа);
// Единична цена(число с плаваща запетая, минимална цена 0.10);
// Наличност от съответния артикул(цяло положително число);
// Тип на артикул(типовете са от 1 до 5).
//Програмата трябва да може да съхрани до 2000 артикула.
