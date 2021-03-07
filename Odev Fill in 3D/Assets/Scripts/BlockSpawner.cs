using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Texture2D texture;
    Vector3 blockPos = Vector3.zero;
    public GameObject baseObj;
    public Color color;
    
    private List<GameObject> createdCubes = new List<GameObject>();

    void Start()
    {
        CreateCubes();
    }
    void CreateCubes()
    {
        for (int x = 0; x < texture.width; x++)
        {
            for (int y = 0; y < texture.height; y++)
            {
                Color color = texture.GetPixel(x, y);
                if (color.a == 0)
                {
                    continue;
                }
                blockPos = new Vector3((x-16)*0.2f, 0.1f, (y-16)*0.2f);
                GameObject cubeObj = Instantiate(baseObj, transform);
                cubeObj.transform.localPosition = blockPos;
                cubeObj.GetComponent<Renderer>().material.color = color;
                cubeObj.transform.localScale = Vector3.one*0.2f; 
                createdCubes.Add(cubeObj);
            }
        }
       //return createdCubes;
    } 
}
