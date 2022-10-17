#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int light_x; // the X position of the light of power
    int light_y; // the Y position of the light of power
    int initial_tx; // Thor's starting X position
    int initial_ty; // Thor's starting Y position

    cin >> light_x >> light_y >> initial_tx >> initial_ty; cin.ignore();

    int ThorX = initial_tx;
    int ThorY = initial_ty;

    while (1) {
        int remaining_turns; 
        cin >> remaining_turns; cin.ignore();

        string directionX;
        string directionY;

        if (ThorX < light_x) {
            directionX = "E";
            ThorX++;
        }
        else if (ThorX > light_x) {
            directionX = "W";
            ThorX--;
        }
        if (ThorY < light_y) {
            directionY = "S";
            ThorY++;
        }
        else if (ThorY > light_y) {
            directionY = "N";
            ThorY--;
        }

        cout << directionY << directionX << endl;
    }
}