using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameFlow : MonoBehaviour
{
    //Platform Related Variables
    public Transform platformObj;
    private Vector3 positionOffset = new Vector3(0,0, 1495);
    private Vector3 scaleOffset = new Vector3(10, 1, 4000);

    //Obstacles Related Variables
    public Transform ObstacleObj;
    private Vector3 nextObstacleSpawn = new Vector3(0, 1, 0);
    
    //int[] position = { -4,-2, 0, 2, 4 };
    
    int totalObstacles;
    int temp;
    int upperLimit = 5;

    private void Start()
    {
        StartCoroutine(incrementPlatform());
    }

    IEnumerator incrementPlatform()
    {
        yield return new WaitForSeconds(1f);

        //Platform Scale Increment
        platformObj.localScale = scaleOffset;
        positionOffset.z += 1000 / 2;
        platformObj.position = positionOffset;
        scaleOffset.z += 1000;

        //Obstacle Placement
        totalObstacles = Random.Range(2, 4);
        for (int x = 0; x < 1000 / 30; x++)
        {
            List<int> position = new List<int>() { -4, -2, 0, 2, 4 };
            upperLimit = 5;
            nextObstacleSpawn.z += 30;
            for (int i = 0; i < totalObstacles; i++)
            {
                temp = Random.Range(0, upperLimit--);
                nextObstacleSpawn.x = position[temp];
                position.RemoveAt(temp);
                Instantiate(ObstacleObj, nextObstacleSpawn, ObstacleObj.rotation);
            }
        }
        StartCoroutine(incrementPlatform());
    }
}
