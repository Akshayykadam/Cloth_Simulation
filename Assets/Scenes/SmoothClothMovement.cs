using UnityEngine;

public class SmoothClothMovement : MonoBehaviour
{
    public Cloth clothComponent;
    public float smoothingFactor = 0.1f;

    void Update()
    {
        // Get the mesh attached to the cloth
        Mesh clothMesh = clothComponent.GetComponent<MeshFilter>().mesh;

        // Smooth cloth movement by interpolating vertex positions
        Vector3[] vertices = clothMesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = Vector3.Lerp(vertices[i], vertices[i] + clothMesh.normals[i], smoothingFactor * Time.deltaTime);
        }

        // Apply updated vertices to the mesh
        clothMesh.vertices = vertices;
        clothMesh.RecalculateNormals(); // Recalculate normals to ensure proper shading
    }
}
