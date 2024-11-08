using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer _renderer;

    public MaterialPropertyBlock _propBlock;
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }

    //void Update()
    //{
    //    _renderer.material.color = GetRandomColor();
    //}
   
    public Color GetRandomColor()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }
    void Update()
    {
        _renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor("_Color", GetRandomColor());
        _renderer.SetPropertyBlock(_propBlock);
    }
}
