

#region Lambda Examples

string[] people = {"Helder", "Nicole", "Giovana", "John" };
char letter = 'e';
Console.WriteLine($"People with name contains '{letter}': {(string.Join(", ", people.Where(x => x.Contains(letter))))}");

#endregion

