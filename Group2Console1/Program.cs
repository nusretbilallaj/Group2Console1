
Console.WriteLine("Kolegji AAB");
//Console.WriteLine("------------");
//Console.WriteLine("Tungjatjeta");
//Console.WriteLine("------------");

//string emri;
//emri="Leron Berisha";

//Console.WriteLine(emri);
//Console.WriteLine("10");
//Console.WriteLine(10);

//int numri;
//numri=10;

//bool kushti;
//kushti=true;
//kushti=false;
//Console.WriteLine(kushti);

string studenti;
studenti = "Kastriot Gjoka";
//Console.WriteLine("-------");
//Console.WriteLine(studenti);
//Console.WriteLine("-------");
Paraqit(studenti);

string studenti2="Blend Krasniqi";
//Console.WriteLine("-------------");
//Console.WriteLine(studenti2);
//Console.WriteLine("-------------");
Paraqit(studenti2);

string studenti3 = "Rinor Shishko";
//Console.WriteLine("-------------");
//Console.WriteLine(studenti3);
//Console.WriteLine("-------------");
Paraqit(studenti3);

void Paraqit(string emri)
{
    Console.WriteLine("-------------");
    Console.WriteLine(emri);
    Console.WriteLine("-------------");
}

int numri=10;
Console.WriteLine(numri);

int[] numrat=new int[5];

numrat[0]=10;
numrat[1] = 20;
numrat[2] = 30;
numrat[3] = 40;
numrat[4] = 50;

// foreach (var nr in numrat)
// {
//     Console.WriteLine(nr);
// }

for (int i = 0; i < 5; i++)
{
   Console.WriteLine(numrat[i]);
}

int qarkullimi=10;
while (qarkullimi>0)
{
    Console.WriteLine(qarkullimi);
    qarkullimi = qarkullimi - 1;
}

void Pershendete(string studenti)
{
    Console.WriteLine($"Tungjatjeta {studenti} ");
}

Pershendete("Ermal Abazi");