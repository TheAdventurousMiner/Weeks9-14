using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public enum Form
    {
        caterpillar, cocoon, butterfly
    }

    public Form currentForm = Form.caterpillar;
    public ParticleSystem butterflyParticles;
    public Gradient coccoonGradient, butterflyGradient;

    public float formDuration = 4f;

    private float timeInForm = 0f;
    ParticleSystem.MainModule butterflyModule;


    private void Start()
	{
        butterflyModule = butterflyParticles.main;
        
	}

	// Update is called once per frame
	void Update()
    {

        FormUpdate();

    }
    void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if(timeInForm > formDuration)
        {
            ChangeForm();
        }
    }

    void ChangeForm()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            if (currentForm == Form.caterpillar)
            {
                timeInForm = 0f;
                currentForm = Form.cocoon;
                Debug.Log("Changing form to Cocoon");
                butterflyModule.startColor = coccoonGradient;
            }
            else if (currentForm == Form.cocoon)
            {
                timeInForm = 0f;
                currentForm = Form.butterfly;
                Debug.Log("Changing form to Butterfly");
                butterflyModule.startColor = butterflyGradient;
            }
        }
    }
}
