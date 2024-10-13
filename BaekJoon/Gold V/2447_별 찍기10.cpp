#include <iostream>
using namespace std;

void drawStar(int num,int i,int j)
{
	if ((i / num) % 3 == 1 && (j / num) % 3 == 1)
	{
		cout << ' ';
	}
		
	else
	{
		if (num / 3 == 0)
			cout << '*';	
		else
			drawStar(num/3, i, j);
	}
		
}

int main()
{
	int num;
	cin >> num;
	for (int i = 0 ; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				drawStar(num/3, i, j);
			}
		cout << endl;
		}
	return 0;
}