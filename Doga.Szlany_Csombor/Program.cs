string[] termekek = ["Sertéskaraj", "Gouda sajt", "Dobozos sajt", "Csirkemell filé", "Mirelit Pizza", "Vaj", "Edámi sajt", "Szőlő", "Paradicsom", "Szalámi", "Rizs", "Banán", "Zöldségmix", "Cola", "Hagyma", "Kenyér", "Narancs", "Alma", "Napraforgóolaj", "Spaghetti tészta", "Teljes tej", "Joghurt", "Almalé", "Burgonya", "Babkonzerv", "Cukor", "WC-papír", "Búzaliszt", "Friss tojás"];
string[] egysegek = ["kg", "450 g", "400 g", "kg", "db", "250 g", "200 g", "1 kg", "1 kg", "100 g", "1 kg", "1 kg", "1 kg", "2l", "1 kg", "1 kg", "1 kg", "1 kg", "1 l", "500 g", "1 l", "500 ml", "1 l", "1 kg", "240 g", "1 kg", "tekercs", "1 kg", "db"];

int[] december = [2550, 1602, 1140, 1620, 1320, 682, 750, 1700, 1000, 693, 651, 686, 805, 702, 600, 582, 798, 648, 522, 605, 550, 567, 286, 350, 351, 250, 154, 135, 50];
int[] november = [2400, 1800, 1500, 1500, 1500, 1100, 1000, 1000, 1000, 770, 700, 700, 700, 600, 600, 600, 600, 600, 580, 550, 440, 540, 440, 350, 270, 250, 220, 150, 80];

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
int[] változás = new int[28];

int index = 0;
int decemberi = 0;
int novemberi = 0;

while (index < december.Length - 1)
{
    index++;
    decemberi = december[index];
    novemberi = november[index];
    változás.Append((decemberi / novemberi - 1) * 100);
}

for (int i = 0; i < változás.Length; i++)
{
    Console.Write(változás[i] + ";");
}

// 3. Feladat
