int[] array = { 1, 37, 13, 14, 51, 62, 37, 28 };

int n = array.Length;
int find = 37;
int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}