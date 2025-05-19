namespace WordCount;

using System.IO;

public class WordCount
{

	private string path = string.Empty;
	private bool isRead = false;
	private (int, int, int) data = (0, 0, 0);


	public WordCount(string path) {
		this.path = path;
	}

	public bool Ready()
	{
		return File.Exists(path);
	}

	public int Words()
	{

		if(Ready()) {
			var d = All();
			return d.Item1;
		}
		return 0;
	}

	public int Characters()
	{
		if(Ready()) {
			var d = All();
			return d.Item2;
		}
		return 0;
	}

	public int Lines()
	{
		if(Ready()) {
			var d = All();
			return d.Item3;
		}
		return 0;
	}

	public (int, int, int) All()
	{
		if(!isRead) {
			int words = 0;
			int characters = 0;
			int lines = 0;

			StreamReader sr = new StreamReader(path);
			try
			{
				string? line = sr.ReadLine();
				while(line != null) {

					string[] spl = line.Split(" ");
					words += spl.Length;
					characters += line.Length;
					lines++;
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			isRead = true;
			return (words, characters, lines);
		}
		return data;
	}

}
