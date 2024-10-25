# **Complete Project #203** 

## 🎯 Completed Objectives
- **Main Objective:** ✔️ Completed
- **Additional Secondary Objectives:** ✔️ Completed

---

## 📦 2D Prototypes
### 🌌 Camera Parallax
- A parallax effect has been implemented in the camera, creating the illusion of depth by moving objects at different speeds in the background and foreground layers.

### ✂️ Clipping
- A clipping technique has been implemented to display only specific parts of objects, allowing for visual effects such as cutouts or masking.

### 🎨 Color Grading Correction
- Real-time color correction has been integrated to enhance the visual aesthetics of the game, adjusting tones and saturation to achieve desired effects.

### 📄 SVG Rendering from Disk Files
- **The ability to render SVG graphics directly from files stored on disk has been implemented, allowing for additional flexibility in creating visual content. To use this functionality, follow these steps:**
  
  #### **1. Place SVG Files**
  - Make sure to place the SVG files you want to render in the project's specific folder at `..\Assets\Art\Svg`.

  #### **2. Script Implementation**
  - A script has been created that searches for SVG files in the mentioned folder, converts them to XML format, reads them, and then uses them as SVG. Ensure this script is properly integrated into your project and configured to run correctly.

  #### **3. Usage in the Game**
  - Once the script is functioning correctly, you can use SVG graphics in your game like any other resource. You can dynamically load them into scenes as needed to create visual elements.

  - With this implementation, you will have the ability to leverage the versatility and scalability of SVG graphics in your project, making it easier to create and modify visual content efficiently.

---

## 🌍 3D Prototypes
### 🗺️ Environment Mapping (Cubemaps)
- Environment mapping has been added to generate realistic reflections on 3D objects, using cubemaps to capture and project the surrounding environment.

### 💡 Configurable Texture Lighting
- A configurable shader has been created at runtime that combines diffuse and ambient lighting, as well as reflections, to enhance the appearance of 3D objects.

### ✨ Phong Reflection
- The Phong reflection model has been implemented to simulate the behavior of light on reflective surfaces.

### 💨 Motion Blur
- A motion blur effect has been added to simulate motion blur on fast-moving objects, increasing the sense of speed and fluidity in the scene.

### 🔮 Transparent Shaders
- Transparent shaders have been created for objects requiring transparency, such as glass or UI elements, allowing for visibility through them.

### 🖼️ G Buffer Depth + Albedo for Deferred Rendering
- A G buffer that stores depth and albedo information has been implemented for use in deferred rendering, allowing for more advanced and realistic lighting in the scene.

### 🌟 Screen Space Emissive Materials
- An emissive material in screen space has been added, allowing certain objects to emit their own light.

### 📏 Signed Distance Field Rendering
- Signed distance field rendering has been implemented to improve the quality of edges and details of objects, as well as to generate smooth and ambient shading effects.

### 🌑 Variance Shadow Mapping
- Variance shadow mapping has been added to enhance the quality and softness of shadows cast in the scene.

### 🔠 Naming Conventions Used
- A consistent naming convention has been adopted to improve the readability and understanding of the source code, facilitating maintenance and collaboration in the project.

---

## 🎉 Additional Secondary Objectives
- A contextual menu with rendering parameters has been implemented.
- The ability to export to the web has been implemented.
