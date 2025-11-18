string[] termekek = ["Sertéskaraj", "Gouda sajt", "Dobozos sajt", "Csirkemell filé", "Mirelit Pizza", "Vaj", "Edámi sajt", "Szőlő", "Paradicsom", "Szalámi", "Rizs", "Banán", "Zöldségmix", "Cola", "Hagyma", "Kenyér", "Narancs", "Alma", "Napraforgóolaj", "Spaghetti tészta", "Teljes tej", "Joghurt", "Almalé", "Burgonya", "Babkonzerv", "Cukor", "WC-papír", "Búzaliszt", "Friss tojás"];
string[] egysegek = ["kg", "450 g", "400 g", "kg", "db", "250 g", "200 g", "1 kg", "1 kg", "100 g", "1 kg", "1 kg", "1 kg", "2l", "1 kg", "1 kg", "1 kg", "1 kg", "1 l", "500 g", "1 l", "500 ml", "1 l", "1 kg", "240 g", "1 kg", "tekercs", "1 kg", "db"];

double[] december = [2550, 1602, 1140, 1620, 1320, 682, 750, 1700, 1000, 693, 651, 686, 805, 702, 600, 582, 798, 648, 522, 605, 550, 567, 286, 350, 351, 250, 154, 135, 50];
double[] november = [2400, 1800, 1500, 1500, 1500, 1100, 1000, 1000, 1000, 770, 700, 700, 700, 600, 600, 600, 600, 600, 580, 550, 440, 540, 440, 350, 270, 250, 220, 150, 80];

// 1. Feladat
Console.Write("Írd be a termék nevét: ");
string termeknev = Console.ReadLine();
int termekindex = 0;

while (termeknev != termekek[termekindex])
{
    termekindex++;
}

Console.WriteLine($"\nKiszerelése: {egysegek[termekindex]}");

//2. Feladat
double[] változás = new double[28];

int index = 0;
double decemberi = 0;
double novemberi = 0;

while (index < december.Length - 1)
{
    index++;
    decemberi = december[index];
    novemberi = november[index];
    double hozzaad = (decemberi / novemberi - 1) * 100;
    Console.Write((decemberi / novemberi - 1) * 100 + "; ");
    változás.Append(hozzaad);
}

Console.WriteLine();

for (int i = 0; i < változás.Length; i++)
{
    Console.Write(változás[i] + "; ");
}

// 3. Feladat

double decössz = december.Sum();
double novössz  = november.Sum();
Console.WriteLine($"\nEnnyi a különbség: {decössz} {novössz}");

double legnagydrág = 0;
for (int i = 0; i < december.Length - 1; i++)
{
    double egy = december[i];
    double kettő = december[i + 1];
    if (kettő - egy > legnagydrág)
    {
        legnagydrág = kettő - egy;
    }
    egy = november[i];
    kettő = november[i + 1];
    if (kettő - egy > legnagydrág)
    {
        legnagydrág = kettő - egy;
    }
}
Console.WriteLine($"Legnagyobb drágulás: {legnagydrág}Ft");

double legnagyáres = 0;
for (int i = 0; i < december.Length - 1; i++)
{
    double egy = december[i];
    double kettő = december[i + 1];
    if (egy - kettő > legnagyáres)
    {
        legnagyáres = egy - kettő;
    }
    egy = november[i];
    kettő = november[i + 1];
    if (egy - kettő > legnagyáres)
    {
        legnagyáres = egy - kettő;
    }
}
Console.WriteLine($"Legnagyobb áresés: {legnagyáres}Ft");

// 4. Feladat
double[] tisztított = new double[28];
foreach (var item in args)
{
    
}