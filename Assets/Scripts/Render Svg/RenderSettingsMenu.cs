using System.IO;
using UnityEditor;
using UnityEngine;

public class RenderSettingsMenu : MonoBehaviour
{
    // Variables para los par�metros de renderizado
    [SerializeField] private bool enableClipping = true;
    [SerializeField] private Color gradingColor = Color.white;
    [SerializeField] private string svgFileName = "example";

    private ParallaxEffect parallaxEffect;
    private SpriteSvgScript spriteSvgScript;

    private void Start()
    {
        parallaxEffect = FindObjectOfType<ParallaxEffect>();
        spriteSvgScript = FindObjectOfType<SpriteSvgScript>();
    }

    void OnGUI()
    {
        // Definir la posici�n del men�
        Rect menuRect = new Rect(10, 10, 250, 750);

        // Comenzar el �rea del men�
        GUILayout.BeginArea(menuRect);

        // Etiquetas y controles para modificar los par�metros
        for (int i = 0; i < parallaxEffect.parallaxLayers.Count; i++)
        {
            GUILayout.Label("Parallax Speed (" + parallaxEffect.parallaxLayers[i].layerName + "): " + parallaxEffect.parallaxLayers[i].parallaxSpeed);
            parallaxEffect.parallaxLayers[i].parallaxSpeed = GUILayout.HorizontalSlider(parallaxEffect.parallaxLayers[i].parallaxSpeed, 0f, 1f);
        }

        enableClipping = GUILayout.Toggle(enableClipping, "Enable Clipping");

        GUILayout.Label("Grading Color:");
        gradingColor = EditorGUILayout.ColorField(gradingColor);

        GUILayout.Label("SVG File Name:");
        svgFileName = GUILayout.TextField(svgFileName);

        // Agregar la extensi�n ".svg" al nombre del archivo si a�n no est� presente
        if (!svgFileName.EndsWith(".svg"))
        {
            svgFileName += ".svg";
        }

        // Construir la ruta completa del archivo SVG
        string svgFilePath = Path.Combine(Application.dataPath, "Art/Svg", svgFileName);

        if (GUILayout.Button("Show Svg"))
        {
            spriteSvgScript.LoadSvg(svgFilePath);
        }

        // Finalizar el �rea del men�
        GUILayout.EndArea();
    }
}
