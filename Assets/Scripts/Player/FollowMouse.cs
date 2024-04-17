using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Variable para almacenar la distancia del objeto a la cámara
    public float distanceFromCamera = 10f;

    void Update()
    {
        // Obtener la posición del mouse en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convertir la posición del mouse de coordenadas de pantalla a coordenadas del mundo
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distanceFromCamera));

        // Actualizar la posición del objeto para que siga al mouse
        transform.position = mousePosition;
    }
}
