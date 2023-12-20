#include <iostream>
#include <cmath>
using namespace std;

int main() {
    double x;
    int n;

    // Nhap gia tri cua x va n tu ban phim
    cout << "Nhap gia tri cua x: ";
    cin >> x;

    cout << "Nhap gia tri cua n: ";
    cin >> n;

    // Tinh gia tri cua bieu thuc
    double result = 1.0;

    for (int i = 1; i <= n; ++i) {
        double term = pow(-1, i) * pow(x, i) / (i + 1);
        result += term;
    }

    // Hien thi ket qua
    cout << "Gia tri cua bieu thuc la: " << result << endl;

    return 0;
}

