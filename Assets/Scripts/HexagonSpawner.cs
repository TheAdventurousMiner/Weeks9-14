using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HexagonSpawner : MonoBehaviour
{
    public GameObject hexagonPrefab;
    public Button hexagonColourizerButton;
    public HexagonCounter hexagonCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSpawnClick()
    {
        Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * 5;

        //Spawned a new hexagon (when we clicked the button)
        GameObject spawnedHexagonObject = Instantiate(hexagonPrefab, spawnPosition, Quaternion.identity);
        //Get access to its hexagon script
        HexagonColourizer spawnedHexagon = spawnedHexagonObject.GetComponent<HexagonColourizer>();
        //spawnedHexagon.onColourChange is the event of this specific spawned hexagon

        //we are adding a new listener which will do something everytime the colour of this hexagon
        //changes for whatever reason

        //The listener is the HexagonCounter (which manages the text of the count)
        //And the method is going to increase the count every time we change the colour
        //of this hexagon.
        hexagonColourizerButton.onClick.AddListener(spawnedHexagon.OnColourizeClick);

        spawnedHexagon.onColourChange.AddListener(hexagonCounter.IncreaseCount);
    }
}
