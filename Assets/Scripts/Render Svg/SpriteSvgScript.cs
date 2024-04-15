using System.Collections.Generic;
using System.IO;
using Unity.VectorGraphics;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteSvgScript : BaseSvgScript
{
    public void LoadSvg(string svgFilePath)
    {
        if (File.Exists(svgFilePath))
        {
            string svgContent = File.ReadAllText(svgFilePath);
            Debug.Log("SVG Content: " + svgContent);

            this.svg = svgContent;

            List<VectorUtils.Geometry> geometries = GetGeometries();

            var sprite = VectorUtils.BuildSprite(geometries, pixelsPerUnit, VectorUtils.Alignment.Center, Vector2.zero, 128, flipYAxis);
            GetComponent<SpriteRenderer>().sprite = sprite;
        }
        else
        {
            Debug.LogError("El archivo SVG no existe en la ruta especificada: " + svgFilePath);
        }
    }
}
