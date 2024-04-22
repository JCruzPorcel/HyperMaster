# **Proyecto Completo #203**
## Se ha completado el objetivo principal y los objetivos secundarios adicionales:

## Prototipos 2D:
### Camera Parallax:
- Se ha implementado una pantalla con efecto de parallax en la cámara, creando la ilusión de profundidad al moverse los objetos a diferentes velocidades en el plano de fondo y el plano frontal.
### Clipping:
- Se ha implementado una técnica de clipping para mostrar solo partes específicas de los objetos, permitiendo crear efectos visuales como recortes o enmascaramientos.
### Color Grading Correction:
- Se ha integrado una corrección de color en tiempo real para mejorar la estética visual del juego, ajustando los tonos y la saturación para lograr efectos deseados.
### SVG Rendering desde archivos en disco:
**Se ha implementado la capacidad de renderizar gráficos SVG directamente desde archivos almacenados en disco, permitiendo una flexibilidad adicional en la creación de contenido visual. Para utilizar esta funcionalidad, sigue los siguientes pasos:**
### **Colocar archivos SVG en la carpeta del proyecto:**
- Asegúrate de colocar los archivos SVG que deseas renderizar en la carpeta específica del proyecto en **..\Assets\Art\Svg.**
### 1. Implementación del Script:
   - Se ha creado un script que busca archivos SVG en la carpeta mencionada, los convierte a formato XML, los lee y luego los utiliza como SVG. Asegúrate de que este script esté correctamente integrado en tu proyecto y configurado para ejecutarse adecuadamente.
###  2. Uso en el juego:
  - Una vez que el script esté funcionando correctamente, puedes utilizar los gráficos SVG en tu juego como cualquier otro recurso. Puedes cargarlos dinámicamente en las escenas según sea necesario para crear elementos visuales.
  - Con esta implementación, tendrás la capacidad de aprovechar la versatilidad y escalabilidad de los gráficos SVG en tu proyecto, lo que facilitará la creación y modificación de contenido visual de manera eficiente.

## Prototipos 3D:
### Environment Mapping (Cubemaps):
- Se ha añadido mapeado de entorno para generar reflexiones realistas en objetos 3D, utilizando cubemaps para capturar y proyectar el entorno circundante.
### Iluminación de Textura Configurable:
- Se ha creado un shader configurable en tiempo de ejecución que combina iluminación difusa y ambiental, así como reflexiones para mejorar la apariencia de los objetos 3D.
### Phong Reflection:
- Se ha implementado el modelo de reflexión de Phong para simular el comportamiento de la luz en superficies reflectantes.
### Motion Blur:
- Se ha añadido un efecto de desenfoque de movimiento para simular la persistencia de la visión en objetos en movimiento rápido, aumentando la sensación de velocidad y fluidez en la escena.
### Transparent Shaders:
- Se han creado shaders transparentes para objetos que requieren transparencia, como vidrios o elementos de interfaz, permitiendo ver a través de ellos.
### G Buffer Depth + Albedo para Deferred rendering:
- Se ha implementado un buffer G que almacena información de profundidad y albedo para utilizar en el proceso de rendering diferido, permitiendo una iluminación más avanzada y realista en la escena.
### Screen Space Emisive Materials:
- Se ha agregado un material emissive en el espacio de pantalla, lo que permite que ciertos objetos emitan luz propia.
### Signed Distance Field Rendering:
- Se ha implementado el renderizado basado en campos de distancia firmados para mejorar la calidad de los bordes y detalles de los objetos, así como para generar efectos de sombreado suave y ambiental.
### Variance Shadow Mapping:
- Se ha añadido mapeado de sombras con varianza para mejorar la calidad y suavidad de las sombras proyectadas en la escena.
### Nomenclatura Utilizada:
- Se ha adoptado una convención de nomenclatura coherente para mejorar la legibilidad y comprensión del código fuente, facilitando el mantenimiento y la colaboración en el proyecto.
- Se ha implementado un menu contextual con parametros de renderizado.
- Se ha implementado el poder exportar a web.
