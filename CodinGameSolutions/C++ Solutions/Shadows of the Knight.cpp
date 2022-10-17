#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

int main()
{
    int w; // width of the building.
    int h; // height of the building.
    cin >> w >> h; cin.ignore();
    int n; // maximum number of turns before game over.
    cin >> n; cin.ignore();
    int x0;
    int y0;
    cin >> x0 >> y0; cin.ignore();

    int x1 = 0;
    int x2 = w - 1;
    int y1 = 0;
    int y2 = h - 1;
    // game loop
    while (1) {
        string bomb_dir; // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
        cin >> bomb_dir; cin.ignore();

      
        for (auto c : bomb_dir) {
            if (c == 'U') y2 = y0 - 1;
            if (c == 'D') y1 = y0 + 1;
            if (c == 'R') x1 = x0 + 1;
            if (c == 'L') x2 = x0 - 1;
        }

        x0 = x1 + (x2 - x1) / 2;
        y0 = y1 + (y2 - y1) / 2;


        // the location of the next window Batman should jump to.
        cout << x0 << ' ' << y0 << endl;
    }
}