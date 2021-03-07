using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCont : MonoBehaviour
{
    public Texture2D texture;
    private bool trigged = false;
    private Color orjColor;
    

    // Start is called before the first frame update

    private void Start()
    {
        orjColor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.gray;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Converter") & trigged==false)
        {
            trigged = true;
            Destroy(other.gameObject);
            gameObject.GetComponent<Renderer>().material.color = orjColor;
          

        }
    }
}
