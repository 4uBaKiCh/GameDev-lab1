using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Generator : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private Button button;
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Canvas canvas;
    private int cubeCount;

    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if (inputText != null) cubeCount = int.Parse(inputText.text);
        for (int i = 0; i < cubeCount; i++)
        {
            var value = Random.insideUnitCircle * 1000;

            Vector3 pos = new Vector3(
                value.x,
                Random.Range(0,100),
                value.y);
            Instantiate(cubePrefab, pos, Quaternion.identity);
        }
        canvas.enabled = false;
    }
}
