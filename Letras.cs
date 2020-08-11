// usar o LINQ

string Tests = "Hi,World,Me,Hi,You";
string[] Tests_Array = Tests.Split(",");
string result = String.Join(",", Tests_Array.Distinct());

// Usar Replace/Regex

var words = new HashSet<string>();
string text = "Hi,World,Me,Hi,You";
text = Regex.Replace(text, "\w+", t => words.Add(t.Value.ToUpperInvariant())? t.Value: String.Empty);