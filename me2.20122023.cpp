#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using namespace std;

struct Product {
    string code, productName;
    float price;
    int quantity;
};

void inputProduct(Product &product) {
    cout << "Nhap ma san pham (toi da 15 ki tu): ";
    cin.ignore(); 
    getline(cin, product.code);

    cout << "Nhap ten san pham (toi da 50 ki tu): ";
    getline(cin, product.productName);

    cout << "Nhap don gia: ";
    cin >> product.price;

    cout << "Nhap so luong: ";
    cin >> product.quantity;
}

void displayProduct(const Product &product) {
    cout << "Ma san pham: " << product.code << endl;
    cout << "Ten san pham: " << product.productName << endl;
    cout << "Don gia: " << product.price << endl;
    cout << "So luong: " << product.quantity << endl;
    cout << "-----------------------------" << endl;
}

int main() {
    int n;
    cout << "Nhap so luong san pham: ";
    cin >> n;

    vector<Product> productList;

    for (int i = 0; i < n; ++i) {
        Product product;
        inputProduct(product);
        productList.push_back(product);
    }

    ofstream outFile("quantity10.txt");

    for (int i = 0; i < productList.size(); ++i) {
        const Product &product = productList[i];
        if (product.quantity > 10) {
            displayProduct(product);

            outFile << "Ma san pham: " << product.code << endl;
            outFile << "Ten san pham: " << product.productName << endl;
            outFile << "Don gia: " << product.price << endl;
            outFile << "So luong: " << product.quantity << endl;
            outFile << "-----------------------------" << endl;
        }
    }

    outFile.close();

    return 0;
}

