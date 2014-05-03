using UnityEngine;
using System.Collections;


//This script creates a graph node scructure that
//is used for positioning things throughout the game
public class graph : MonoBehaviour {
	//This array represents the ingame world
	public Node[][] world;
	public int size;

	void Start () {

		//Initializes world array
		//All nodes have pointers to their neighbor nodes
		//Edge nodes have pointers to themselves to stop potential breaks
		size = 100;
		for (int i = 0; i < size; i++){
			for(int j = 0; j < size; j++){
				world[i][j] = new Node(i,j);

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
				world[i][j].connectNodes(&world[temps[0]][temps[1]],&world[temps[2]][temps[3]],&world[temps[4]][temps[5]],&world[temps[6]][temps[7]]);
			}
		}
	
	}
	
	void Update () {
	
	}



	public class Node{
		int x;
		int z;
		Node*[] connections = new Node[4];

		public Node(int xcord, int ycord){
			x = xcord;
			y = ycord;
		}

		public void connectNodes(Node* up, Node* right, Node* down, Node* left){
			connections [0] = up;
			connections [1] = right;
			connections [2] = down;
			connections [3] = left;
		}

	}
}
