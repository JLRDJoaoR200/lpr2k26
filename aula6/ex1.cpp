#include <iostream>
using namespace std;

int inverterNumero(int n) {
    int invertido = 0;

    while (n != 0) {
        int digito = n % 10;     
        invertido = invertido * 10 + digito; 
        n = n / 10;                 
    }

    return invertido;
}

int main() {
    int numero;

    cout << "Digite um numero inteiro: ";
    cin >> numero;

    int resultado = inverterNumero(numero);

    cout << "Numero invertido: " << resultado << endl;

    return 0;
}