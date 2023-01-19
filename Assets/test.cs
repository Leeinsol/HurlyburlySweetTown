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

    public int StageNum = 1;
    int OrderNum = 0;

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
        CustomerMessage.SetActive(false);

        //Debug.Log(menuScript.Topping[0].Name);

        saveToppingList(0);
        saveTotalPrice(0);

        //for (int i = 0; i < orders.Count; i++)
        //{
        //    if (orders[i]["stage"].ToString() == "2")
        //    {
        //        Debug.Log(i+" "+ orders[i]["menuNum"].ToString());
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (csvNum == 0 && !isTyping)
        {
            NameText.GetComponent<TextMeshProUGUI>().text = FindMessage(StageNum, "SalespersonName",-1);// data[0]["message"].ToString();
            //StartCoroutine(typing(SalespersonMessageText, data[0]["message"].ToString()));
            StartCoroutine(typing(SalespersonMessageText, FindMessage(0, "SalespersonText",0)));
        }
        else if (csvNum == 1 && !isTyping)
        {
            CustomerMessage.SetActive(true);

            //StartCoroutine(typing(CustomerMessageText, data[1]["message"].ToString()));
            StartCoroutine(typing(CustomerMessageText, FindOrder(StageNum, 0)));
        }
        else if (csvNum == 2 && !isTyping)
        {
            Invoke("setActiveCustomerMessage", 1f);
            clearMessageText(SalespersonMessageText);
            orderSheet.SetActive(true);

            FindMenuName(0);
            orderSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
                =  "1 " + menuScript.Flavor[(int)orders[0]["Flavor"]].Name + " " + menuName;

            for (int i = orders[0]["Topping"].ToString().Length - 1; i >= 0; i--)
            {

                orderSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
                += "\n+ " + menuScript.Topping[int.Parse(orders[OrderNum]["Topping"].ToString().Substring(i, 1))].Name;


            }

            //orderSheet.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text
            //    = "+ " + menuScript.Flavor[ToppingList[1]].Name;

            orderSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
                += "\n+ " + menuScript.AddShotCream[(int)orders[0]["AddShotCream"]].Name;


            orderSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
                += "\n" + orders[0]["BeverageNum"].ToString() + " " + menuScript.Beverage[(int)orders[0]["Beverage"]].Name;

            orderSheet.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = orders[0]["TotalPrice"].ToString();
            CustomerMessage.SetActive(false);

            StartCoroutine(typing(SalespersonMessageText, FindMessage(0, "SalespersonText", 1)));
        }
        else if (csvNum == 3 && !isTyping)
        {
            //Invoke("setActiveCustomerMessage", 1f);
            CustomerMessage.SetActive(true);

            StartCoroutine(typing(CustomerMessageText, FindMessage(0, "CustomerText", 0)));
        }

    }

    string FindMessage(int stage, string type, int messageNum)
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (int.Parse(data[i]["stage"].ToString()) == stage 
                && data[i]["type"].ToString() == type 
                && int.Parse(data[i]["messageNum"].ToString()) == messageNum)
            {
                Debug.Log(data[i]["message"].ToString());
                return data[i]["message"].ToString();
            }
        }
        return null;
    }

    string FindOrder(int stage, int orderNum)
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i]["stage"].ToString() == stage.ToString()
                && data[i]["orderNum"].ToString() == orderNum.ToString())
            {
                Debug.Log(data[i]["message"].ToString());
                return data[i]["message"].ToString();
            }
        }
        return null;
    }

    void saveTotalPrice(int OrderNum)
    {
        //Debug.Log(menuScript.Flavor[(int)orders[0]["Flavor"]].Price);
        totalPrice += menuScript.Flavor[(int)orders[OrderNum]["Flavor"]].Price;

        for (int i = orders[OrderNum]["Topping"].ToString().Length - 1; i >= 0; i--)
        {
            totalPrice += menuScript.Topping[ToppingList[i]].Price;
        }

        totalPrice += menuScript.AddShotCream[(int)orders[OrderNum]["AddShotCream"]].Price;
        totalPrice += menuScript.Beverage[(int)orders[OrderNum]["Beverage"]].Price;
        orders[0]["TotalPrice"] = totalPrice;
        totalPrice = 0;
    }

    void saveToppingList(int OrderNum)
    {
        for (int i = orders[OrderNum]["Topping"].ToString().Length - 1; i >= 0; i--)
        {
            ToppingList[i] = int.Parse(orders[OrderNum]["Topping"].ToString().Substring(i, 1));

            //totalPrice += menuScript.Topping[ToppingList[i]].Price;
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

    void setActiveCustomerMessage()
    {
        CustomerMessage.SetActive(false);
        clearMessageText(CustomerMessageText);
    }

    void clearMessageText(TextMeshProUGUI text)
    {
        text.text = "";
    }

    IEnumerator typing(TextMeshProUGUI MessageText,string message)
    {
        //if (!MessageText.transform.parent.gameObject.activeSelf) MessageText.transform.parent.gameObject.SetActive(true);
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
