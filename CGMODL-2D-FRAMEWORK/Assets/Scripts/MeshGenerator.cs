using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MeshData
{
    public string meshName;
    public Vector3[] vertices;
    public int[] triangles;
}

public enum MeshType
{
    MESH_TRIANGLE = 0
}

public class MeshGenerator
{
    public static MeshData Generate(MeshType meshType)
    {
        switch(meshType)
        {
            case MeshType.MESH_TRIANGLE:
            default:
                return GenerateTriangle();
        }
    }

    private static MeshData GenerateTriangle()
    {
        MeshData meshData = new MeshData();
        return meshData;
    }
}
