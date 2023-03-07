using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ranking : MonoBehaviour
{
    public TextMeshProUGUI[] bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<5; i++)
        {
            bestScoreText[i].gameObject.GetComponent<TextMeshProUGUI>().text = string.Format("{0:N3}", PlayerPrefs.GetFloat(i + "BestScore"));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
