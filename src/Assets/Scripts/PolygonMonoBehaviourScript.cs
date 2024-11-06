using UnityEngine;

public class PolygonMonoBehaviourScript : MonoBehaviour
{
    Mesh mesh;
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] vertices =
        {
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,0.0f,1.0f),
        };

        Color[] colors = { Color.red, Color.green, Color.blue };
        int[] triangles = { 0, 1, 2 };

        mesh.Clear();
        mesh.SetVertices(vertices);
        mesh.SetColors(colors);
        mesh.SetTriangles(triangles,0);

        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
