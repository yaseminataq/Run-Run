using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> maps;
    public int map;
    private float LostPost;
    void Start()
    {
        for (int i = 0; i < map; i++)
        {
            int newýd = i;
            int RandomMap = Random.Range(1, maps.Count);
            GameObject newMap = Instantiate(maps[RandomMap]);
            if (newýd == 0) 
            {
                newMap.transform.position = new Vector3(LostPost + 18.46f, 0, 0);
            }
            else
            {
                LostPost = newMap.transform.position.x;
            }
        }
    }

    
}
