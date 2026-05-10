string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "@hayworth.com";

string generateEmail(string externalDomain, string username)
{
    string email = (username + externalDomain).ToLower();
    return email;
}

string generateUsername(string[,] array, int i)
{
    string firstTwo = array[i,0].Substring(0,2);
    string combinedName = firstTwo + array[i,1];
    return combinedName;
}

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    string userName = generateUsername(corporate, i);
    string email = generateEmail(externalDomain, userName);
    Console.WriteLine(email);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    string userName = generateUsername(external, i);
    string email = generateEmail(externalDomain, userName);
    Console.WriteLine(email);
}


// string[,] corporate = 
// 	{
// 		{"Robert", "Bavin"}, {"Simon", "Bright"},
// 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
// 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

// 	string[,] external = 
// 	{
// 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
// 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
// 	};

// 	string externalDomain = "hayworth.com";

// 	for (int i = 0; i < corporate.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// 	}

// 	for (int i = 0; i < external.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// 	}

// 	void DisplayEmail(string first, string last, string domain = "contoso.com") 
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}