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
    MESH_TRIANGLE = 0,
    MESH_QUAD,
    MESH_PENTAGON,
    MESH_HEXAGON,
    MESH_HEPTAGON,
    MESH_OCTAGON,
    MESH_NANOGON,
    MESH_DECAGON,
    MESH_CIRCLE,
    MESH_OVAL,
    MESH_STAR
}

public class MeshGenerator
{
    public static MeshData Generate(MeshType meshType)
    {
        switch(meshType)
        {
            //case MeshType.MESH_STAR:
            //    return GenerateStar();

            //case MeshType.MESH_OVAL:
            //    return GenerateOval();

            //case MeshType.MESH_CIRCLE:
            //    return GenerateCircle();

            //case MeshType.MESH_DECAGON:
            //    return GenerateDecagon();

            //case MeshType.MESH_NANOGON:
            //    return GenerateNanogon();

            //case MeshType.MESH_OCTAGON:
            //    return GenerateOctagon();

            //case MeshType.MESH_HEPTAGON:
            //    return GenerateHeptagon();

            //case MeshType.MESH_HEXAGON:
            //    return GenerateHexagon();

            //case MeshType.MESH_PENTAGON:
            //    return GeneratePentagon();

            //case MeshType.MESH_QUAD:
            //    return GenerateQuad();

            case MeshType.MESH_TRIANGLE:
            default:
                return GenerateTriangle();
        }
    }

    private static MeshData GenerateTriangle()
    {
        MeshData meshData = new MeshData();

        // Todo: Add the vertices that makes up triangle
        meshData.vertices = new Vector3[]
        {
        };

        // Todo: Add the sequence of vertices to form the triangle
        meshData.triangles = new int[] 
        { 
        };

        return meshData;
    }
}
