using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshObject : MonoBehaviour
{
    [SerializeField]
    MeshType meshType;

    [SerializeField]
    bool startAtOrigin = false;

    Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        if(startAtOrigin)
            transform.position = new Vector3(0, 0, 0);

        InitialiseMesh();
    }

    void InitialiseMesh()
    {
        mesh.Clear();

        MeshData meshData = MeshGenerator.Generate(meshType);
        mesh.vertices = meshData.vertices;
        mesh.triangles = meshData.triangles;

    }
}
