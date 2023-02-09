using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineMaterials : MonoBehaviour
{

    public Material[] materials;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go.GetComponent<Renderer>().materials = materials;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
