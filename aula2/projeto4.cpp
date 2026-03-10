#include <iostream>
using namespace std;

int main(){
int codigo1, codigo2, quantidade1, quantidade2;
float valor1, valor2, total;
cout << ("insira o codigo 1, a quantidade e o valor do mesmo: ");
cin >> codigo1 >> quantidade1 >> valor1;
cout << ("insira o codigo 2, a quantidade e o valor do mesmo: ");
cin >> codigo2 >> quantidade2 >> valor2;
total = (quantidade1 * valor1) + (quantidade2 * valor2);
cout << "valor a ser pago: R$ " << total << endl;
return 0;
}