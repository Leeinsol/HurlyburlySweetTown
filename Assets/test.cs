using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class test : MonoBehaviour
{
    List<Dictionary<string, object>> data;
    List<Dictionary<string, object>> orders;

    TextMeshProUGUI NameText;
    TextMeshProUGUI SalespersonMessageText;
    TextMeshProUGUI CustomerMessageText;

    public GameObject SalespersonMessage;
    public GameObject CustomerMessage;

    public bool isTyping = false;
    public int csvNum = 0;
    menu menuScript;

    public GameObject order;
    public GameObject orderSheet;

    string menuName;
    int[] ToppingList = new int[10];

    public float totalPrice = 0;
    // Start is called before the first frame update
    void Start()
    {
        menuScript = GetComponent<menu>();
        orderSheet.SetActive(false);
        NameText = SalespersonMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        SalespersonMessageText = SalespersonMessage.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        CustomerMessageText = CustomerMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        
        clearMessageText(SalespersonMessageText);
        clearMessageText(CustomerMessageText);

        data = CSVReader.Read("SweetTown");
        orders= CSVReader.Read("order");

        Debug.Log(menuScript.Topping[0].Name);

    }

    // Update is called once per frame
    void Update()
    {
        if (csvNum == 0 && !isTyping)
        {
            NameText.GetComponent<TextMeshProUGUI>().text = data[0]["name"].ToString();
            StartCoroutine(typing(SalespersonMessageText, data[0]["message"].ToString()));
        }
        else if (csvNum == 1 && !isTyping)
        {
            StartCoroutine(typing(CustomerMessageText, data[1]["message"].ToString()));
        }
        else if (csvNum == 2 && !isTyping)
        {
            Invoke("setActiveGameObject", 1f);
            clearMessageText(SalespersonMessageText);
            orderSheet.SetActive(true);

            FindMenuName(0);
            orderSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
                = orders[0]["menuNum"].ToString() + " " + menuScript.Flavor[(int)orders[0]["Flavor"]].Name + " " + menuName;
            totalPrice += menuScript.Flavor[(int)orders[0]["Flavor"]].Price;

            //ToppingList = new int[orders[0]["Topping"].ToString().Length];
            //Debug.Log(orders[0]["Topping"].ToString().Length);
for (int i=0; i< orders[0]["Topping"].ToString().Length; i++)
            {
                //ToppingList = new int[1];
                ToppingList[i] = int.Parse(orders[0]["Topping"].ToString().Substring(i, 1));
                //ToppingList[i] = int.Parse(orders[0]["Topping"].ToString()) % 10;
                //Debug.Log("ToppingList" + i + ToppingList[i]);
                Debug.Log(orders[0]["Topping"].ToString());
                orderSheet.transform.GetChild(i + 1).GetComponent<TextMeshProUGUI>().text
                = "+ " + menuScript.Flavor[ToppingList[i]-1].Name;

                totalPrice += menuScript.Flavor[ToppingList[i] - 1].Price;
            }

            

            //orderSheet.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text
            //    = "+ " + menuScript.Flavor[ToppingList[1]].Name;

            orderSheet.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text
                = "+ " + menuScript.AddShotCream[(int)orders[0]["AddShotCream"]].Name;
            totalPrice += menuScript.AddShotCream[(int)orders[0]["AddShotCream"]].Price;

            orderSheet.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text
                = orders[0]["BeverageNum"].ToString() + " " + menuScript.Beverage[(int)orders[0]["Beverage"]].Name;
            totalPrice += menuScript.Beverage[(int)orders[0]["Beverage"]].Price;
            csvNum++;
            orderSheet.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = totalPrice.ToString();            
        }
    }
    void FindMenuName(int index)
    {
        if ((int)orders[index]["stage"] == 1) menuName = "pancakes";
        else if ((int)orders[index]["stage"] == 2) menuName = "muffins";
    }
    void setActiveGameObject()
    {
        if (csvNum == 2) CustomerMessage.SetActive(false);
    }

    void clearMessageText(TextMeshProUGUI text)
    {
        text.text = "";
    }

    IEnumerator typing(TextMeshProUGUI MessageText,string message)
    {
        isTyping = true;
        yield return new WaitForSeconds(1f);


        for(int i=0; i< message.Length; i++)
        {
            MessageText.text = message.Substring(0, i+1);

            yield return new WaitForSeconds(0.01f);
        }

        csvNum++;
        isTyping = false;
    }
}
