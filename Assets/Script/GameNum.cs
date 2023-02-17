using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameNum : MonoBehaviour
{
    public int StageNum = 1;
    public int OrderNum = 0;

    public GameObject moneyText;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("Money", 0);
    }

    // Update is called once per frame
    void Update()
    {
        getMoney();
    }

    void getMoney()
    {
        moneyText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("Money").ToString();
    }
}
