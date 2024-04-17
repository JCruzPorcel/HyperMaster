using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Variable para almacenar la distancia del objeto a la c�mara
    public float distanceFromCamera = 10f;

    void Update()
    {
        // Obtener la posici�n del mouse en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convertir la posici�n del mouse de coordenadas de pantalla a coordenadas del mundo
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distanceFromCamera));

        // Actualizar la posici�n del objeto para que siga al mouse
        transform.position = mousePosition;
    }
}
