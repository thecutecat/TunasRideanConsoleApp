//skill challenge

Console.WriteLine("input N & M: ");
int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Console.WriteLine("input skills to face: ");
int[] Ai = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Console.WriteLine("input gained skills: ");
int[] Bi = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

Console.WriteLine("Result: " + GetSkill(NM, Ai, Bi));

static int GetSkill(int[] NM, int[] Ai, int[] Bi)
    {
        int skill = NM[1]; //M is initial skill
                           //N is the loop
                           //Ai is the skill to lawan
                           //skill order can be selected by player
                           //BI is the gained skill
    Console.WriteLine("Initial skill : " + skill);
    Console.WriteLine("Loop lawan skill : " + NM[0]);

    int[] temp = new int[NM[0]];
    int tempskill = 0;

    //Ai = Ai.OrderBy(x => x).ToArray(); : i missed this point 

    for (int i = 0; i < NM[0]; i++)
    {
       // tempskill = NM[1];

        if (skill >= Ai[i])
        {
            skill += Bi[i]; 
            Console.WriteLine("Gained skill : " + Bi[i]);
        }
         
    } 

    Console.WriteLine("Final skill Juned : " + skill);
    return skill;
    }
 
/*
4 2

8 9 3 2
5 4 1 3

5 + 1 = 6
 */
/*
 


 */
