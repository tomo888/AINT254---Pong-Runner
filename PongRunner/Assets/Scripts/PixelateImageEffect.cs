using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] //for debugging purposes
public class PixelateImageEffect : MonoBehaviour
{

    public Material effectMaterial;

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        Graphics.Blit(src, dst, effectMaterial);
    }
}
