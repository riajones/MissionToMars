using UnityEngine;
using System.Collections;


//This script creates a graph node scructure that
//is used for positioning things throughout the game
public class graph : MonoBehaviour {
	//This array represents the ingame world
	public Node[,] world = new Node[500,500];
	int size;
	bool maketheGraph = true;

	void Start () {

	
	}

	void Update(){
		if (maketheGraph == true) {
			makeGraph();
			maketheGraph = false;

		}
	}

	void makeGraph(){
		//Initializes world array
		//All nodes have pointers to their neighbor nodes
		//Edge nodes have pointers to themselves to stop potential breaks
		size = 500;
		//world = new Node[size][size];
		for (int i = 0; i < size; i++){
			for(int j = 0; j < size; j++){
				
				int[] temps = new int[8];
				temps[0] = i;
				temps[1] = j-1;
				
				temps[2] = i+1;
				temps[3] = j;
				
				temps[4] = i;
				temps[5] = j+1;
				
				temps[6] = i-1;
				temps[7] = j;
				
				for(int it = 0; it < 8; it++){
					if(temps[it] < 0)
						temps[it] = 0;
					else if(temps[it] > size)
						temps[it] = size;
				}
				world[i,j] = new Node(i,j,temps);
			}
		}

	}


	public class Node{
		public int x;
		public int z;
		public string type;
		int[] neighbors = new int[8];

		public Node(int xcord, int zcord, int[] temps){
			x = 250 - xcord;
			z = 259 - zcord;
			type = "dirt";
			for(int i = 0; i < 8; i++)
				neighbors[i] = temps[i];
		}
		public void setType(string newType){
			type = newType;
		}

	}
}
