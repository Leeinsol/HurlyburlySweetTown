using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bakingEdit : MonoBehaviour
{
    public Sprite[] backGrounds = new Sprite[7];
    public GameObject BackGround;
    public SpriteRenderer backRenderer;

    public List<GameObject> toDestroy = new List<GameObject>();
    List<Dictionary<string, object>> orders;
    //0:flavor1, 1:flavor2, 2:topping1, 3:topping2, 4:cream1, 5:cream2, 6:beverage
    public int[] menuList = new int[7];

    public GameObject startButton;
    public TextMeshProUGUI minigameDirectionText;
    public GameObject blueList;
    public GameObject bluePlus;
    public Slider slTimer;

    public GameObject perfect;
    GameObject clonedPerfect;
    public GameObject tryAgain;
    GameObject clonedTryAgain;
    public GameObject complete;
    GameObject clonedComplete;

    public GameObject menu1;
    GameObject clonedMenu1;
    public GameObject cooker;
    GameObject clonedCooker;

    public GameObject milk;
    GameObject clonedMilk;
    public GameObject flour;
    GameObject clonedFlour;
    public GameObject sugar;
    GameObject clonedSugar;
    public GameObject butter;
    GameObject clonedButter;
    public GameObject eggs;
    GameObject clonedEggs;
    public GameObject insideEgg;
    GameObject clonedInsideEgg;
    public GameObject crackedEgg;
    GameObject clonedCrackedEgg;

    public GameObject bowl;
    GameObject clonedBowl;
    public GameObject whippper;
    GameObject clonedWhipper;

    public GameObject milkButton;
    GameObject clonedMilkButton;
    public GameObject flourButton;
    GameObject clonedFlourButton;
    public GameObject eggButton;
    GameObject clonedEggButton;
    public GameObject sugarButton;
    GameObject clonedSugarButton;
    public GameObject butterButton;
    GameObject clonedButterButton;

    public GameObject filledMilk;
    GameObject clonedFilledMilk;
    public GameObject filledFlour;
    GameObject clonedFilledFlour;
    public GameObject filledSugar;
    GameObject clonedFilledSugar;
    public GameObject slicedButter;
    GameObject clonedSlicedButter;

    public GameObject muffinTray;
    GameObject clonedMuffinTray;
    public GameObject pipingBag;
    GameObject clonedPipingBag;

    public GameObject pinkDough;
    GameObject clonedPinkDough;
    public GameObject chocoDough;
    GameObject clonedChocoDough;
    public GameObject vanillaDough;
    GameObject clonedVanillaDough;

    public GameObject openedOven;
    GameObject clonedOpenedOven;
    public GameObject closedOven;
    GameObject clonedClosedOven;

    public GameObject pinkChocoTray;
    GameObject clonedPinkChocoTray;
    public GameObject vanillaChocoTray;
    GameObject clonedVanillaChocoTray;
    public GameObject vanillaPinkTray;
    GameObject clonedVanillaPinkTray;

    //����?
    GameObject clonedTray;

    public GameObject ovenSwitch;
    GameObject clonedOvenSwitch;
    public GameObject temperatureOrder;
    GameObject clonedTemperatureOrder;
    public GameObject temperatureChoice;
    GameObject clonedTemperatureChoice;
    public GameObject arrow;
    GameObject clonedArrow;
    public GameObject degreeOfRoasting;
    GameObject clonedDegreeOfRoasting;
    public GameObject roastingButton;
    GameObject clonedRoastingButton;
    public GameObject x;
    GameObject clonedX;
    public GameObject redButton;
    GameObject clonedRedButton;
    public GameObject warning;
    GameObject clonedWarning;

    public GameObject greyMuffinTray;
    GameObject clonedGreyMuffinTray;
    public GameObject chocoMuffinBread;
    GameObject clonedChocoMuffinBread;
    public GameObject redMuffinBread;
    GameObject clonedRedMuffinBread;
    public GameObject vanillaMuffinBread;
    GameObject clonedVanillaMuffinBread;

    GameObject clonedLeftBread;
    GameObject clonedRightBread;

    public GameObject whiteSharpCream;
    GameObject clonedWhiteSharpCream;
    public GameObject cheeseSharpCream;
    GameObject clonedCheeseSharpCream;
    public GameObject chocoSharpCream;
    GameObject clonedChocoSharpCream;

    GameObject clonedLeftCream;
    GameObject clonedRightCream;

    public GameObject miniGameTitle;
    GameObject clonedMiniGameTitle;
    public GameObject miniGameDirection;
    GameObject clonedMiniGameDirection;

    public GameObject chocoMilkMuffin;
    GameObject clonedChocoMilkMuffin;
    public GameObject pinkCheeseMuffin;
    GameObject clonedPinkCheeseMuffin;

    public GameObject chocoCherryMuffin;
    GameObject clonedChocoCherryMuffin;
    public GameObject chocoOreoMuffin;
    GameObject clonedChocoOreoMuffin;
    public GameObject pinkCherryMuffin;
    GameObject clonedPinkCherryMuffin;

    GameObject clonedCupcake;
    GameObject clonedFinishedCupcake;
    public GameObject clonedFirstMuffin;

    public GameObject iceBox;
    GameObject clonedIceBox;
    public GameObject yogurt;
    GameObject clonedYogurt;
    public GameObject emptyMixer;
    GameObject clonedEmptyMixer;

    public GameObject strawberryCup;
    GameObject clonedStrawberryCup;
    public GameObject oreoCup;
    GameObject clonedOreoCup;
    public GameObject vanillaCup;
    GameObject clonedVanillaCup;
    GameObject clonedCup;

    public GameObject strawberryMixer;
    GameObject clonedStrawberryMixer;
    public GameObject oreoMixer;
    GameObject clonedOreoMixer;
    public GameObject vanillaMixer;
    GameObject clonedVanillaMixer;

    GameObject clonedFullMixer;

    public GameObject mixerLid;
    GameObject clonedMixerLid;
    public GameObject mixerButton;
    GameObject clonedMixerButton;

    public GameObject filledMilkForMixer;
    GameObject clonedFilledMilkForMixer;
    public GameObject ice;
    GameObject clonedIce;
    public GameObject filledYogurt;
    GameObject clonedFilledYogurt;

    public GameObject strawberryBundle;
    GameObject clonedStrawberryBundle;
    public GameObject oreoBundle;
    GameObject clonedOreoBundle;
    public GameObject vanillaBundle;
    GameObject clonedVanillaBundle;
    GameObject clonedCorrectBundle;

    public GameObject completeStrawberryMixer;
    GameObject clonedCompleteStrawberryMixer;
    public GameObject completeOreoMixer;
    GameObject clonedCompleteOreoMixer;
    public GameObject completeVanillaMixer;
    GameObject clonedCompleteVanillaMixer;
    GameObject clonedCompleteMixer;

    public GameObject iceButton;
    GameObject clonedIceButton;
    public GameObject yogurtButton;
    GameObject clonedYogurtButton;
    public GameObject strawberryButton;
    //GameObject clonedStrawberryButton;
    public GameObject oreoButton;
    //GameObject clonedOreoButton;
    public GameObject vanillaButton;
    //GameObject clonedVanillaButton;
    GameObject clonedButton;

    public GameObject pinkCup;
    public GameObject brownCup;
    public GameObject yelloCup;
    GameObject clonedDrinkCup;

    public GameObject whipping;
    GameObject clonedWhipping;
    public GameObject whiteCream;
    GameObject clonedWhiteCream;
    public GameObject chocoSyrup;
    GameObject clonedChocoSyrup;

    public GameObject dottedLine;
    GameObject clonedDottedLine;
    public GameObject chocoLine;
    GameObject clonedChocoLine;

    public GameObject bell;
    GameObject clonedBell;

    public GameObject firstCompleteMuffin;
    public GameObject secondCompleteMuffin;
    public GameObject thirdCompleteMuffin;
    GameObject clonedCompleteMuffin;

    public GameObject firstBev;
    public GameObject secondBev;
    public GameObject thirdBev;
    GameObject clonedBev;

    bool isMixing = false;
    bool isMuffinDough = false;
    bool isBaking = false;
    bool isWhipping = false;
    bool isMiniGame = false;
    bool isMixer = false;
    bool isDrink = false;
    bool isFinishBack = false;

    bool isShowPerfect = false;
    bool isMuffinBack = false;

    public bool[] checkMixingIngredients = new bool[5]; //0:milk, 1:flour, 2:egg, 3:sugar, 4:butter
    public bool[] checkDoughReady = new bool[2]; //0:left tray, 1:right tray
    public bool[] checkMuffinWhipping = new bool[2]; //0:left cream, 1: right cream
    public bool[] checkMixerIngredients = new bool[4]; //0:milk, 1:ice, 2:strawberry, 3:yogurt
    bool isButterReady = false;
    bool isOvenReady = false;
    bool spinArrow = false;
    bool stopRoastingButton = false;
    Vector3 roastingButtonStartingPos = new Vector3(-3.001f, -3.328f, 0);

    Vector3 targetPos = new Vector3(2.78f, -3.328f, 0);
    Vector2 objPos = new Vector2(-5.27f, -2.48f);
    public Vector3 nowPos;

    public bool clearMiniGame = false;
    Vector3 endPos;

    public int correctToppingNum;

    bool canMixThings = false;
    bool changeMixer = false;

    Animator strawberryMixerAnim;
    Animator oreoMixerAnim;
    Animator vanillaMixerAnim;
    Animator correctMixerAnim;

    float blinkDuration = 1f;
    float fadeTime = 2f;
    SpriteRenderer whippingRenderer;
    Color originalColor;

    public GameObject linePrefab;
    GameObject clonedLinePrefab;
    LineRenderer lr;
    EdgeCollider2D lineCol;
    List<Vector2> syrupPoints = new List<Vector2>();
    bool isSyrupDragging = false;
    List<Vector3> drawnPositions = new List<Vector3>();

    //public bool[] readyToMoveDish = new bool[2]; //0:complete muffin, 1:bev
    bool readyToMoveDish = false;
    bool goDish = false;
    bool canFinish = false;

    GameObject AudioManager;
    AudioSource audioMan;
    AudioSource audioSource;

    public AudioClip miniGameBackSound;
    public AudioClip mixingBowlSound;
    public AudioClip openingOvenSound;
    public AudioClip ovenDoneSound;
    public AudioClip squishingSound;
    public AudioClip bellSound;
    public AudioClip timerWarningSound;

    bool isPlusPageOn = false;
    GameObject plusPage;

    bool minusHeartisCalled = false;

    float[] bestScore = new float[5];

    // Start is called before the first frame update
    void Start()
    {
        orders = CSVReader.Read("order");

        startButton.SetActive(false);
        blueList.SetActive(false);
        bluePlus.SetActive(false);
        slTimer.gameObject.SetActive(false);

        GameObject Direction = minigameDirectionText.gameObject;
        Direction.SetActive(false);

        //strawberryMixerAnim = strawberryMixer.GetComponent<Animator>();

        showOrderBack();

        checkMenu();

        audioSource = GetComponent<AudioSource>();
        AudioManager = GameObject.Find("AudioManager");
        audioMan = AudioManager.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMixing || isMuffinDough || isBaking ||
            isWhipping || isMiniGame || isMixer || isDrink)
        {
            Timer();
        }

        if (isMixing)
        {
            Mix();
        }

        if (isMuffinDough)
        {
            makeMuffinDough();
        }

        if (isBaking)
        {
            Baking();
        }

        if(isWhipping)
        {
            BreadWhipping();
        }

        if(isMiniGame)
        {
            miniGame();
        }

        if(isMixer)
        {
            MixerOn();
        }

        if(isDrink)
        {
            decoDrink();
        }

        if(isFinishBack)
        {
            deliver();
        }
    }

    public void playWarningSound()
    {
        if (slTimer.value <= 30f && slTimer.value > 0.0f)//30second left
        {
            //Debug.Log("�ǳ�?");
            if(audioSource.clip != timerWarningSound)
            {
                audioSource.clip = timerWarningSound;
                audioSource.loop = false;
                audioSource.volume = 1f;
                audioSource.Play();
            }
        }
    }

    void Timer()
    {
        if(isMixing || isMuffinDough || isBaking ||
            isWhipping || isMiniGame || isMixer || isDrink)
        {
            slTimer.gameObject.SetActive(true);
        }

        if (slTimer.value > 0.0f)
            slTimer.value -= Time.deltaTime;
        else
        {
            if(!minusHeartisCalled)
            {
                //Debug.Log("Time is zero");
                //GameObject.Find("GameNum").GetComponent<GameNum>().heartNum--;
                //minusHeartisCalled = true;

                PlayerPrefs.SetInt("heartNum", PlayerPrefs.GetInt("heartNum") - 1);
                PlayerPrefs.Save();

                minusHeartisCalled = true;
            }
        }
    }

    void resetHeartCalled()
    {
        minusHeartisCalled = false;
    }

    public void clickBlueList()
    {
        if(isPlusPageOn == false) //������������
        {
            isPlusPageOn = true;

            plusPage = Instantiate(menu1, new Vector3(997, 489, 0),
                Quaternion.identity, GameObject.Find("Canvas").transform);
        }
        else if(isPlusPageOn == true) //����������
        {
            isPlusPageOn = false;
            Destroy(plusPage);
        }
    }

    public void checkMenu()
    {
        int index = findIndex(GameObject.Find("GameSetting").GetComponent<GameNum>().StageNum,
            GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum);

        string flavor = orders[index]["Flavor"].ToString();
        string topping = orders[index]["Topping"].ToString();
        string cream = orders[index]["AddShotCream"].ToString();
        string beverage = orders[index]["Beverage"].ToString();

        //0:flavor1, 1:flavor2, 2:topping1, 3:topping2, 4:cream1, 5:cream2, 6:beverage
        menuList[0] = int.Parse(flavor.Substring(0, 1)); //flavor1
        menuList[1] = int.Parse(flavor.Substring(1, 1)); //flavor2
        menuList[2] = int.Parse(topping.Substring(0, 1)); //topping1
        menuList[3] = int.Parse(topping.Substring(1, 1)); //topping2
        menuList[4] = int.Parse(cream.Substring(0, 1)); //cream1
        menuList[5] = int.Parse(cream.Substring(1, 1)); //cream2
        menuList[6] = int.Parse(beverage); //beverage

        correctToppingNum = menuList[3];
    }

    public int findIndex(int stage, int orderNum)
    {
        for (int i = 0; i < orders.Count; i++)
        {
            if (orders[i]["stage"].ToString() == stage.ToString()
                && orders[i]["orderNum"].ToString() == orderNum.ToString())
            {
                return i;
            }
        }
        return -1;
    }

    void showOrderBack()
    {
        Invoke("showCooker", 1f);
        Invoke("showMenu", 1.5f);
        Invoke("showStartButton", 2f);
    }

    void showMenu()
    {
        //if (!toDestroy.Contains(clonedMenu1))
        //{
        //    clonedMenu1 = Instantiate(menu1, new Vector3(-4.2622f, 0.0368f, 0), Quaternion.identity);
        //    toDestroy.Add(clonedMenu1);
        //}

        clonedMenu1 = Instantiate(menu1, new Vector3(440, 510, 0), 
            Quaternion.identity, GameObject.Find("Canvas").transform);
        toDestroy.Add(clonedMenu1);
    }

    void showCooker()
    {
        if (!toDestroy.Contains(clonedCooker))
        {
            clonedCooker = Instantiate(cooker, new Vector3(3.820035f, -1.48f, 0), Quaternion.identity);
            toDestroy.Add(clonedCooker);
        }
    }

    void showStartButton()
    {
        startButton.SetActive(true);
    }

    public void clickStartButton()
    {
        startButton.SetActive(false);

        int temp = toDestroy.Count;
        for (int i = 0; i < temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        Invoke("showMixingBack", 1f);
    }

    void showMixingBack()
    {
        isMixing = true;

        blueList.SetActive(true);
        bluePlus.SetActive(true);

        backRenderer.sprite = backGrounds[0];

        if (!toDestroy.Contains(clonedMilk))
        {
            clonedMilk = Instantiate(milk, new Vector3(-8.59f, -0.36f, 0), Quaternion.identity);
            toDestroy.Add(clonedMilk);
        }

        if (!toDestroy.Contains(clonedFlour))
        {
            clonedFlour = Instantiate(flour, new Vector3(-7.23f, 0.69f, 0), Quaternion.identity);
            toDestroy.Add(clonedFlour);
        }

        if (!toDestroy.Contains(clonedSugar))
        {
            clonedSugar = Instantiate(sugar, new Vector3(6.08f, 0.17f, 0), Quaternion.identity);
            toDestroy.Add(clonedSugar);
        }

        if (!toDestroy.Contains(clonedButter))
        {
            clonedButter = Instantiate(butter, new Vector3(8.41f, -2.31f, 0), Quaternion.identity);
            toDestroy.Add(clonedButter);
        }

        if (!toDestroy.Contains(clonedEggs))
        {
            clonedEggs = Instantiate(eggs, new Vector3(5.12f, -2.36f, 0), Quaternion.identity);
            toDestroy.Add(clonedEggs);

            SpriteRenderer sr = null;
            sr = clonedEggs.GetComponent<SpriteRenderer>();
            sr.sortingOrder = 3;
        }

        Invoke("showBowl", 0.5f);
    }

    void showBowl()
    {
        if (!toDestroy.Contains(clonedBowl))
        {
            clonedBowl = Instantiate(bowl, new Vector3(0.18f, -1.4f, 0), Quaternion.identity);
            toDestroy.Add(clonedBowl);
        }
    }

    void Mix()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if (Input.GetMouseButtonDown(0))
        {
            if (rayHit.collider != null)
            {
                if (rayHit.collider.gameObject.tag.Equals("milk"))
                {
                    checkMixingIngredients[0] = true;

                    if (!toDestroy.Contains(clonedFilledMilk))
                    {
                        clonedFilledMilk = Instantiate(filledMilk, new Vector3(0.1897f, -2.1815f, 0), Quaternion.identity);
                        clonedFilledMilk.transform.localScale = new Vector3(0.2437005f, 0.2567469f, 0);

                        toDestroy.Add(clonedFilledMilk);
                    }

                    clonedMilkButton = Instantiate(milkButton, new Vector3(3.93f, -2.17f, 0), Quaternion.identity);
                    clonedMilkButton.transform.localEulerAngles = new Vector3(0, 0, -30);
                    Destroy(clonedMilkButton, 1f);

                    SpriteRenderer sr = null;
                    sr = clonedMilkButton.GetComponent<SpriteRenderer>();
                    sr.sortingOrder = 4;
                }

                if (rayHit.collider.gameObject.tag.Equals("flour"))
                {
                    checkMixingIngredients[1] = true;

                    if (!toDestroy.Contains(clonedFilledFlour))
                    {
                        clonedFilledFlour = Instantiate(filledFlour, new Vector3(0.2346f, -0.99f, 0), Quaternion.identity);
                        clonedFilledFlour.transform.localScale = new Vector3(0.2387243f, 0.2413525f, 0);

                        toDestroy.Add(clonedFilledFlour);
                    }

                    clonedFlourButton = Instantiate(flourButton, new Vector3(3.93f, -2.17f, 0), Quaternion.identity);
                    clonedFlourButton.transform.localEulerAngles = new Vector3(0, 0, -30);
                    Destroy(clonedFlourButton, 1f);

                    SpriteRenderer sr = null;
                    sr = clonedFlourButton.GetComponent<SpriteRenderer>();
                    sr.sortingOrder = 4;
                }

                if (rayHit.collider.gameObject.tag.Equals("egg"))
                {
                    checkMixingIngredients[2] = true;

                    if (!toDestroy.Contains(clonedCrackedEgg))
                    {
                        clonedCrackedEgg = Instantiate(crackedEgg, new Vector3(1.47f, 3.24f, 0), Quaternion.identity);
                        toDestroy.Add(clonedCrackedEgg);

                        Invoke("showInsideEgg", 0.1f);

                        Destroy(clonedCrackedEgg, 1f);
                    }

                    clonedEggButton = Instantiate(eggButton, new Vector3(3.85f, 1.83f, 0), Quaternion.identity);
                    Destroy(clonedEggButton, 1f);
                }

                if (rayHit.collider.gameObject.tag.Equals("sugar"))
                {
                    checkMixingIngredients[3] = true;

                    if (!toDestroy.Contains(clonedFilledSugar))
                    {
                        clonedFilledSugar = Instantiate(filledSugar, new Vector3(0.22f, -0.13f, 0), Quaternion.identity);
                        toDestroy.Add(clonedFilledSugar);
                    }

                    clonedSugarButton = Instantiate(sugarButton, new Vector3(3.93f, 2.18f, 0), Quaternion.identity);
                    Destroy(clonedSugarButton, 1f);
                }

                if (rayHit.collider.gameObject.tag.Equals("butter"))
                {
                    checkMixingIngredients[4] = true;

                    if (!toDestroy.Contains(clonedSlicedButter))
                    {
                        clonedSlicedButter = Instantiate(slicedButter, new Vector3(-0.93f, 2.13f, 0), Quaternion.identity);
                        toDestroy.Add(clonedSlicedButter);
                    }

                    clonedButterButton = Instantiate(butterButton, new Vector3(3.93f, 2.18f, 0), Quaternion.identity);
                    Destroy(clonedButterButton, 1f);

                    isButterReady = true;
                }

                if(rayHit.collider.gameObject.tag.Equals("whipper"))
                {
                    audioSource.clip = mixingBowlSound;
                    audioSource.loop = true;
                    audioSource.volume = 1f;
                    audioSource.Play();
                }
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            if(rayHit.collider != null)
            {
                if(rayHit.collider.gameObject.tag.Equals("whipper"))
                {
                    audioSource.Stop();
                    audioSource.clip = null;
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (rayHit.collider != null)
            {
                if (rayHit.collider.gameObject.tag.Equals("whipper"))
                {
                    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                    if (objPosition.x >= -0.95 && objPosition.x <= 3.49
                        && objPosition.y >= 0.16 && objPosition.y <= 1.47)
                    {
                        clonedWhipper.transform.position = objPosition;
                    }

                    if(!toDestroy.Contains(clonedPerfect))
                    {
                        Invoke("showPerfect", 1.5f);
                    }

                    //3�� �� show muffin dough back
                    Invoke("showMuffinDough", 3f);
                }
            }
        }

        if (isButterReady)
        {
            do
            {
                clonedSlicedButter.transform.position =
                    Vector3.MoveTowards(clonedSlicedButter.transform.position, new Vector3(-0.93f, 0.11f, 0), 3 * Time.deltaTime);
            } while (clonedSlicedButter.transform.position.y == 0.11);
        }

        if (checkMixIngredients())
        {
            Invoke("showWhipper", 1f);

            for (int i = 0; i < checkMixingIngredients.Length; i++)
                checkMixingIngredients[i] = false;
        }

    }

    void showInsideEgg()
    {
        if (!toDestroy.Contains(clonedInsideEgg))
        {
            clonedInsideEgg = Instantiate(insideEgg, new Vector3(0, 1.4761f, 0), Quaternion.identity);
            toDestroy.Add(clonedInsideEgg);

            Destroy(clonedInsideEgg, 1f);
        }
    }

    bool checkMixIngredients()
    {
        for (int i = 0; i < checkMixingIngredients.Length; i++)
        {
            if (checkMixingIngredients[i] == false)
                return false;
        }
        return true;
    }

    void showWhipper()
    {
        if (!toDestroy.Contains(clonedWhipper))
        {
            clonedWhipper = Instantiate(whippper, new Vector3(2.07f, 1.3582f, 0), Quaternion.identity);
            toDestroy.Add(clonedWhipper);

            SpriteRenderer sr = null;
            sr = clonedWhipper.GetComponent<SpriteRenderer>();
            sr.sortingOrder = 2;
        }
    }

    void showPerfect()
    {
        if (!toDestroy.Contains(clonedPerfect))
        {
            clonedPerfect = Instantiate(perfect, new Vector3(0, 0, 0), Quaternion.identity);
            toDestroy.Add(clonedPerfect);
        }
    }

    void showMuffinDough()
    {
        isMixing = false;
        isMuffinDough = true;

        int temp = toDestroy.Count;
        for (int i = 0; i < temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        audioSource.Stop();

        backRenderer.sprite = backGrounds[1];
        CancelInvoke();
        Invoke("showMuffinTray", 1f);
        Invoke("showPipingBag", 2f);
    }

    void showMuffinTray()
    {
        if (!toDestroy.Contains(clonedMuffinTray))
        {
            clonedMuffinTray = Instantiate(muffinTray, new Vector3(-1.32f, -0.4f, 0), Quaternion.identity);
            toDestroy.Add(clonedMuffinTray);
        }

    }

    void showPipingBag()
    {
        if (!toDestroy.Contains(clonedPipingBag))
        {
            clonedPipingBag = Instantiate(pipingBag, new Vector3(5.6f, 0.02f, 0), Quaternion.identity);
            toDestroy.Add(clonedPipingBag);
        }
    }

    void makeMuffinDough()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if (Input.GetMouseButton(0))
        {
            if (rayHit.collider != null)
            {
                if (rayHit.collider.gameObject.tag.Equals("pipingBag"))
                {
                    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                    clonedPipingBag.transform.position = objPosition;

                    //right tray
                    if (objPosition.x >= 2f && objPosition.x <= 5.5f
                        && objPosition.y >= 1.66f && objPosition.y <= 3.4f)
                    {
                        checkDoughReady[1] = true;
                        chooseRightDough();
                    }

                    if (objPosition.x >= -3.05f && objPosition.x <= 0.49f
                        && objPosition.y >= 1.69f && objPosition.y <= 3.49f)
                    {
                        checkDoughReady[0] = true;
                        chooseLeftDough();
                    }
                }
            }
        }

        if (checkDough())
        {
            for (int i = 0; i < checkDoughReady.Length; i++)
                checkDoughReady[i] = false;

            if(isShowPerfect == false)
            {
                Invoke("showPerfect", 3f);
                isShowPerfect = true;
            }
            if(isMuffinBack == false)
            {
                Invoke("showMuffinBakingBack", 4.5f);
                isMuffinBack = true;
            }
        }
    }

    void chooseLeftDough()
    {
        //parameter 1 means left tray
        switch (menuList[0])
        {
            case 0:
                //flavor 0: chocolate
                makeChocoDough(1);
                break;
            case 1:
                //flavor 1: red velvet
                makePinkDough(1);
                break;
            case 2:
                //flavor 2: vanilla
                makeVanillaDough(1);
                break;
        }
    }

    void chooseRightDough()
    {
        switch (menuList[1])
        {
            case 0:
                //flavor 0: chocolate
                makeChocoDough(2);
                break;
            case 1:
                //flavor 1: red velvet
                makePinkDough(2);
                break;
            case 2:
                //flavor 2 : vanilla
                makeVanillaDough(2);
                break;
        }
    }

    void makePinkDough(int pos)
    {
        if (pos == 1)
        {
            if (!toDestroy.Contains(clonedPinkDough))
            {
                clonedPinkDough = Instantiate(pinkDough, new Vector3(-3.8622f, 0.6083f, 0), Quaternion.identity);
                toDestroy.Add(clonedPinkDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInPinkCream());
            }
        }
        else if (pos == 2)
        {
            if (!toDestroy.Contains(clonedPinkDough))
            {
                clonedPinkDough = Instantiate(pinkDough, new Vector3(1.23f, 0.56f, 0), Quaternion.identity);
                toDestroy.Add(clonedPinkDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInPinkCream());
            }
        }
    }

    void makeChocoDough(int pos)
    {
        if (pos == 1)
        {
            if (!toDestroy.Contains(clonedChocoDough))
            {
                //�̰� ����
                clonedChocoDough = Instantiate(chocoDough, new Vector3(-3.8622f, 0.6083f, 0), Quaternion.identity);
                toDestroy.Add(clonedChocoDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInChocoCream());
            }
        }
        else if (pos == 2)
        {
            if (!toDestroy.Contains(clonedChocoDough))
            {
                clonedChocoDough = Instantiate(chocoDough, new Vector3(1.23f, 0.56f, 0), Quaternion.identity);
                toDestroy.Add(clonedChocoDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInChocoCream());
            }
        }

    }

    void makeVanillaDough(int pos)
    {
        if (pos == 1)
        {
            if (!toDestroy.Contains(clonedVanillaDough))
            {
                clonedVanillaDough = Instantiate(vanillaDough, new Vector3(-3.8622f, 0.6083f, 0), Quaternion.identity);
                toDestroy.Add(clonedVanillaDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInVanillaCream());
            }
        }
        else if (pos == 2)
        {
            if (!toDestroy.Contains(clonedVanillaDough))
            {
                clonedVanillaDough = Instantiate(vanillaDough, new Vector3(1.23f, 0.56f, 0), Quaternion.identity);
                toDestroy.Add(clonedVanillaDough);

                audioSource.clip = squishingSound;
                audioSource.loop = false;
                audioSource.Play();

                StartCoroutine(FadeInVanillaCream());
            }
        }
    }

    IEnumerator FadeInPinkCream()
    {
        float elapsedTime = 0f;
        SpriteRenderer pinkDoughRenderer;
        Color pinkDoughOriginalColor;
        float fadeDuration = 2f;

        pinkDoughRenderer = clonedPinkDough.GetComponent<SpriteRenderer>();
        pinkDoughOriginalColor = pinkDoughRenderer.color;
        pinkDoughRenderer.color = new Color(pinkDoughOriginalColor.r, pinkDoughOriginalColor.g,
            pinkDoughOriginalColor.b, 0);

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            pinkDoughRenderer.color = new Color(pinkDoughOriginalColor.r, pinkDoughOriginalColor.g,
                pinkDoughOriginalColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        pinkDoughRenderer.color = pinkDoughOriginalColor;
        audioSource.Stop();
    }

    IEnumerator FadeInChocoCream()
    {
        float elapsedTime = 0f;
        SpriteRenderer chocoDoughRenderer;
        Color chocoDoughOriginalColor;
        float fadeDuration = 2f;

        chocoDoughRenderer = clonedChocoDough.GetComponent<SpriteRenderer>();
        chocoDoughOriginalColor = chocoDoughRenderer.color;
        chocoDoughRenderer.color = new Color(chocoDoughOriginalColor.r, chocoDoughOriginalColor.g,
            chocoDoughOriginalColor.b, 0);

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            chocoDoughRenderer.color = new Color(chocoDoughOriginalColor.r, chocoDoughOriginalColor.g,
                chocoDoughOriginalColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        chocoDoughRenderer.color = chocoDoughOriginalColor;
        audioSource.Stop();
    }

    IEnumerator FadeInVanillaCream()
    {
        float elapsedTime = 0f;
        SpriteRenderer vanillaDoughRenderer;
        Color vanillaDoughOriginalColor;
        float fadeDuration = 2f;

        vanillaDoughRenderer = clonedVanillaDough.GetComponent<SpriteRenderer>();
        vanillaDoughOriginalColor = vanillaDoughRenderer.color;
        vanillaDoughRenderer.color = new Color(vanillaDoughOriginalColor.r, vanillaDoughOriginalColor.g,
            vanillaDoughOriginalColor.b, 0);

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            vanillaDoughRenderer.color = new Color(vanillaDoughOriginalColor.r, vanillaDoughOriginalColor.g,
                vanillaDoughOriginalColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        vanillaDoughRenderer.color = vanillaDoughOriginalColor;
        audioSource.Stop();
    }

    bool checkDough()
    {
        for (int i = 0; i < checkDoughReady.Length; i++)
        {
            if (checkDoughReady[i] == false)
                return false;
        }
        return true;
    }

    void showMuffinBakingBack()
    {
        isMuffinDough = false;
        isBaking = true;

        int temp = toDestroy.Count;
        for (int i = 0; i < temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        backRenderer.sprite = backGrounds[0];

        //clonedClosedOven = Instantiate(closedOven, new Vector3(0, -0.56f, 0), Quaternion.identity);

        if (!toDestroy.Contains(clonedClosedOven))
        {
            clonedClosedOven = Instantiate(closedOven, new Vector3(0, -0.56f, 0), Quaternion.identity);
            toDestroy.Add(clonedClosedOven);


        }

        if (!toDestroy.Contains(clonedOvenSwitch))
        {
            clonedOvenSwitch = Instantiate(ovenSwitch, new Vector3(-3.85f, 2.4f, 0), Quaternion.identity);
            toDestroy.Add(clonedOvenSwitch);
        }
    }

    void Baking()
    {

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if(Input.GetMouseButtonDown(0))
        {
            if(rayHit.collider != null)
            {
                if(rayHit.collider.gameObject.tag.Equals("ovenHandle"))
                {
                    Destroy(clonedClosedOven);
                    toDestroy.Remove(clonedClosedOven);

                    if(!toDestroy.Contains(clonedOpenedOven))
                    {
                        clonedOpenedOven = Instantiate(openedOven, new Vector3(0, -0.56f, 0), Quaternion.identity);

                        clonedOvenSwitch.transform.position = new Vector3(-3.84f, 2.67f, 0);

                        audioSource.clip = openingOvenSound;
                        audioSource.loop = false;
                        audioSource.Play();
                        
                        toDestroy.Add(clonedOpenedOven);
                    }

                    if(!toDestroy.Contains(clonedRedButton))
                    {
                        clonedRedButton = Instantiate(redButton, new Vector3(-0.98f, 2.25f, 0), Quaternion.identity);
                        clonedRedButton.transform.localScale = new Vector3(0.25f, 0.25f, 0);
                        toDestroy.Add(clonedRedButton);
                    }

                    if(!toDestroy.Contains(clonedTray))
                    {
                        clonedTray = Instantiate(chooseFilledTray(), new Vector3(0, -4.98f, 0), Quaternion.identity);
                        toDestroy.Add(clonedTray);

                        Invoke("moveTray", 1f);

                        isOvenReady = true;
                    }
                }

                if(rayHit.collider.gameObject.tag.Equals("ovenDoor"))
                {
                    Destroy(clonedOpenedOven);

                    if (!toDestroy.Contains(clonedClosedOven))
                    {
                        clonedClosedOven = Instantiate(closedOven, new Vector3(0, -0.56f, 0), Quaternion.identity);
                        toDestroy.Add(clonedClosedOven);

                        clonedOvenSwitch.transform.position = new Vector3(-3.81f, 2.41f, 0);

                        SpriteRenderer traySR = clonedTray.GetComponent<SpriteRenderer>();
                        Color c = traySR.color;
                        c.a = 0.5f;
                        traySR.color = c;



                        Invoke("showTemperatureOrder", 1f);
                        Invoke("showTemperatureChoice", 2.5f);
                    }
                }

                if(rayHit.collider.gameObject.tag.Equals("ovenSwitch"))
                {
                    //spinArrow = !spinArrow;
                    spinArrow = false;

                    if(checkTemperatureDegree())
                    {
                        Invoke("showRoasting", 1f);
                    }
                    else if(!checkTemperatureDegree())
                    {
                        clonedX = Instantiate(x, new Vector3(-1.44f, -0.69f, 0), Quaternion.identity);
                        Destroy(clonedX, 1f);

                        spinArrow = true;
                    }
                }

                if (rayHit.collider.gameObject.tag.Equals("redButton"))
                {
                    stopRoastingButton = true;
                    checkRoastingButtonPos(clonedRoastingButton.transform.position);
                }
            }
        }

        if (isOvenReady)
        {
            clonedTray.transform.localScale = new Vector3(0.25f, 0.25f, 0);

            clonedTray.transform.localPosition =
                Vector3.MoveTowards(clonedTray.transform.position,
                new Vector3(0, -0.79f, 0), 5 * Time.deltaTime);
        }

        if(spinArrow)
        {
            clonedArrow.transform.Rotate(0, 0, -1);
        }


        if(toDestroy.Contains(clonedDegreeOfRoasting))
        {
            if (!stopRoastingButton)
            {
                clonedRoastingButton.transform.position =
                    Vector3.MoveTowards(clonedRoastingButton.transform.position,
                    new Vector3(2.78f, -3.328f, 0), 5 * Time.deltaTime);
            }
            if (clonedRoastingButton.transform.position.x >= 2.78f)
            {
                clonedRoastingButton.transform.position = roastingButtonStartingPos;
                //stopRoastingButton = false;
                Invoke("moveButtonAgain", 0.8f);
            }
        }
    }

    void moveTray()
    {
        isOvenReady = false;
    }

    void showTemperatureOrder()
    {
        if(!toDestroy.Contains(clonedTemperatureOrder))
        {
            clonedTemperatureOrder = Instantiate(temperatureOrder, new Vector3(-0.99f, 0.57f, 0), Quaternion.identity);
            toDestroy.Add(clonedTemperatureOrder);

            Destroy(clonedTemperatureOrder, 1f);
        }
    }

    void showTemperatureChoice()
    {
        if(!toDestroy.Contains(clonedTemperatureChoice))
        {
            clonedTemperatureChoice = Instantiate(temperatureChoice, new Vector3(-1.35f, -0.29f, 0), Quaternion.identity);
            toDestroy.Add(clonedTemperatureChoice);
        }

        if(!toDestroy.Contains(clonedArrow))
        {
            clonedArrow = Instantiate(arrow, new Vector3(-1.35f, -0.62f, 0), Quaternion.identity);
            toDestroy.Add(clonedArrow);

            Invoke("startRotateArrow", 1f);
        }
    }

    void startRotateArrow()
    {
        spinArrow = true;
    }

    bool checkTemperatureDegree()
    {
        if (clonedArrow.transform.rotation.eulerAngles.z >= 170
            && clonedArrow.transform.rotation.eulerAngles.z <= 190)
            return true;
        return false;
    }

    void showRoasting()
    {
        Destroy(clonedArrow);
        Destroy(clonedTemperatureChoice);

        if(!toDestroy.Contains(clonedDegreeOfRoasting))
        {
            clonedDegreeOfRoasting = Instantiate(degreeOfRoasting,
                new Vector3(0, -2.9f, 0), Quaternion.identity);
            toDestroy.Add(clonedDegreeOfRoasting);
        }

        if(!toDestroy.Contains(clonedRoastingButton))
        {
            clonedRoastingButton = Instantiate(roastingButton,
                new Vector3(-3.001f, -3.328f, 0), Quaternion.identity);
            toDestroy.Add(clonedRoastingButton);
        }
    }

    void checkRoastingButtonPos(Vector3 nowPos)
    {
        //is in green
        if(clonedRoastingButton.transform.position.x >= -3.001f
            && clonedRoastingButton.transform.position.x <= -1.01f)
        {
            if (!toDestroy.Contains(clonedWarning))
            {
                clonedWarning = Instantiate(warning, new Vector3(0, -2.91f, 0), Quaternion.identity);
                toDestroy.Add(clonedWarning);
                Destroy(clonedWarning, 1f);
                Invoke("removeWarning", 1f);
            }
            clonedRoastingButton.transform.position = roastingButtonStartingPos;

            Invoke("moveButtonAgain", 0.8f);
        }
        //is in yellow
        if (clonedRoastingButton.transform.position.x >= -1.01f
            && clonedRoastingButton.transform.position.x <= 0.93)
        {
            stopRoastingButton = true;

            audioSource.clip = ovenDoneSound;
            audioSource.loop = false;
            audioSource.Play();

            CancelInvoke();

            Invoke("showPerfect", 1f);
            Invoke("showWhippingBack", 2f);
        }
        //is in red
        else if(clonedRoastingButton.transform.position.x >= 0.93f
            && clonedRoastingButton.transform.position.x <= 2.76f)
        {
            if(!toDestroy.Contains(clonedWarning))
            {
                clonedWarning = Instantiate(warning, new Vector3(5.38f, -1.89f, 0), Quaternion.identity);
                toDestroy.Add(clonedWarning);
                Destroy(clonedWarning, 1f);
                Invoke("removeWarning", 1f);
            }

            Invoke("moveButtonAgain", 0.8f);
        }
        else if (clonedRoastingButton.transform.position.x > 2.77f)
        {
            clonedRoastingButton.transform.position = roastingButtonStartingPos;
            stopRoastingButton = false;
        }
    }

    void removeWarning()
    {
        toDestroy.Remove(clonedWarning);
    }

    void moveButtonAgain()
    {
        stopRoastingButton = false;
    }

    GameObject chooseFilledTray()
    {
        if (menuList[0] == 1 && menuList[1] == 0)
            return pinkChocoTray;
        else if (menuList[0] == 2 && menuList[1] == 0)
            return vanillaChocoTray;
        else if (menuList[0] == 2 && menuList[1] == 1)
            return vanillaPinkTray;
        else
            return null;
    }

    void showWhippingBack()
    {
        isBaking = false;
        isWhipping = true;

        int temp = toDestroy.Count;
        for(int i=0; i<temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        backRenderer.sprite = backGrounds[2];

        if(!toDestroy.Contains(clonedGreyMuffinTray))
        {
            clonedGreyMuffinTray = Instantiate(greyMuffinTray, new Vector3(-0.06f, -2.17f, 0), Quaternion.identity);
            toDestroy.Add(clonedGreyMuffinTray);
        }

        if(!toDestroy.Contains(clonedLeftBread))
        {
            if(menuList[1] == 1) //flavor is pink
            {
                Debug.Log("menulist 2 == 1");
                clonedLeftBread = Instantiate(chooseMuffinBread(menuList[1]), new Vector3(-2.01f, 0.05f, 0), Quaternion.identity);
                toDestroy.Add(clonedLeftBread);
            }
            else
            {
                clonedLeftBread = Instantiate(chooseMuffinBread(menuList[1]), new Vector3(-2.01f, -0.48f, 0), Quaternion.identity);
                toDestroy.Add(clonedLeftBread);
            }
        }

        if(!toDestroy.Contains(clonedRightBread))
        {
            clonedRightBread = Instantiate(chooseMuffinBread(menuList[0]), new Vector3(1.89f, -0.03f, 0), Quaternion.identity);
            toDestroy.Add(clonedRightBread);
        }

        Invoke("delayPipingBag", 1f);
    }

    GameObject chooseMuffinBread(int flavor)
    {
        if (flavor == 0)
        {
            return chocoMuffinBread;
        }
        else if (flavor == 1)
        {
            return redMuffinBread;
        }
        else if (flavor == 2)
        {
            return vanillaMuffinBread;
        }
        else
            return null;
    }

    void delayPipingBag()
    {
        if(!toDestroy.Contains(clonedPipingBag))
        {
            clonedPipingBag = Instantiate(pipingBag, new Vector3(6.25f, 1.14f, 0), Quaternion.identity);
            clonedPipingBag.transform.localScale = new Vector3(1, 1, 0);

            SpriteRenderer sr = null;
            sr = clonedPipingBag.GetComponent<SpriteRenderer>();
            sr.sortingOrder = 6;

            toDestroy.Add(clonedPipingBag);
        }
    }

    void BreadWhipping()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if(Input.GetMouseButton(0))
        {
            if(rayHit.collider != null)
            {
                if (rayHit.collider.gameObject.tag.Equals("pipingBag"))
                {
                    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                    clonedPipingBag.transform.position = objPosition;

                    //left muffin
                    if (objPosition.x >= -1.44f && objPosition.x <= 0.76f
                        && objPosition.y >= 2f && objPosition.y <= 4f)
                    {
                        if (!toDestroy.Contains(clonedLeftCream))
                        {
                            clonedLeftCream = Instantiate(chooseSharpCream(menuList[5]), new Vector3(-2.17f, 1.74f, 0),
                                Quaternion.identity);
                            toDestroy.Add(clonedLeftCream);
                            checkMuffinWhipping[0] = true;

                            audioSource.clip = squishingSound;
                            audioSource.loop = false;
                            audioSource.Play();

                            StartCoroutine(FadeInLeftCream());
                        }
                    }
                    if (objPosition.x >= 2.54f && objPosition.x <= 4.69f
                        && objPosition.y >= 2f && objPosition.y <= 4f)
                    {
                        if (!toDestroy.Contains(clonedRightCream))
                        {
                            clonedRightCream = Instantiate(chooseSharpCream(menuList[4]), new Vector3(1.78f, 1.78f, 0),
                                Quaternion.identity);
                            toDestroy.Add(clonedRightCream);
                            checkMuffinWhipping[1] = true;

                            audioSource.clip = squishingSound;
                            audioSource.loop = false;
                            audioSource.Play();

                            StartCoroutine(FadeInRightCream());
                        }
                    }
                }
            }
        }

        if(checkWhippingDone())
        {
            Invoke("showMiniGameTitle", 5f);

            for (int i = 0; i < checkMuffinWhipping.Length; i++)
                checkMuffinWhipping[i] = false;
        }
    }

    IEnumerator FadeInLeftCream()
    {
        float elapsedTime = 0f;
        SpriteRenderer lcreamSR;
        Color lcreamColor;
        float fadeDuration = 2f;

        lcreamSR = clonedLeftCream.GetComponent<SpriteRenderer>();
        lcreamColor = lcreamSR.color;
        lcreamSR.color = new Color(lcreamColor.r, lcreamColor.g, lcreamColor.b, 0);

        while(elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            lcreamSR.color = new Color(lcreamColor.r, lcreamColor.g, lcreamColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        lcreamSR.color = lcreamColor;
        audioSource.Stop();
    }

    IEnumerator FadeInRightCream()
    {
        float elapsedTime = 0f;
        SpriteRenderer rcreamSR;
        Color rcreamColor;
        float fadeDuration = 2f;

        rcreamSR = clonedRightCream.GetComponent<SpriteRenderer>();
        rcreamColor = rcreamSR.color;
        rcreamSR.color = new Color(rcreamColor.r, rcreamColor.g, rcreamColor.b, 0);

        while(elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            rcreamSR.color = new Color(rcreamColor.r, rcreamColor.g, rcreamColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rcreamSR.color = rcreamColor;
        audioSource.Stop();
    }

    GameObject chooseSharpCream(int flavor)
    {
        if (flavor == 0)
        {
            return whiteSharpCream;
        }
        else if (flavor == 1)
        {
            return cheeseSharpCream;
        }
        else if (flavor == 2)
        {
            return chocoSharpCream;
        }
        else
            return null;
    }

    bool checkWhippingDone()
    {
        for(int i=0; i<checkMuffinWhipping.Length; i++)
        {
            if (checkMuffinWhipping[i] == false)
                return false;
        }
        return true;
    }

    void showMiniGameTitle()
    {
        if(!toDestroy.Contains(clonedMiniGameTitle))
        {
            clonedMiniGameTitle = Instantiate(miniGameTitle, new Vector3(0, 0, 0), Quaternion.identity);
            toDestroy.Add(clonedMiniGameTitle);

            AudioSource minigameTitleAudio;
            minigameTitleAudio = clonedMiniGameTitle.GetComponent<AudioSource>();
            minigameTitleAudio.Play();
            minigameTitleAudio.loop = false;
        }

        Invoke("showMiniGameBack", 1f);
    }

    void showMiniGameBack()
    {
        isWhipping = false;
        isMiniGame = true;

        int temp = toDestroy.Count;
        for(int i=0; i<temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        backRenderer.sprite = backGrounds[3];
        
        //if(!toDestroy.Contains(clonedMiniGameDirection))
        //{
        //    clonedMiniGameDirection = Instantiate(miniGameDirection, new Vector3(0, 0, 0), Quaternion.identity);
        //    toDestroy.Add(clonedMiniGameDirection);
        //}
        //Destroy(clonedMiniGameDirection, 3f);

        minigameDirectionText.text = chooseMinigameDirection();
        GameObject Direction = minigameDirectionText.gameObject;
        Direction.SetActive(true);

        //minigame�����
        audioSource.clip = miniGameBackSound;
        audioSource.loop = true;
        audioSource.Play();

        //stage ����� ���̱�
        audioMan.volume = 0f;

        Invoke("removeDirection", 3f);

        //Invoke("showChocoCupCake", 4f);
        Invoke("showMinigameCupcake", 4f);
    }

    void removeDirection()
    {
        GameObject Direction = minigameDirectionText.gameObject;
        Direction.SetActive(false);
    }

    string chooseMinigameDirection()
    {
        if (menuList[1] == 0 && menuList[3] == 0) //choco + milk + cherry
        {
            string orderNum1Direction = "Of the toppings that fall from the top,\n " +
                "you have to put the cherry on top of the cupcake!";
            //minigameDirectionText.text = orderNum1Direction;
            return orderNum1Direction;
        }
        else if (menuList[1] == 0 && menuList[3] == 1) //choco + milk + oreo
        {
            string orderNum2Direction = "Of the toppings that fall from the top,\n " +
                "you have to put the oreo on top of the cupcake!";
            return orderNum2Direction;
        }
        else if (menuList[1] == 1 && menuList[3] == 0) //pink + cheese + cherry
        {
            string orderNum3Direction = "Of the toppings that fall from the top,\n" +
                "you have to put the cherry on top of the cupcake!";
            return orderNum3Direction;
        }
        else
            return null;
    }

    GameObject chooseFinishCupcake()
    {
        if (menuList[1] == 0 && menuList[3] == 0) //choco + milk + cherry
        {
            return chocoCherryMuffin;
        }
        else if (menuList[1] == 0 && menuList[3] == 1) //choco + milk + oreo
        {
            return chocoOreoMuffin;
        }
        else if (menuList[1] == 1 && menuList[3] == 0)//pink + cheese + cherry
        {
            return pinkCherryMuffin;
        }
        else
            return null;
    }

    GameObject chooseMiniGameMuffin()
    {
        if (menuList[1] == 0 && menuList[5] == 0) //choco + milk
        {
            return chocoMilkMuffin;
        }
        else if (menuList[1] == 1 && menuList[5] == 1) //pink + cheese
        {
            return pinkCheeseMuffin;
        }
        else
            return null;
    }

    void showMinigameCupcake()
    {
        if(!toDestroy.Contains(clonedCupcake))
        {
            clonedCupcake = Instantiate(chooseMiniGameMuffin(), new Vector3(-5.27f, -2.48f, 0), Quaternion.identity);
            toDestroy.Add(clonedCupcake);
        }
    }

    void miniGame()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if (toDestroy.Contains(clonedCupcake))
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                objPos = Camera.main.ScreenToWorldPoint(mousePosition);
                objPos.y = clonedCupcake.transform.position.y;
            }
            clonedCupcake.transform.position = Vector2.Lerp(clonedCupcake.transform.position, objPos, Time.deltaTime * 2f);
        }

        //Debug.Log("clear minigame" + clearMiniGame);

        if (clearMiniGame)
        {
            if(!toDestroy.Contains(clonedFinishedCupcake))
            {
                //Destroy(clonedFirstMuffin);
                Destroy(clonedCupcake);
                clonedFinishedCupcake = Instantiate(chooseFinishCupcake(), nowPos, Quaternion.identity);

                SpriteRenderer sr = null;
                sr = clonedFinishedCupcake.GetComponent<SpriteRenderer>();
                sr.sortingOrder = 1;

                toDestroy.Add(clonedFinishedCupcake);

                clearMiniGame = false;

                Invoke("showPerfect", 1f);
                Invoke("showMixerBack", 2f);
            }
        }
    }

    void showMixerBack()
    {
        isMiniGame = false;
        isMixer = true;

        audioSource.clip = null;
        //audioMan.volume = 1f;

        int temp = toDestroy.Count;
        for(int i=0; i<temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        //audioSource.clip = null;
        audioSource.volume = 0f;
        audioMan.volume = 1f;

        backRenderer.sprite = backGrounds[4];

        if(!toDestroy.Contains(clonedMilk))
        {
            clonedMilk = Instantiate(milk, new Vector3(-8.26f, -1.43f, 0), Quaternion.identity);
            clonedMilk.transform.localScale = new Vector3(3.497254f, 2.942825f, 1);
            toDestroy.Add(clonedMilk);
        }

        if(!toDestroy.Contains(clonedIceBox))
        {
            clonedIceBox = Instantiate(iceBox, new Vector3(-5.48f, -0.71f, 0), Quaternion.identity);
            toDestroy.Add(clonedIceBox);
        }

        if(!toDestroy.Contains(clonedYogurt))
        {
            clonedYogurt = Instantiate(yogurt, new Vector3(6.79f, -0.99f, 0), Quaternion.identity);
            toDestroy.Add(clonedYogurt);
        }

        if(!toDestroy.Contains(clonedCup))
        {
            GameObject beverageCup = chooseBeverageCup<GameObject>();
            clonedCup = Instantiate(beverageCup, new Vector3(5.13f, -3.34f, 0), Quaternion.identity);
            toDestroy.Add(clonedCup);
        }

        if(!toDestroy.Contains(clonedEmptyMixer))
        {
            clonedEmptyMixer = Instantiate(emptyMixer, new Vector3(0, -1.27f, 0), Quaternion.identity);
            toDestroy.Add(clonedEmptyMixer);
        }

        if(!toDestroy.Contains(clonedMixerButton))
        {
            clonedMixerButton = Instantiate(mixerButton, new Vector3(0.06f, -2.81f, 0), Quaternion.identity);
            toDestroy.Add(clonedMixerButton);
        }
    }

    T chooseBeverageCup<T>()
    {
        if(menuList[6]==0) //bev -> strawberry
        {
            if (typeof(T) == typeof(GameObject))
                return (T)(object)strawberryCup;
            else if (typeof(T) == typeof(string))
                return (T)(object)"strawberryCup";
        }
        else if(menuList[6]==1) //bev -> oreo
        {
            if (typeof(T) == typeof(GameObject))
                return (T)(object)oreoCup;
            else if (typeof(T) == typeof(string))
                return (T)(object)"bananaCup";
        }
        else if(menuList[6]==2) //bev -> vanilla
        {
            if (typeof(T) == typeof(GameObject))
                return (T)(object)vanillaCup;
            else if (typeof(T) == typeof(string))
                return (T)(object)"blueberryCup";
        }

        return default(T);
    }

    void MixerOn()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if(Input.GetMouseButtonDown(0))
        {
            if(rayHit.collider != null)
            {
                if(rayHit.collider.gameObject.tag.Equals("milk"))
                {
                    if(!toDestroy.Contains(clonedFilledMilkForMixer))
                    {
                        clonedFilledMilkForMixer = Instantiate(filledMilkForMixer,
                            new Vector3(-0.0148f, -0.1353f, 0), Quaternion.identity);
                        toDestroy.Add(clonedFilledMilkForMixer);

                        clonedMilkButton = Instantiate(milkButton, new Vector3(2.76f, -1.27f, 0), Quaternion.identity);
                        Destroy(clonedMilkButton, 1f);

                        checkMixerIngredients[0] = true;
                    }
                }

                if(rayHit.collider.gameObject.tag.Equals("iceBox"))
                {
                    if(!toDestroy.Contains(clonedIce))
                    {
                        clonedIce = Instantiate(ice, new Vector3(0.01f, 2.83f, 0), Quaternion.identity);
                        toDestroy.Add(clonedIce);

                        clonedIceButton = Instantiate(iceButton, new Vector3(2.76f, -1.27f, 0), Quaternion.identity);
                        Destroy(clonedIceButton, 1f);

                        checkMixerIngredients[1] = true;
                    }
                }

                string beverageTag = chooseBeverageCup<string>();
                if(rayHit.collider.gameObject.tag.Equals(beverageTag))
                {
                    if(!toDestroy.Contains(clonedCorrectBundle))
                    {
                        clonedCorrectBundle = Instantiate(chooseCorrectBundle(), new Vector3(-0.01f, 2.13f, 0), Quaternion.identity);
                        clonedCorrectBundle.transform.localEulerAngles = new Vector3(0, 0, 90f);
                        toDestroy.Add(clonedCorrectBundle);

                        clonedButton = Instantiate(chooseCorrectButton(), new Vector3(2.76f, -1.27f, 0), Quaternion.identity);
                        Destroy(clonedButton, 1f);

                        checkMixerIngredients[2] = true;
                    }
                }

                if(rayHit.collider.gameObject.tag.Equals("yogurt"))
                {
                    if(!toDestroy.Contains(clonedFilledYogurt))
                    {
                        clonedFilledYogurt = Instantiate(filledYogurt, new Vector3(-0.08f, 3.07f, 0), Quaternion.identity);
                        clonedFilledYogurt.transform.localScale = new Vector3(0.13f, 0.16f, 0);
                        toDestroy.Add(clonedFilledYogurt);

                        clonedYogurtButton = Instantiate(yogurtButton, new Vector3(2.76f, -1.27f, 0), Quaternion.identity);
                        Destroy(clonedYogurtButton, 1f);

                        checkMixerIngredients[3] = true;
                    }
                }

                if(canMixThings)
                {
                    CancelInvoke("showMixerLid");

                    if (rayHit.collider.gameObject.tag.Equals("bell"))
                    {
                        Destroy(clonedEmptyMixer);
                        toDestroy.Remove(clonedEmptyMixer);

                        Destroy(clonedFilledYogurt);
                        toDestroy.Remove(clonedFilledYogurt);

                        Destroy(clonedFilledMilkForMixer);
                        toDestroy.Remove(clonedFilledMilkForMixer);

                        Destroy(clonedIce);
                        toDestroy.Remove(clonedIce);

                        Destroy(clonedCorrectBundle);
                        toDestroy.Remove(clonedCorrectBundle);

                        Destroy(clonedMixerLid);
                        //toDestroy.Remove(clonedMixerLid);

                        Destroy(clonedMixerButton);
                        toDestroy.Remove(clonedMixerButton);

                        if (!toDestroy.Contains(clonedFullMixer))
                        {
                            clonedFullMixer = Instantiate(chooseCorrectMoveMixer(),
                                new Vector3(0, -0.24f, 0), Quaternion.identity);
                            toDestroy.Add(clonedFullMixer);
                            changeMixer = true;
                            correctMixerAnim = clonedFullMixer.GetComponent<Animator>();
                            correctMixerAnim.enabled = true;

                            //canMixThings = false;
                        }
                    }
                }

                if(changeMixer)
                {
                    changeMixer = false;
                    if(!toDestroy.Contains(clonedCompleteMixer))
                    {
                        Invoke("showCompleteMixer", 2f);
                        Invoke("showPerfect", 2.5f);
                        Invoke("showDrinkBack", 3.5f);
                    }
                }
            }
        }

        if(checkMixerIngredients[1]) //move ice
        {
            if(toDestroy.Contains(clonedIce))
            {
                clonedIce.transform.position = Vector3.MoveTowards(clonedIce.transform.position,
                    new Vector3(0.01f, 0.18f, 0), 2 * Time.deltaTime);
            }

        }

        if(checkMixerIngredients[2]) //fruit bundle
        {
            if(toDestroy.Contains(clonedCorrectBundle))
            {
                clonedCorrectBundle.transform.position = Vector3.MoveTowards(clonedCorrectBundle.transform.position,
                new Vector3(-0.01f, 0.24f, 0), 2 * Time.deltaTime);
            }
        }

        if(checkMixerIngredients[3]) //move yogurt
        {
            if(toDestroy.Contains(clonedFilledYogurt))
            {
                clonedFilledYogurt.transform.position = Vector3.MoveTowards(clonedFilledYogurt.transform.position,
                new Vector3(0.13f, 1.31f, 0), 2 * Time.deltaTime);
            }
        }

        if(checkMixerReady()) //check mixer ingredients ready
        {
            Invoke("checkMixerReady", 1f);

            if(!toDestroy.Contains(clonedMixerLid))
            {
                Invoke("showMixerLid", 0.5f);

                canMixThings = true;
            }
        }
    }

    GameObject chooseCorrectBundle()
    {
        if (menuList[6] == 0)
            return strawberryBundle;
        else if (menuList[6] == 1)
            return oreoBundle;
        else if (menuList[6] == 2)
            return vanillaBundle;
        else
            return null;
    }

    GameObject chooseCorrectButton()
    {
        if (menuList[6] == 0)
            return strawberryButton;
        else if (menuList[6] == 1)
            return oreoButton;
        else if (menuList[6] == 2)
            return vanillaButton;
        else
            return null;
    }

    GameObject chooseCorrectMoveMixer()
    {
        if (menuList[6] == 0)
            return strawberryMixer;
        else if (menuList[6] == 1)
            return oreoMixer;
        else if (menuList[6] == 2)
            return vanillaMixer;
        else
            return null;
    }

    GameObject chooseCompleteMixer()
    {

        if (menuList[6] == 0)
            return completeStrawberryMixer;
        else if (menuList[6] == 1)
            return completeOreoMixer;
        else if (menuList[6] == 2)
            return completeVanillaMixer;
        else
            return null;
    }

    void showCompleteMixer()
    {

        Destroy(clonedFullMixer);
        clonedCompleteMixer = Instantiate(chooseCompleteMixer(), new Vector3(0, -0.24f, 0), Quaternion.identity);
        toDestroy.Add(clonedCompleteMixer);
    }

    bool checkMixerReady()
    {
        for(int i=0; i<checkMixerIngredients.Length; i++)
        {
            if (checkMixerIngredients[i] == false)
                return false;
        }
        return true;
    }

    void delayMixer()
    {
        for (int i = 0; i < checkMixerIngredients.Length; i++)
            checkMixerIngredients[i] = false;
    }

    void showMixerLid()
    {
        clonedMixerLid = Instantiate(mixerLid, new Vector3(-0.02f, 2.66f, 0), Quaternion.identity);
        toDestroy.Add(clonedMixerLid);
        CancelInvoke("showMixerLid");
    }

    void showDrinkBack()
    {
        isMixer = false;
        isDrink = true;

        int temp = toDestroy.Count;
        for(int i=0; i<temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        backRenderer.sprite = backGrounds[5];

        if(!toDestroy.Contains(clonedDrinkCup))
        {
            clonedDrinkCup = Instantiate(chooseDrinkCup(), new Vector3(0.67f, -0.29f, 0), Quaternion.identity);
            toDestroy.Add(clonedDrinkCup);
        }

        Invoke("showWhipping", 0.5f);
    }

    GameObject chooseDrinkCup()
    {
        if (menuList[6] == 0) //bev -> strawberry
            return pinkCup;
        else if (menuList[6] == 1) //bev -> oreo
            return brownCup;
        else if (menuList[6] == 2) //bev -> vanilla
            return yelloCup;
        else
            return null;
    }

    void showWhipping()
    {
        if(!toDestroy.Contains(clonedWhipping))
        {
            clonedWhipping = Instantiate(whipping, new Vector3(5.82f, 1.29f, 0), Quaternion.identity);
            toDestroy.Add(clonedWhipping);
        }
    }

    void decoDrink()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
        Ray2D ray = new Ray2D(touchPos, Vector2.zero);
        RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

        if (Input.GetMouseButton(0))
        {
            if(rayHit.collider != null)
            {
                if (rayHit.collider.gameObject.tag.Equals("whipping"))
                {
                    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                    clonedWhipping.transform.position = objPosition;

                    if (objPosition.x >= 0.31f && objPosition.x <= 3.79f
                        && objPosition.y <= 0.12f && objPosition.y >= -4.31f)
                    {
                        if (!toDestroy.Contains(clonedWhiteCream))
                        {
                            clonedWhiteCream = Instantiate(whiteCream, new Vector3(0.05f, -0.31f, 0), Quaternion.identity);
                            toDestroy.Add(clonedWhiteCream);

                            whippingRenderer = clonedWhiteCream.GetComponent<SpriteRenderer>();
                            originalColor = whippingRenderer.color;
                            whippingRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0);

                            StartCoroutine(FadeInRoutine());

                            Invoke("showChocoSyrup", 2.5f);
                        }
                    }
                }
            }
            if (rayHit.collider.gameObject.tag.Equals("flour"))
            {
                isSyrupDragging = true;

                syrupPoints.Clear();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isSyrupDragging = false;

            //lr.loop = true;

            if (checkLineRendererPoints()) //����� �÷�����
            {
                Debug.Log("�׷ȴ�!");
                Invoke("showChocoLine", 0.5f);

                Invoke("showPerfect", 3.5f);

                Invoke("showDeliverBack", 5.5f);
            }
            else if (!checkLineRendererPoints()) //�ƴ� ��
            {

                if (!toDestroy.Contains(clonedTryAgain))
                {
                    Debug.Log("���׷ȴ�!");

                    clonedTryAgain = Instantiate(tryAgain, new Vector3(2.4f, 0.14f, 0), Quaternion.identity);
                    clonedTryAgain.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                    toDestroy.Add(clonedTryAgain);

                    Invoke("hideTryAgain", 1.5f);
                }
            }
        }

        if(isSyrupDragging)
        {
            Vector3 dragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragPosition.z = 0f;
            clonedChocoSyrup.transform.position = dragPosition;

            if(dragPosition.x >= -3.35f && dragPosition.x <= 1.22f
                && dragPosition.y <= -0.1f && dragPosition.y >= -4.58f)
            {
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pos.x += 0.84f;
                pos.y += 2.09f;

                if (syrupPoints.Count == 0)
                {
                    if (!toDestroy.Contains(clonedLinePrefab))
                    {
                        clonedLinePrefab = Instantiate(linePrefab, clonedChocoSyrup.transform.position,
                            Quaternion.identity);
                        toDestroy.Add(clonedLinePrefab);
                    }

                    lr = clonedLinePrefab.GetComponent<LineRenderer>();
                    lineCol = clonedLinePrefab.GetComponent<EdgeCollider2D>();
                    lr.useWorldSpace = true;
                    lr.sortingOrder = 5;

                    syrupPoints.Add(pos);
                    lr.positionCount++;
                    lr.SetPosition(lr.positionCount - 1, pos);
                    lineCol.points = syrupPoints.ToArray();

                    Vector3 temp = new Vector3(Mathf.Round(pos.x * 100) / 100, Mathf.Round(pos.y * 100) / 100, 0);
                    drawnPositions.Add(temp);
                }
                else
                {
                    syrupPoints.Add(pos);
                    lr.positionCount++;
                    lr.sortingOrder = 4;
                    lr.SetPosition(lr.positionCount - 1, pos);
                    lineCol.points = syrupPoints.ToArray();

                    Vector3 temp = new Vector3(Mathf.Round(pos.x * 100) / 100, Mathf.Round(pos.y * 100) / 100, 0);
                    drawnPositions.Add(temp);
                }
            }
        }
    }

    void showChocoLine()
    {
        if(!toDestroy.Contains(clonedChocoLine))
        {
            Destroy(clonedLinePrefab);
            Destroy(clonedDottedLine);

            clonedChocoLine = Instantiate(chocoLine, new Vector3(-0.12f, -0.23f, 0), Quaternion.identity);
            toDestroy.Add(clonedChocoLine);
        }
    }

    void hideTryAgain()
    {
        toDestroy.Remove(clonedTryAgain);
        Destroy(clonedTryAgain);
        Destroy(clonedLinePrefab);

        syrupPoints.Clear();
        toDestroy.Remove(clonedLinePrefab);
    }

    bool checkLineRendererPoints()
    {
        Vector3[] points = new Vector3[drawnPositions.Count];

        for(int i=0; i<drawnPositions.Count; i++)
        {
            points[i] = drawnPositions[i];
        }

        Bounds bounds = GetBounds(points);
        Collider2D[] overlaps = Physics2D.OverlapAreaAll(bounds.min, bounds.max);
        Collider2D dottedLineCol = clonedDottedLine.GetComponent<Collider2D>();

        float overlapPercentage = 0f;
        foreach(Collider2D overlap in overlaps)
        {
            if(overlap.gameObject.CompareTag("dottedLine"))
            {
                overlapPercentage = CalculateOverlapPercentage(lr, overlap);
                break;
            }
        }

        if(overlapPercentage > 0.8f)
        {
            Debug.Log("shape overlaps with line");
            return true;
        }
        else
        {
            Debug.Log("shape doesn't overlaps with line");
            return false;
        }
    }

    Bounds GetBounds(Vector3[] points)
    {
        float minX = float.MaxValue;
        float minY = float.MaxValue;
        float maxX = float.MinValue;
        float maxY = float.MinValue;

        foreach(Vector3 point in points)
        {
            if (point.x < minX) minX = point.x;
            if (point.y < minY) minY = point.y;
            if (point.x < maxX) maxX = point.x;
            if (point.y < maxY) maxY = point.y;
        }

        return new Bounds(new Vector3((minX + maxX) / 2, (minY + maxY) / 2, 0),
            new Vector3(maxX - minX, maxY - minY, 1));
    }

    Bounds CalculateBounds(LineRenderer lineRenderer)
    {
        Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

        for (int i = 0; i < lineRenderer.positionCount; i++)
        {
            Vector3 point = lineRenderer.GetPosition(i);
            min = Vector3.Min(min, point);
            max = Vector3.Max(max, point);
        }

        Vector3 center = (min + max) / 2f;
        Vector3 size = max - min;

        return new Bounds(center, size);
    }

    float CalculateOverlapPercentage(LineRenderer lr, Collider2D syrupCollider)
    {
        Bounds lineBounds = CalculateBounds(lr);
        Bounds heartBounds = syrupCollider.bounds;

        if (!lineBounds.Intersects(heartBounds))
        {
            return 0f;
        }

        Bounds overlap = lineBounds;
        overlap.Intersects(heartBounds);

        float overlapArea = OverlapArea(overlap, heartBounds);
        float heartArea = heartBounds.size.x * heartBounds.size.y;

        float overlapPercentage = overlapArea / heartArea;

        return overlapPercentage;
    }

    float OverlapArea(Bounds bounds1, Bounds bounds2)
    {
        float xMin = Mathf.Max(bounds1.min.x, bounds2.min.x);
        float yMin = Mathf.Max(bounds1.min.y, bounds2.min.y);
        float xMax = Mathf.Min(bounds1.max.x, bounds2.max.x);
        float yMax = Mathf.Min(bounds1.max.y, bounds2.max.y);

        if (xMax > xMin && yMax > yMin)
        {
            return (xMax - xMin) * (yMax - yMin);
        }

        return 0f;
    }

    IEnumerator FadeInRoutine()
    {
        float elapsedTime = 0f;
        while(elapsedTime<fadeTime)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeTime);
            whippingRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        whippingRenderer.color = originalColor;
    }

    IEnumerator BlinkCoroutine()
    {
        Debug.Log("�� ȣ�� �Ǵ�");

        float StartTime = Time.time;

        while(Time.time - StartTime < blinkDuration)
        {
            clonedDottedLine.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            clonedDottedLine.SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }
    }

    void showChocoSyrup()
    {
        if(!toDestroy.Contains(clonedChocoSyrup))
        {
            clonedChocoSyrup = Instantiate(chocoSyrup, new Vector3(-6.22f, 0.24f, 0), Quaternion.identity);
            toDestroy.Add(clonedChocoSyrup);
        }

        Invoke("showDottedLine", 1f);
    }

    void showDottedLine()
    {
        if(!toDestroy.Contains(dottedLine))
        {
            clonedDottedLine = Instantiate(dottedLine, new Vector3(0.11f, -0.26f, 0), Quaternion.identity);
            toDestroy.Add(clonedDottedLine);

            StartCoroutine(BlinkCoroutine());
        }
    }

    void showDeliverBack()
    {
        isDrink = false;
        isFinishBack = true;

        int temp = toDestroy.Count;
        for(int i=0; i<temp; i++)
        {
            Destroy(toDestroy[0]);
            toDestroy.RemoveAt(0);
        }

        backRenderer.sprite = backGrounds[6];

        if(!toDestroy.Contains(clonedBell))
        {
            clonedBell = Instantiate(bell, new Vector3(-5.63f, 2.17f, 0), Quaternion.identity);
            toDestroy.Add(clonedBell);
        }

        Invoke("showCompleteMuffins", 1f);
    }

    void showCompleteMuffins()
    {
        if(!toDestroy.Contains(clonedCompleteMuffin))
        {
            clonedCompleteMuffin = Instantiate(chooseCompleteMuffins(), new Vector3(-0.25f, -5.28f, 0), Quaternion.identity);
            toDestroy.Add(clonedCompleteMuffin);
        }

        if (!toDestroy.Contains(clonedBev))
        {
            clonedBev = Instantiate(chooseBev(), new Vector3(5.85f, -5.54f, 0), Quaternion.identity);
            toDestroy.Add(clonedBev);
        }

        readyToMoveDish = true;
    }

    GameObject chooseCompleteMuffins()
    {
        if (menuList[0] == 1 && menuList[1] == 0)
            return firstCompleteMuffin;
        else if (menuList[0] == 2 && menuList[1] == 0)
            return secondCompleteMuffin;
        else if (menuList[0] == 2 && menuList[1] == 1)
            return thirdCompleteMuffin;
        else
            return null;
    }

    GameObject chooseBev()
    {
        if (menuList[6] == 0)
            return firstBev;
        else if (menuList[6] == 1)
            return secondBev;
        else if (menuList[6] == 2)
            return thirdBev;
        else
            return null;
    }

    void deliver()
    {
        if(readyToMoveDish) //ready to move
        {
            clonedCompleteMuffin.transform.position
                = Vector3.MoveTowards(clonedCompleteMuffin.transform.position,
                new Vector3(-0.25f, 0.17f, 0), 3 * Time.deltaTime);

            clonedBev.transform.position
                = Vector3.MoveTowards(clonedBev.transform.position,
                new Vector3(5.85f, 0.36f, 0), 3 * Time.deltaTime);

            canFinish = true;
        }

        if(canFinish)
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
            Ray2D ray = new Ray2D(touchPos, Vector2.zero);
            RaycastHit2D rayHit = Physics2D.Raycast(ray.origin, ray.direction);

            if(Input.GetMouseButtonDown(0))
            {
                if(rayHit.collider != null)
                {
                    if(rayHit.collider.gameObject.tag.Equals("bell"))
                    {
                        Invoke("showComplete", 1f);

                        audioSource.clip = bellSound;
                        audioSource.volume = 1f;
                        audioSource.Play();
                        audioSource.loop = false;
                    }
                }
            }
        }
    }
    //void showComplete()
    //{
    //    if(!toDestroy.Contains(clonedComplete))
    //    {
    //        clonedComplete = Instantiate(complete, new Vector3(0, 0, 0), Quaternion.identity);
    //        toDestroy.Add(clonedComplete);
    //    }

    //    GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum++;
    //    if (GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum == 3)
    //    {
    //        if (GameObject.Find("GameSetting").GetComponent<GameNum>().StageNum == 2)
    //        {
    //            Invoke("LoadEndingScene", 1f);
    //        }
    //        GameObject.Find("GameSetting").GetComponent<GameNum>().StageNum++;
    //        GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum = 0;
    //    }
    //    Invoke("LoadStage1Scene", 1f);
    //}

    void showComplete()
    {
        if (!toDestroy.Contains(clonedComplete))
        {
            clonedComplete = Instantiate(complete, new Vector3(0, 0, 0), Quaternion.identity);
            toDestroy.Add(clonedComplete);
        }

        GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum++;


        if (GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum == 3)
        {

            if (GameObject.Find("GameSetting").GetComponent<GameNum>().StageNum == 2)
            {

                setScore(PlayerPrefs.GetFloat("Money"));

                Debug.Log("Ending");
                Invoke("LoadEndingScene", 1f);
            }
            //GameObject.Find("GameSetting").GetComponent<GameNum>().StageNum++;
            //GameObject.Find("GameSetting").GetComponent<GameNum>().OrderNum = 0;
        }
        else
        {
            Invoke("LoadStage1Scene", 1f);

        }
    }

    void LoadStage1Scene()
    {
        SceneManager.LoadScene("Stage1");
    }
    void LoadEndingScene()
    {
        SceneManager.LoadScene("Ending");
    }

    void setScore(float currentScore)
    {
        PlayerPrefs.SetFloat("CurrentPlayerScore", currentScore);

        float tmpScore = 0f;
        for (int i = 0; i < 5; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");

            while (bestScore[i] < currentScore)
            {
                tmpScore = bestScore[i];
                bestScore[i] = currentScore;

                PlayerPrefs.SetFloat(i + "BestScore", currentScore);

                currentScore = tmpScore;
            }
        }
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
        }
    }
}