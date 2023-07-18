int[] array = { 12, 23, 34, 4, 65, 76, 78, 89, 90 };

int n = array.Length;
int find = 76;
int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		System.Console.WriteLine(index);
		break;
	}
	index++;
}