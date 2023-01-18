using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Material {
    public string Name;
    public float Price;
}

public class menu : MonoBehaviour
{
    //Material material = new Material();
    public Material[] Topping = new Material[3];
    public Material[] Flavor = new Material[3];
    public Material[] AddShotCream = new Material[3];
    public Material[] Beverage = new Material[6];

    // Start is called before the first frame update
    void OnEnable()
    {
        initializeMaterial(Topping, 0, "Banana", 1);
        initializeMaterial(Topping, 1, "Blueberry", 1.5f);
        initializeMaterial(Topping, 2, "Strawberry", 2);

        initializeMaterial(Flavor, 0, "Strawberry", 7);
        initializeMaterial(Flavor, 1, "Banana", 7);
        initializeMaterial(Flavor, 2, "Chocolate", 7);

        initializeMaterial(AddShotCream, 0, "Shot", 0.5f);
        initializeMaterial(AddShotCream, 1, "Milk Cream", 0.3f);
        initializeMaterial(AddShotCream, 2, "Strawberry Cream", 0.3f);

        initializeMaterial(Beverage, 0, "Milk", 2);
        initializeMaterial(Beverage, 1, "Banana Milk", 2);
        initializeMaterial(Beverage, 2, "Coke", 0.5f);
        initializeMaterial(Beverage, 3, "Hot Espresso", 3);
        initializeMaterial(Beverage, 4, "Cocoa", 3.5f);
        initializeMaterial(Beverage, 5, "S Cafe Latte", 4);
    }

    void initializeMaterial( Material[] materials, int index, string Name, float Price)
    {
        materials[index].Name = Name;
        materials[index].Price = Price;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
