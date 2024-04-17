using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColorGradingControl : MonoBehaviour
{
    [SerializeField] private Volume volume;
    private ColorAdjustments colorAdjustments;

    private float contrastValue = 0f;
    private float saturationValue = 0f;
    private float hueValue = 0f;

    void Start()
    {
        if (volume.profile.TryGet(out ColorAdjustments adjustments))
        {
            colorAdjustments = adjustments;
        }
        else
        {
            Debug.LogError("No se pudo encontrar el componente ColorAdjustments en el volumen.");
        }
    }

    void OnGUI()
    {
        float areaWidth = 250f;
        float areaHeight = 700f;
        float padding = 10f;
        float xPos = Screen.width - areaWidth - padding;
        float yPos = padding;

        GUILayout.BeginArea(new Rect(xPos, yPos, areaWidth, areaHeight));
        GUILayout.Label("Ajustes de Color Grading");

        GUILayout.BeginHorizontal();
        GUILayout.Label("Contraste: ");
        contrastValue = GUILayout.HorizontalSlider(contrastValue, -100f, 100f);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Saturación: ");
        saturationValue = GUILayout.HorizontalSlider(saturationValue, -100f, 100f);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Tono: ");
        hueValue = GUILayout.HorizontalSlider(hueValue, -180f, 180f);
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Restablecer"))
        {
            ResetValues();
        }

        GUILayout.EndArea();

        // Aplicar los cambios cuando se ajustan los sliders
        SetContrast(contrastValue);
        SetSaturation(saturationValue);
        SetHue(hueValue);
    }

    // Método para ajustar el contraste
    public void SetContrast(float contrastValue)
    {
        if (colorAdjustments != null)
        {
            colorAdjustments.contrast.value = contrastValue;
        }
    }

    // Método para ajustar la saturación
    public void SetSaturation(float saturationValue)
    {
        if (colorAdjustments != null)
        {
            colorAdjustments.saturation.value = saturationValue;
        }
    }

    // Método para ajustar el tono
    public void SetHue(float hueValue)
    {
        if (colorAdjustments != null)
        {
            colorAdjustments.hueShift.value = hueValue;
        }
    }

    // Método para restablecer los valores a los predeterminados
    public void ResetValues()
    {
        contrastValue = 0f;
        saturationValue = 0f;
        hueValue = 0f;

        SetContrast(contrastValue);
        SetSaturation(saturationValue);
        SetHue(hueValue);
    }
}
