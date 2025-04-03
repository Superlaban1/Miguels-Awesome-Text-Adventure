using System.Runtime.InteropServices;

List<Question> MessHall =
[
    new("Mess Hall"), new("mess hall"), new("MESS HALL"), new("Mess hall"), new("mess Hall"),
new("Mes Hall"), new("MessHal"), new("Mes Hal"), new("Mss Hall"), new("Mess Hll"), new("MessHall"), new("Mess-Hall"), new("Mess_Hall"), new("M3ss Hall"),
new("Mees Hall"), new("Moss Hall"), new("Mass Hall"), new("Miss Hall"), new("Mess Haal"), new("Mess Hlal"), new("MessHaal"), new("MesshAll"),
new("m3ss h4ll"), new("Mëss Hall"), new("Męss Hall"), new("Mèss Häll"), new("M e s s  H a l l"), new("M3ss_H@ll"), new("Me$$ Hall"), new("Mess Ha11"),
new("M3ss-H@ll"), new("MessHa11"), new("Më$$ Häll"), new("Me55 Hall"), new("M3ss-Ha11"), new("M@ss Hall"), new("Mess H@ll"),

];
List<Question> Brigde =
[
    new("bRidGE1"),
    new("B_R_I_D_G_E"),
    new("br1dge"),
    new("BRIDGE"),
    new("brdge"), new("bridg"), new("briddge"), new("bridgge"), new("briedge"), new("birgde"), new("brige"), new("brdige"), new("biridge"), new("breidge"),
new("nridge"), new("vridge"), new("gridge"), new("bridfe"), new("bridhe"), new("bridve"), new("bridte"),
new("brij"), new("brijge"), new("bridje"), new("brydge"), new("brijde"), new("briddj"),
new("bbridge"), new("briddgge"), new("brridge"), new("bridgge"),
new("brodge"), new("breedge"), new("brudge"), new("bradge"), new("bradgee"),
new("bɹᴉpƃǝ"), new("b-r-i-d-g-e"), new("bRidGe"), new("8ridge"), new("br1dge"),
];
List<Question> Restroom =
[
new("restroom"), new("Restroom"), new("RESTROOM"),
new("restrrom"), new("restrom"), new("restrooom"), new("restroem"), new("restroam"), new("restroon"), new("resrtroom"), new("retsroom"), new("restrooomm"),
new("restro"), new("restromm"), new("restr0om"), new("restro0m"), new("reestroom"), new("restroim"), new("reztroom"), new("rextroom"), new("restrokm"), new("restroojm"),
new("rsetroom"), new("resrtroom"), new("restrromm"), new("resttroom"), new("restroomm"), new("reztroom"), new("resyroom"), new("rest4oom"), new("restt4oom"), new("res7room"),
new("restro0m"), new("reztro0m"), new("resrtoom"), new("restrooomm"), new("reestrooom"), new("restro-om"), new("res_troom"), new("r e s t r o o m"), new("restro@m"), new("restroöm"),


];
List<Question> Quarters =
[
     new("quaters"), new("Quaters"), new("QUATERS"),
    new("quartars"), new("Quartars"), new("QUARTARS"),
    new("quorters"), new("Quorters"), new("QUORTERS"),
    new("qwarters"), new("Qwarters"), new("QWARTERS"),
    new("quorterz"), new("Quorterz"), new("QUORTERZ"),
    new("quaderz"), new("Quaderz"), new("QUADERZ"),
    new("kwarters"), new("Kwarters"), new("KWARTERS"),
    new("quaterz"), new("Quaterz"), new("QUATERZ"),
    new("quertars"), new("Quertars"), new("QUERTARS"),
    new("quatarz"), new("Quatarz"), new("QUATARZ"),
    new("quartors"), new("Quartors"), new("QUARTORS"),
    new("quarders"), new("Quarders"), new("QUARDERS"),
    new("quardors"), new("Quardors"), new("QUARDORS"),
    new("qwarterz"), new("Qwarterz"), new("QWARTERZ"),
    new("qarters"), new("Qarters"), new("QARTERS"),
    new("quardarz"), new("Quardarz"), new("QUARDARZ"),
    new("Quarters"), new("quarters"), new("QUARTERS")
];
List<Question> Medbay =
[
    new("medbay"), new("Medbay"), new("MEDBAY"),
    new("medbey"), new("Medbey"), new("MEDBEY"),
    new("medbai"), new("Medbai"), new("MEDBAI"),
    new("medbae"), new("Medbae"), new("MEDBAE"),
    new("medbei"), new("Medbei"), new("MEDBEI"),
    new("metbay"), new("Metbay"), new("METBAY"),
    new("madbay"), new("Madbay"), new("MADBAY"),
    new("midbay"), new("Midbay"), new("MIDBAY"),
    new("medbi"), new("Medbi"), new("MEDBI"),
    new("medbye"), new("Medbye"), new("MEDBYE"),
    new("medbeyy"), new("Medbeyy"), new("MEDBEYY"),
    new("medbayy"), new("Medbayy"), new("MEDBAYY"),
    new("medbbi"), new("Medbbi"), new("MEDBBI"),
    new("medbayz"), new("Medbayz"), new("MEDBAYZ"),
    new("medbazy"), new("Medbazy"), new("MEDBAZY"),
    new("medbaiy"), new("Medbaiy"), new("MEDBAIY"),
];

List<Question> Armory =
[
    new("armory"), new("Armory"), new("ARMORY"),
    new("armari"), new("Armari"), new("ARMARI"),
    new("armariy"), new("Armariy"), new("ARMARIY"),
    new("armorie"), new("Armorie"), new("ARMORIE"),
    new("armari"), new("Armari"), new("ARMARI"),
    new("armary"), new("Armary"), new("ARMARY"),
    new("armoriez"), new("Armoriez"), new("ARMORIEZ"),
    new("armoriz"), new("Armoriz"), new("ARMORIZ"),
    new("armariyz"), new("Armariyz"), new("ARMARIYZ"),
    new("armariez"), new("Armariez"), new("ARMARIEZ"),
    new("armaree"), new("Armaree"), new("ARMAREE"),
    new("armariie"), new("Armariie"), new("ARMARIIE"),
    new("armorey"), new("Armorey"), new("ARMOREY"),
    new("armoori"), new("Armoori"), new("ARMOORI"),
    new("armoorie"), new("Armoorie"), new("ARMOORIE"),
    new("armoriey"), new("Armoriey"), new("ARMORIEY"),
];

bool CheckInput(List<Question> list, string input)
{
    return list.Any(q => q.QuestionText.Equals(input, StringComparison.OrdinalIgnoreCase));
}

Random Random = new Random();
int OrcAttack = Random.Next(100);

string GlutenAffect = "You have now gotten explosive diarrehea from your gluten allergy";
string GlutenActive = "You are currently shitting yourself";
string Death = "You Died. Whether by blaster fire, airlock mishap, or an ill-advised leap into the warp, your journey has come to an unfortunate end. Your name will be but a footnote in the vast annals of the galaxy. If it is remembered at all.";
string ShipName = "Murasai";
string Menu = "STALE OATS \nTOAST\nMEAT SOUP\nHOT DOG\nTACO\nHAMBURGER";
string Name;

int PoopRoomCount = 0;
int Toastcount = 0;
int Oatscount = 0;
int BigBangCredits = 50;


Console.WriteLine("Welcome To Miguel's Awesome Text Adventure");
Console.WriteLine();
Console.WriteLine("Start");
Console.WriteLine("Exit");
string Start = Console.ReadLine();

if (Start == "Exit" || Start == "EXIT" || Start == "exit")
{
    System.Environment.Exit(1);
}
if (Start == "Start" || Start == "START"|| Start == "start")
{
    Console.Clear();
    Console.WriteLine("You wake up in the captains quarters");
    Console.WriteLine("You try to remember your name");
    Console.WriteLine("What is your Name");
    Name = Console.ReadLine();
    Console.Clear();
    while (true)
    {
        Console.WriteLine("You walk out into the hallway");
        Console.WriteLine("You can go to the MESS HALL, the BRIDGE, the RESTROOM, the ARMORY, the MEDBAY or your QUARTERS");
        string Wakeup = Console.ReadLine();
        Console.Clear();
        if (CheckInput(Restroom, Wakeup))
        {
            Console.WriteLine("You go the Restroom to relieve yourself");
            Thread.Sleep(3500);
            Console.Clear();
            continue;
        }
        if (CheckInput(Quarters, Wakeup)) 
        {
            Console.WriteLine("This is your Quarters");
            Console.WriteLine("You were just in here");
            Thread.Sleep(3500);
            Console.Clear();
            continue;
        }
        if (CheckInput(Brigde, Wakeup))
        {
            Console.Clear();
            Console.WriteLine("You decide to go to the bridge to see how far along you are on your expedition");
            break;
        }
        if (CheckInput(Armory, Wakeup))
        {
            Console.WriteLine("Hello this works");
        }
        if (CheckInput(Medbay, Wakeup))
        {
            Console.WriteLine("You walk into the Medbay");
            if (Toastcount >= 1)
            {
                Console.WriteLine("You took a pill to fix your gluten allergy");
                Toastcount = 0;
            }
            Thread.Sleep(3500);
            Console.Clear();
            continue;

        }
        if (CheckInput(MessHall, Wakeup))
        {
            Console.Clear();
            Console.WriteLine("You go to get some delicious breakfast in the mess hall");
            Console.WriteLine("You Look at the Menu\n");
            Console.WriteLine(Menu);
            string Breakfast = Console.ReadLine();
            if (Breakfast == "STALE OATS" || Breakfast == "OATS" || Breakfast == "Stale Oats" || Breakfast == "stale oats" || Breakfast == "Oats" || Breakfast == "oats")
            {
                Console.Clear();
                if (OrcAttack == 99)
                {
                    Console.WriteLine("Your ship was blown up by Space Orcs");
                    Console.WriteLine(Death);
                }
                Console.WriteLine("You ate the Stale Oats. They were stale");
                Thread.Sleep(4500);
                Console.Clear();
                Oatscount++;
                continue;
            }
            if (Breakfast == "TOAST" || Breakfast == "Toast" || Breakfast == "toast")
            {
                Console.Clear() ;
                Console.WriteLine("You ate a piece of toast");
                Thread.Sleep(3000);
                Console.Clear();
                Toastcount++;
                continue;
            }
            else
            {
                Console.WriteLine("I CAN'T FOLLOW ALL THAT!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("I CAN'T FOLLOW ALL THAT!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

class Question
{
    public string QuestionText;
    public Question(string question)
    {
        QuestionText = question;
    }
}