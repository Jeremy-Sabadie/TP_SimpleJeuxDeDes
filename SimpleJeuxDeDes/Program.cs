
//1er De
using SimpleJeuxDeDes;

De De1 = new De();


//2ème De
De De2 = new De();
int ScoreDe1 = De1.Lancer();
int ScoreDe2 = De2.Lancer();
Console.WriteLine($"dès n°1: {ScoreDe1}");
while (De1.GetValue() < 6 && De2.GetValue() < 6)
{
    De1.Lancer();
    De2.Lancer();
}
