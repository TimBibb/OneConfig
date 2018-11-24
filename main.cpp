#include <iostream>
#include <string>
#include "consolidator.h"

using namespace std;


int main() {

    string chosenGames[] = {"bo4", "bfv"};
    list<string> save = saveMainGames(chosenGames);

    for(string a : save){
        cout << a << endl;
    }

    return 0;

}
