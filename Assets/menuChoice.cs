using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class menuChoice : MonoBehaviour
{
    public Sprite buttonDefaultBackground;
    public Sprite buttonChoiceBackground;
    public Sprite ChoiceMenuBackground;
    public Sprite MenuBackground;

    //public Sprite BananaImage;
    //public Sprite BlueberryImage;
    //public Sprite StrawberryImage;

    public Sprite[] Stage1ToppingImage;
    public Sprite[] Stage1FlavorImage;
    public Sprite[] Stage1AddShotCreamImage;
    public Sprite[] Stage1BeverageImage;

    GameObject[] OptionImage = new GameObject[3];
    bool showMenu = false;

    GameObject ToppingButton;
    GameObject FlavorButton;
    GameObject AddShotCreamButton;
    GameObject BeverageButton;
    // 배열으로 바꿀 수 있으면 바꾸기

    //GameObject Option1Image;
    //GameObject Option2Image;
    //GameObject Option3Image;
    
    menu menuScript;

    bool NextMenuCheck;

    bool isChoice = false;


    public bool[] ToppingList = new bool[3];
    public bool[] FlavorList;
    public bool[] AddShotCreamList;
    public bool[] BeverageList;

    string pageName;
    string listName;
    public bool checkNext;

    List<Dictionary<string, object>> orders;

    // Start is called before the first frame update
    void Start()
    {
        orders = CSVReader.Read("order");

        menuScript = transform.parent.GetComponent<menu>();

        ToppingButton = transform.Find("Button").GetChild(0).gameObject;
        FlavorButton = transform.Find("Button").GetChild(1).gameObject;
        AddShotCreamButton = transform.Find("Button").GetChild(2).gameObject;
        BeverageButton = transform.Find("Button").GetChild(3).gameObject;

        //Option1Image = transform.Find("Option1Image").gameObject;
        //Option2Image = transform.Find("Option2Image").gameObject;
        //Option3Image = transform.Find("Option3Image").gameObject;

        for(int i = 0; i < 3; i++)
        {
            string obName = "Option" + (i + 1) + "Image";
            //Debug.Log(obName);
            OptionImage[i] = transform.Find(obName).gameObject;
        }

        ClickToppingButton();

        ToppingList = new bool[Stage1ToppingImage.Length];
        FlavorList = new bool[Stage1FlavorImage.Length];
        AddShotCreamList = new bool[Stage1AddShotCreamImage.Length];
        BeverageList = new bool[Stage1BeverageImage.Length];
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.activeSelf)
        //{
        //    Time.timeScale = 0;
        //}
        //if (!gameObject.activeSelf)
        //{
        //    Time.timeScale = 1;
        //}
    }

    void resetButtonBackground()
    {
        ToppingButton.GetComponent<Image>().sprite = buttonDefaultBackground;
        FlavorButton.GetComponent<Image>().sprite = buttonDefaultBackground;
        AddShotCreamButton.GetComponent<Image>().sprite = buttonDefaultBackground;
        BeverageButton.GetComponent<Image>().sprite = buttonDefaultBackground;
    }

    public void ClickToppingButton()
    {
        pageName = "Topping";

        //GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        resetButtonBackground();
        ToppingButton.GetComponent<Image>().sprite = buttonChoiceBackground;


        for (int i = 0; i < 3; i++)
        {
            if (ToppingList[i] == true)
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Topping[i].Price.ToString();
            }

            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1ToppingImage[i];

            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.Topping[i].Name;
        }
    }

    public void ClickFlavorButton()
    {
        pageName = "Flavor";

        resetButtonBackground();
        FlavorButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        for (int i = 0; i < 3; i++)
        {
            if (FlavorList[i] == true)
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Flavor[i].Price.ToString();
            }

            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1FlavorImage[i];

            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.Flavor[i].Name;

        }


    }

    public void ClickAddShotCreamButton()
    {
        pageName = "AddShotCream";

        resetButtonBackground();
        AddShotCreamButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        for (int i = 0; i < 3; i++)
        {
            if (AddShotCreamList[i] == true)
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.AddShotCream[i].Price.ToString();
            }
            
            
            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1AddShotCreamImage[i];

            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.AddShotCream[i].Name;
        }
    }

    public void ClickBeverageButton()
    {
        pageName = "Beverage";

        resetButtonBackground();
        BeverageButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        if (Stage1BeverageImage.Length > 3) transform.Find("Button").GetChild(4).gameObject.SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            if (BeverageList[i] == true)
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Beverage[i].Price.ToString();
            }


            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i];

            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.Beverage[i].Name;
        }
    }

    public void ClickNextMenuButton()
    {
        NextMenuCheck = !NextMenuCheck;

        if (NextMenuCheck)
        {
            for (int i = 0; i < 3; i++)
            {

                if (BeverageList[i+3] == true)
                {
                    OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                    OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                    OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                    OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                    = "$ " + menuScript.Beverage[i + 3].Price.ToString();
                }

                OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i+3];
                //OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                //    = "$ " + menuScript.Beverage[i+3].Price.ToString();
                OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                    = menuScript.Beverage[i+3].Name;


            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {

                if (BeverageList[i] == true)
                {
                    OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = ChoiceMenuBackground;
                    OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    OptionImage[i].transform.GetChild(0).GetComponent<Image>().sprite = MenuBackground;
                    OptionImage[i].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                    OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                    = "$ " + menuScript.Beverage[i].Price.ToString();
                }

                OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i];
                //OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                //    = "$ " + menuScript.Beverage[i].Price.ToString();
                OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                    = menuScript.Beverage[i].Name;
            }
        }
    }

    public void ChoiceMenu()
    {
        isChoice = !isChoice;

        listName = pageName + "List";

        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        if (clickObject.GetComponent<Image>().sprite == MenuBackground)
        {

            setChoiceState(clickObject, true, ChoiceMenuBackground);
            //ToppingList[int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = true;
            //setChoiceState(listName, clickObject);
            //Debug.Log("ToppingList" + (int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1) + ": "
            //    + ToppingList[int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1]);
        }
        else
        {
            setChoiceState(clickObject, false, MenuBackground);

            //ToppingList[int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = false;

            //Debug.Log("ToppingList" + (int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1) + ": "
            //               + ToppingList[int.Parse(clickObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1]);

        }

    }

    void setChoiceState(GameObject gameObject, bool state, Sprite background)
    {
        gameObject.GetComponent<Image>().sprite = background;
        //gameObject.transform.GetChild(0).gameObject.SetActive(!state);
        gameObject.transform.GetChild(0).gameObject.SetActive(!state);

        if (pageName == "Topping")
        {
            ToppingList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = state;
        }
        else if (pageName == "Flavor")
        {
            FlavorList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = state;
        }
        else if (pageName == "AddShotCream")
        {
            AddShotCreamList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = state;
        }
        else if (pageName == "Beverage")
        {
            if(Stage1BeverageImage.Length > 3)
            {
                if (NextMenuCheck)
                {
                    BeverageList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) + 2] = state;

                }
                else
                {
                    BeverageList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = state;

                }
            }
        }
    }

    //void setDefaultState(GameObject gameObject)
    //{
    //    if (pageName == "Topping")
    //    {
    //        ToppingList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = false;
    //    }
    //    else if (pageName == "Flavor")
    //    {
    //        FlavorList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = false;
    //    }
    //    else if (pageName == "AddShotCream")
    //    {
    //        AddShotCreamList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = false;
    //    }
    //    else if (pageName == "Beverage")
    //    {
    //        BeverageList[int.Parse(gameObject.transform.parent.transform.gameObject.name.Substring(6, 1)) - 1] = false;
    //    }
    //}

    public void ClickNextButton()
    {
        if (checkMenu())
        {
            Debug.Log("YES");
            //Time.timeScale = 1;

            for (int i = 0; i < ToppingList.Length; i++)
            {
                ToppingList[i] = false;
            }

            for (int i = 0; i < FlavorList.Length; i++)
            {
                FlavorList[i] = false;
            }

            for (int i = 0; i < AddShotCreamList.Length; i++)
            {
                AddShotCreamList[i] = false;
            }

            for (int i = 0; i < BeverageList.Length; i++)
            {
                BeverageList[i] = false;
            }
            //checkNext = false;
            ClickToppingButton();
            transform.Find("Button").GetChild(4).gameObject.SetActive(false);
            gameObject.SetActive(false);

        }
        else
        {
            Debug.Log("NO");
        }
    }

    bool checkMenu()
    {
        string check = "";
        checkNext = false;

        int index = transform.parent.gameObject.GetComponent<test>().FindIndex(transform.parent.GetComponent<test>().StageNum, transform.parent.GetComponent<test>().OrderNum);
        for (int i = 2; i >= 0; i--)
        {
            if (ToppingList[i] == true)
            {
                check += i.ToString();
            }
        }

        if (orders[index]["Topping"].ToString() == check)
        {
            checkNext = true;
        }
        else
        {
            checkNext = false;
        }


        check = "";
        for (int i = 2; i >= 0; i--)
        {
            if (FlavorList[i] == true)
            {
                check += i.ToString();
            }
        }
        if (orders[index]["Flavor"].ToString() == check)
        {
            checkNext = true;
        }
        else
        {
            checkNext = false;
        }

        check = "";
        for (int i = 2; i >= 0; i--)
        {
            if (AddShotCreamList[i] == true)
            {
                check += i.ToString();
            }
        }
        if (orders[index]["AddShotCream"].ToString() == check)
        {
            checkNext = true;
        }
        else
        {
            checkNext = false;
        }

        check = "";
        for (int i = 5; i >= 0; i--)
        {
            if (BeverageList[i] == true)
            {
                check += i.ToString();
            }
        }

        if (orders[index]["Beverage"].ToString() == check)
        {
            checkNext = true;
        }
        else
        {
            checkNext = false;
        }

        return checkNext;
    }
}
