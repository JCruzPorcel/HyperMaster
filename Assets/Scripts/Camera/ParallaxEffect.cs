using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ParallaxLayer
{
    public string layerName;
    public Transform container;
    public float parallaxSpeed;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private float spriteWidth, startPosition;

    public void Init()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        spriteWidth = container.GetComponentInChildren<SpriteRenderer>().bounds.size.x;
        startPosition = container.position.x;
    }

    public void ParallaxUpdate()
    {
        float deltaX = (cameraTransform.position.x - lastCameraPosition.x) * parallaxSpeed;
        float moveAmount = cameraTransform.position.x * (1 - parallaxSpeed);
        container.Translate(new Vector3(deltaX, 0, 0));
        lastCameraPosition = cameraTransform.position;

        if (moveAmount > startPosition + spriteWidth)
        {
            container.Translate(new Vector3(spriteWidth, 0, 0));
            startPosition += spriteWidth;
        }
        else if (moveAmount < startPosition - spriteWidth)
        {
            container.Translate(new Vector3(-spriteWidth, 0, 0));
            startPosition -= spriteWidth;
        }
    }
}

public class ParallaxEffect : MonoBehaviour
{
    public List<ParallaxLayer> parallaxLayers;

    private void Awake()
    {
        foreach (ParallaxLayer layer in parallaxLayers)
        {
            layer.Init();
        }
    }

    private void FixedUpdate()
    {
        foreach (ParallaxLayer layer in parallaxLayers)
        {
            layer.ParallaxUpdate();
        }
    }
}

