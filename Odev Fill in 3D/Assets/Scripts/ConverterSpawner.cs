using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverterSpawner : MonoBehaviour
{
    public GameObject converterObj;
    private int i;
    Vector3 converterBlockPos = new Vector3(2f, 0.1f, -5f);
    
    void Start()
    {
        CreateConverterCubes();
    }
    void CreateConverterCubes()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int z = 0; z < 5; z++)
                {
                    i++;
                    converterBlockPos = new Vector3(x, y, z)*0.2f;
                    GameObject cubeObj = Instantiate(converterObj, transform);
                    cubeObj.transform.localPosition = converterBlockPos;
                    cubeObj.transform.localScale = Vector3.one * 0.2f;
                    if (i > 111)
                    {
                        return;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            gameObject.tag = "Converted";
        }
    }
}
