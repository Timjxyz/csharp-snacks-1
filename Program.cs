// See https://aka.ms/new-console-template for more information


//Snack4) -Calcola la somma e la media dei numeri da 2 a 10.
int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int summ = 0;
for (int i = 0; i < numeri.Length; i++)
{
    summ+=numeri[i];
}
Console.WriteLine("La somma dei numeri scelti è " + summ);
float media = summ / 9;
Console.WriteLine("La media dei numeri è " + media);

return;
//////////////////////////////////////
//Snack 3) -Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

int numeriUtente;
int somma = 0;
Console.WriteLine("Inserisci 10 numeri");

for(int i = 0; i < 10; i++)
{
    numeriUtente = int.Parse(Console.ReadLine());
    somma+= numeriUtente;

}
Console.WriteLine("La somma dei numeri scelti è "+somma);
