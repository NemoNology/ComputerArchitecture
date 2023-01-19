#pragma once
#include <fstream>
#include <iostream>
#include <vector>
#include <string>

using namespace std;


string fname = "MM.txt";
fstream f;
string temp;
vector<string> arr = { " ", " ", " ", " " };
int number;

vector<int> fullAddr = { 0, 0 };
int addr = 0;

const int N = 10, M = 4;






int GetAddrByKey(int key)
{
	f.open(fname);
	
	//fullAddr[0] = fullAddr[1] = 0;
	fullAddr[0] = 0;
	fullAddr[1] = 0;
	addr = 0;
	
	while (!f.eof())
	{
		for (int i = 0; i < M; i++)
		{
			f >> temp;
			fullAddr[1] = i;
			
			if (stoi(temp) == key)
			{
				return addr;
			}
			
		}
		
		addr++;
		fullAddr[0]++;
		
	}
	
	f.close();
	
	return -1;
}


int GetNumByAddr(int page, int number)
{
	f.open(fname);
	
	int currentPage = 1;
	
	while (!f.eof())
	{
		for (int i = 0; i < M; i++)
		{
			f >> temp;
			
			if (currentPage == page && i == number)
			{
				return stoi(temp);
			}
			
		}
		
		currentPage++;
		
	}
	
	f.close();
	
	return -1;
}



class Cache
{
private:

	vector<vector<int>> _memory(N);
	
	for (int i = 0; i < N; i++)
	{
		_memory[i].resize(M);
	}

public:

	void searchNum(int num)
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < M; j++)
			{
				if (_memory[i][j] == num)
				{
					cout << "\n";
				}
			}
		}
	}

}
