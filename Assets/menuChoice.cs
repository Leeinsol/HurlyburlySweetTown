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


    bool[] ToppingList;

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log(obName);
            OptionImage[i] = transform.Find(obName).gameObject;
        }

        ClickToppingButton();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        //GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        resetButtonBackground();
        ToppingButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        //if (!showMenu)
        //{
        //    //clickObject.GetComponent<Image>().sprite = buttonChoiceBackground;
        //    showMenu = true;
        //}


        //Option1Image.transform.GetChild(2).GetComponent<Image>().sprite = BananaImage;
        //Option1Image.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
        //    = "$ " + menuScript.Topping[0].Price.ToString();
        //Option1Image.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text 
        //    = menuScript.Topping[0].Name;

        //Option2Image.transform.GetChild(2).GetComponent<Image>().sprite = BlueberryImage;
        //Option2Image.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
        //    = "$ " + menuScript.Topping[1].Price.ToString();
        //Option2Image.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
        //    = menuScript.Topping[1].Name;

        //Option3Image.transform.GetChild(2).GetComponent<Image>().sprite = StrawberryImage;
        //Option3Image.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
        //    = "$ " + menuScript.Topping[2].Price.ToString();
        //Option3Image.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
        //    = menuScript.Topping[2].Name;

        for (int i = 0; i < 3; i++)
        {
            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1ToppingImage[i];
            OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Topping[i].Price.ToString();
            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.Topping[i].Name;
        }
    }

    public void ClickFlavorButton()
    {
        resetButtonBackground();
        FlavorButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        for (int i = 0; i < 3; i++)
        {
            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1FlavorImage[i];
            OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Flavor[i].Price.ToString();
            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.Flavor[i].Name;
        }
    }

    public void ClickAddShotCreamButton()
    {
        resetButtonBackground();
        AddShotCreamButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        for (int i = 0; i < 3; i++)
        {
            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1AddShotCreamImage[i];
            OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.AddShotCream[i].Price.ToString();
            OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                = menuScript.AddShotCream[i].Name;
        }
    }

    public void ClickBeverageButton()
    {
        resetButtonBackground();
        BeverageButton.GetComponent<Image>().sprite = buttonChoiceBackground;

        if (Stage1BeverageImage.Length > 3) transform.Find("Button").GetChild(4).gameObject.SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i];
            OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                = "$ " + menuScript.Beverage[i].Price.ToString();
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
                OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i+3];
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                    = "$ " + menuScript.Beverage[i+3].Price.ToString();
                OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                    = menuScript.Beverage[i+3].Name;
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                OptionImage[i].transform.GetChild(2).GetComponent<Image>().sprite = Stage1BeverageImage[i];
                OptionImage[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text
                    = "$ " + menuScript.Beverage[i].Price.ToString();
                OptionImage[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text
                    = menuScript.Beverage[i].Name;
            }
        }
    }

    public void ChoiceMenu()
    {
        isChoice = !isChoice;

        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        if (clickObject.GetComponent<Image>().sprite == MenuBackground)
        {
            clickObject.GetComponent<Image>().sprite = ChoiceMenuBackground;
            clickObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            clickObject.GetComponent<Image>().sprite = MenuBackground;
            clickObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        
    }

    public void ClickNextButton()
    {

    }
}
