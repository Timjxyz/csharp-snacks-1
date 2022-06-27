// See https://aka.ms/new-console-template for more information
//Snack 10) - Fai inserire un numero che chiameremo N, all'utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno stampalo a schermo.

Console.WriteLine("Inserisci un numero");

int N = int.Parse(Console.ReadLine());

Random random = new Random();

int[] arrayNumeri ;

for(int nArray=0;nArray<N; nArray++)
{
    arrayNumeri = new int[10];
    for (int i = 0; i < arrayNumeri.Length; i++)
    {
        arrayNumeri[i] = random.Next(1,101);
      
    }
    for (int i = 0; i < arrayNumeri.Length; i++)
    {
        Console.Write(arrayNumeri[i] + "\t ");

    }
    Console.WriteLine();
}


return;
///////////////////////
//Snack 5)
//Il software chiede all'utente di inserire un numero.
//Se il numero è pari, stampa il numero, se è dispari, stampa il numero successivo.

int numeroUtente;
Console.WriteLine("Inserisci un numero");
numeroUtente = int.Parse(Console.ReadLine());

if(numeroUtente %2 ==0)
{
    Console.WriteLine( "Il numero utente scelto è " + numeroUtente);
}
else
{
    int numeroUtente1 = numeroUtente + 1;
    Console.WriteLine("Il numero utente scelto è " + numeroUtente1);
}


return;
//////////////
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
