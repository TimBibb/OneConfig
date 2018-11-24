//
// Created by Tim Bibbee on 11/23/18.
//

#include "consolidator.h"
#include <string>
#include <list>

using namespace std;

list<string> mainGames;

list<string> saveMainGames(list<string> games){
    for(int i = 0; i < games.size(); i++){
        mainGames.push_back(games[i]);
    }

    return mainGames;
}


