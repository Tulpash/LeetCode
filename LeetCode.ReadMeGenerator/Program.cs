string? solutionDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName;
if (string.IsNullOrEmpty(solutionDir))
    throw new Exception("Неудалось полусить папку решения");

string tasksDir = Path.Combine(solutionDir, "LeetCode.Tasks");
if (!Directory.Exists(tasksDir))
    throw new Exception("Неудалось получить папку проекта с задачами");

List<Line> easy = GetLinesFromDirectory(Path.Combine(tasksDir, "Easy"));
List<Line> medium = GetLinesFromDirectory(Path.Combine(tasksDir, "Medium"));
List<Line> hard = GetLinesFromDirectory(Path.Combine(tasksDir, "Hard"));

string readMeFile = Path.Combine(solutionDir, "README.md");
if (File.Exists(readMeFile))
    File.Delete(readMeFile);

using (StreamWriter writer = new(readMeFile))
{
    writer.WriteLine("## Table of contents");
    writer.WriteLine("- [Easy](#-easy)");
    writer.WriteLine("- [Medium](#-medium)");
    writer.WriteLine("- [Hard](#-hard)");
    writer.WriteLine();

    writer.WriteLine("### Easy"); 
    WriteLines(writer, easy);
    writer.WriteLine("### Medium");
    WriteLines(writer, medium);
    writer.WriteLine("### Hard");
    WriteLines(writer, hard);
}
   
void WriteLines(StreamWriter writer, List<Line> lines)
{
    writer.WriteLine("|Id|Name|Link|");
    writer.WriteLine("|:-|:-|:-|");
    foreach (Line line in lines)
        writer.WriteLine($"|{line.Number}|{line.Name}|{line.Link}|");
    writer.WriteLine();
}
List<Line> GetLinesFromDirectory(string directory)
{
    if (!Directory.Exists(directory))
        return new();

    string[] files = Directory.GetDirectories(directory).Select(dir => Path.Combine(dir, "Solution.CS")).ToArray();
    List<Line> lines = new();
    foreach (string file in files)
    {
        if (!File.Exists(file))
            continue;

        using (StreamReader reader = new(file))
        {
            string? first = reader.ReadLine();
            string? second = reader.ReadLine();

            lines.Add(new()
            {
                Number = int.Parse(first?.Substring(2).Split(".")[0].Trim() ?? "-1"),
                Name = first?.Substring(2).Split(".")[1].Trim(),
                Link = second?.Substring(2)
            });
        }
    }

    return lines.OrderBy(l => l.Number).ToList();
}
class Line
{
    public int Number {  get; set; }
    public string? Name { get; set; }
    public string? Link { get; set; }
}