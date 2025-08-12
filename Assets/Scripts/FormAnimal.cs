using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormAnimal : MonoBehaviour
{
    public float formDuration = 4f;
    private float timeInForm = 0f;

    private void ChangeForm()
    {
        Debug.Log("Form Change");
    }

    public void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            ChangeForm();
        }
    }
}
