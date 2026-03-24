#include <iostream>
using namespace std;

int main() {
    int quantidade, num;
    int contador = 0;
    int soma = 0;

    cout << "Digite a quantidade de numeros que deseja somar: ";
    cin >> quantidade;

    int i = 0;
    while (i < quantidade) {
        cout << "Digite o numero: ";
        cin >> num;

        if (num % 2 == 0) {
            soma += num;
            contador++;
        }
        i++;

    }
    if (contador > 0) {
       double media = (double)soma / contador;
         cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
    return 0;

}