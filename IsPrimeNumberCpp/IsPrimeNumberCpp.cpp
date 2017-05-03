// IsPrimeNumberCpp.cpp : コンソール アプリケーションのエントリ ポイントを定義します。
//

#include "stdafx.h"
#include <math.h> 

bool IsPrime(int num);
bool IsPrime3(int num);

int main()
{
	int max = 1000000;

	for (int i = 0; i <= max; i++)
	{
		if (IsPrime(i) != IsPrime3(i)) {
			return -1;
		}
	}

    return 0;
}

bool IsPrime(int num)
{
	if (num < 2) return false;

	for (int i = 2; i < num; i++)
	{
		if (num % i == 0)
		{
			// 素数ではない
			return false;
		}
	}

	// 素数である
	return true;
}

bool IsPrime3(int num)
{
	if (num < 2) return false;
	else if (num == 2) return true;
	else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

	double sqrtNum = sqrt(num);
	for (int i = 3; i <= sqrtNum; i += 2)
	{
		if (num % i == 0)
		{
			// 素数ではない
			return false;
		}
	}

	// 素数である
	return true;
}

