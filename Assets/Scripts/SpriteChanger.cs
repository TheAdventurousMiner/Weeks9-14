using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite originalSprite, changedSprite;
    public GameObject defaultObject;
    public GameObject prefab;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = defaultObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MouseOnImage()
    {
        spriteRenderer.sprite = changedSprite;
    }

    public void MouseOffImage()
    {
        spriteRenderer.sprite = originalSprite;
    }
    public void ClickedImage()
    {
        Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * 5;

        GameObject spawnedPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
