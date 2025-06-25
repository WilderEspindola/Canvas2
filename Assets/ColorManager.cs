using UnityEngine;

public class ColorManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Renderer colorCube;
    public Color startColor= Color.green;
    void Start()
    {
        colorCube.material.color = startColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
