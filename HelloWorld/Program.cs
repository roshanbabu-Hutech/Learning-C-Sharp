// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;

string[] names = new string[3];
names[0] = "Roshan";
names[1] = "Candy love";

// Console.WriteLine(names[0]);
// Console.WriteLine(names[1]);
// Console.WriteLine(names[2]);

int[] nums = new int[4];

nums[0] = 10;
nums[2] = 30;
nums[3] = 40;

// Console.WriteLine(nums[0]);
// Console.WriteLine(nums[1]);
// Console.WriteLine(nums[2]);
// Console.WriteLine(nums[3]);


bool[] checks = new bool[4];

checks[0] = true;
checks[checks.Length-1] = true;

Console.WriteLine(checks[0]);
Console.WriteLine(checks[1]);
Console.WriteLine(checks[2]);
Console.WriteLine(checks[3]);

List<string> names1 = new List<string>();
names1.Add("Roshan");
names1.Add("Roshan");
names1.Add("Roshan");
names1.Add("Roshan");
names1.Add("Roshan");
names1.Add("Roshan");

Console.WriteLine(names1[0]);
Console.WriteLine(names1[1]);
Console.WriteLine(names1[2]);
Console.WriteLine(names1[3]);
Console.WriteLine(names1[4]);
Console.WriteLine(names1[5]);


// List<string> names1 = new List<string>();

Console.WriteLine(checks.GetLength(0));
Console.WriteLine(names1.Count);





List<string> stars = new List<string>(){"Rakul Preet Singh", "Sunny leone", "alia bhatt"};

foreach (var item in stars)
{
    // Console.WriteLine(item);
}

// or

IEnumerable<string> stars1 = stars;

// stars1.Append("roshan");
Console.WriteLine(stars1.Last());
Console.WriteLine(stars1.First());
Console.WriteLine(stars[0]);
Console.WriteLine(stars[1]);
Console.WriteLine(stars[2]);

foreach (var item in stars1)
{
    // Console.WriteLine(item);
}


Dictionary<string,string> actress = new Dictionary<string, string>();
actress.Add("Rakul Preet Singh","Tollywood");
actress.Add("alia bhatt","bollywood");
actress.Add("ana de armas","hollywood");

Console.WriteLine(actress["ana de armas"]);

Dictionary<string,int> ages = new Dictionary<string, int>();

ages.Add("rakul",28);
ages.Add("ana de armas",30);
// ages.Add("ana de armas",40);
ages.Add("isha chawla",26);



Console.WriteLine(ages["ana de armas"]);




ArrayList person = new ArrayList();
person.Add("roshan");
person.Add(24);
person.Add("Software Developer");

Console.WriteLine(person[0]);
Console.WriteLine(person[1]);
Console.WriteLine(person[2]);




Dictionary<string,decimal> itemPrices = new Dictionary<string, decimal>(){
    {"cheese",5.6m},
    {"pizza",6.4m},
    {"biryani",10.6m}
};

Console.WriteLine(itemPrices["cheese"]);



double num;

num = 10.6d;

Console.WriteLine(num/2);


Console.WriteLine(Math.Abs(-9.65));

Console.WriteLine(Math.Max(2,12));

string text = "h,e,l,o";

// Console.WriteLine(text.Trim(8,10));
// Console.WriteLine(text);
// Console.WriteLine(text.Split('h'));
string[] letters = text.Split("l");
Console.WriteLine(letters.GetType());
// Console.WriteLine(letters[0]);
// Console.WriteLine(letters[letters.Length-1]);

foreach (var item in letters) 
{
    Console.WriteLine(item);
}


string name = "roshan";
string name1 = "roshAn";

Console.WriteLine(name == name1);
Console.WriteLine(name.Equals(name1));

int num1 = 10;
int num2 = 10;

Console.WriteLine(num1 == num2);
Console.WriteLine(num1.Equals(num2));

Console.WriteLine(9.65m - 6.65m);


int num3 = 256000;
Console.WriteLine(num3);

string hello = "cool";
char letter =  Convert.ToChar("B");

char hello1 = 'f';
Console.WriteLine(hello1);

Console.WriteLine(hello);

switch(hello){
    case "ok":
    Console.WriteLine("ok");
    break;
    case "cool":
    Console.WriteLine("Cool");
    break;
    default:
    Console.WriteLine("cool from default case");
    break;
}

int[] arrOfNums = new int[]{10, 20, 30, 40, 50, 60};

int sum = arrOfNums[0];

for (int i = 1; i < arrOfNums.GetLength(0); i++)
{
    sum += arrOfNums[i];
}

Console.WriteLine(sum);

int result = arrOfNums.Sum();

Console.WriteLine(result);

List<string> names12 = new List<string>(){"Rakul","alia","Kriti"};

Console.WriteLine(names12[2]);

names12[1] = "Sree leela";

Console.WriteLine("<--------------------------------->");

foreach (var item in names12)
{
    Console.WriteLine(item);
}


var date = new DateOnly();

Console.WriteLine(date);


DateTime date1 = new DateTime();

Console.WriteLine(date);

// DateTime time = DateTime.now;

// Console.WriteLine(time);

int[,] arr = new int[,]{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

foreach (var item in arr)
{
    if(item > 5){
        Console.WriteLine(item);
    }
}
Console.WriteLine("------------------>>>");
for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
        if(arr[i,j] > 5){
            Console.WriteLine(arr[i,j]);
            continue;
        }
    }
}

int index = 1;
while(index <= 10){
    Console.WriteLine("Roshan Shaik");
    index++;
}

int pos = 1;
// int pos;

do{
    // pos = 1;
    Console.WriteLine("Natasha Malkova");
    pos += 1;
}while(pos <= 10);


 static void pro(int[] arr){
    foreach (var item in arr)
    {
        if(item % 2 == 0){
            Console.WriteLine(item);
        }
    }
}


int[] arr1 = {10,30,5,6,35,60};

pro(arr1);









































































































