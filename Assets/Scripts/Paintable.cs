using System.Collections;
using System.IO;
using UnityEngine;

public class Paintable : MonoBehaviour
{

    public GameObject Brush;
    public float BrushSize = 0.1f;
    

   
    void Start()
    {

    }

    
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                
                var go = Instantiate(Brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * BrushSize;
            }

        }
    }

  

    
}

    


