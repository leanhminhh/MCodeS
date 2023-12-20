#include <iostream>
#include <cmath>
using namespace std;

int main() {
   float x;
    int n;

    cout << "Nhap gia tri x: ";
    cin >> x;

    cout << "Nhap so lan lap n: ";
    cin >> n;

    float s = sqrt(x);
    for (int i = 1; i < n; i++) {
        s = sqrt(x + s);
    }

    cout << "Gia tri cua bieu thuc s la: " << s << endl;

    return 0;
}

