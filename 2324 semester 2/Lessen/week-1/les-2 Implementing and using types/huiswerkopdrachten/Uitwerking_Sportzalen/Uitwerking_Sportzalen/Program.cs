

var sportzalen = new string[3] { "Mercurius", "Jupiter", "Mars" };
var aanwezigheidSportzalen = new int[3, 3];

aanwezigheidSportzalen[0, 0] = 1;
aanwezigheidSportzalen[0, 1] = 2;
aanwezigheidSportzalen[0, 2] = 14;

aanwezigheidSportzalen[1, 0] = 5;
aanwezigheidSportzalen[1, 1] = 3;
aanwezigheidSportzalen[1, 2] = 44;

aanwezigheidSportzalen[2, 0] = 1;
aanwezigheidSportzalen[2, 1] = 1;
aanwezigheidSportzalen[2, 2] = 18;


for (int i = 0; i < sportzalen.Length; i++)
{
    Console.WriteLine($"In {sportzalen[i]} zijn {aanwezigheidSportzalen[i, 0]} scheidsrechter(s), {aanwezigheidSportzalen[i, 1]} sportarts(en) en {aanwezigheidSportzalen[i, 2]} sporter(s) aanwezig.");
}

aanwezigheidSportzalen[1, 1] = aanwezigheidSportzalen[1, 1] - 1;
aanwezigheidSportzalen[1, 2] = aanwezigheidSportzalen[1, 2] - 2;

Console.WriteLine("\nUit Jupiter vertrekt 1 sportarts met 2 sporters.\n");

for (int i = 0; i < sportzalen.Length; i++)
{
    Console.WriteLine($"In {sportzalen[i]} zijn {aanwezigheidSportzalen[i, 0]} scheidsrechter(s), {aanwezigheidSportzalen[i, 1]} sportart(sen) en {aanwezigheidSportzalen[i, 2]} sporter(s) aanwezig.");
}

Console.WriteLine("\n\n\n\n");