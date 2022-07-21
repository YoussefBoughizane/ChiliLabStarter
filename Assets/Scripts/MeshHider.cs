using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshHider : MonoBehaviour
{
    // Start is called before the first frame update

    private MeshRenderer []meshes;  
    void Start()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
        print(meshes); 
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }


    public void hide()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
        foreach (var mesh in meshes){
            mesh.enabled = false; 
        }
    }
    public void show()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
        foreach (var mesh in meshes)
        {
            mesh.enabled = true;
        }

    }
}
