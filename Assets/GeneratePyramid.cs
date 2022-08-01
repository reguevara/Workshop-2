using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GeneratePyramid : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();

        meshFilter.mesh = CreateMesh();
        
    }

    /*

    // Update is called once per frame
    void Update()
    {
        
    }*/

    private Mesh CreateMesh()
    {
        var mesh = new Mesh
        {
            name = "Pyramid"
        };

         mesh.SetVertices(new[]
        {
    

            // Bottom face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            

            // Face 1
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            
           
            
            // Face 2
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            

            // Face 3

            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),

            
            // Face 4

            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            
            
            
            
        });

         mesh.SetColors(new[]
        {
           

            // Bottom face
            Color.red,
            Color.red,
            Color.red,
            
            Color.red,
            Color.red,
            Color.red,

            // Left face
            Color.yellow, 
            Color.yellow,
            Color.yellow,
            
            

            // Right face
            Color.blue, 
            Color.blue,
            Color.blue,
            
            
            
            // Define more colours here!

            Color.red,
            Color.red,
            Color.red,

           
            // Define more colours here!

            Color.blue,
            Color.blue,
            Color.blue,
            
           
        });

        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);
        
        // Note that the topology argument specifies that we are in fact
        // defining *triangles* in our indices array. It is also possible to
        // define the mesh surface using quads (MeshTopology.Quads).

        return mesh;
    }
}
