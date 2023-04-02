using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityVariables : MonoBehaviour
{
    
    //resources at the start of the game
    [SerializeField]
    private int Money = 10;
    [SerializeField]
    private int Food = 10;
    [SerializeField]
    private int Metal = 10;
    [SerializeField]
    private int Science = 10;
    [SerializeField]
    private int Electricity = 10;

    //bonuses to production. changed later with upgrades but some have natural bonuses

    [SerializeField]
    private int EnergyBonus = 0;
    [SerializeField]
    private int FoodBonus = 0;
    [SerializeField]
    private int MetalBonus = 0;
    [SerializeField]
    private int ScienceBonus = 0;
    [SerializeField]
    private int MoneyBonus = 0;
    //reputation and happiness make it so your citizens dont overthrow you

    [SerializeField]
    private int Reputation = 10;

    //inital worker distributaion

    [SerializeField]
    private int workersFood = 4;
    [SerializeField]
    private int workersMoney = 3;
    [SerializeField]
    private int workersScience = 0;
    [SerializeField]
    private int workersMetal = 1;
    [SerializeField]
    private int workersElectricity = 2;

    public int Population = 0;


    public void cityUpdate() {
        Population = workersFood+workersMoney+workersMetal+workersElectricity+workersScience;

        Food = 2*(workersFood + FoodBonus)/Population;
        Science += 2*(workersScience + ScienceBonus);
        Electricity = 2*(workersElectricity + EnergyBonus) / Population;
        Metal += 2*(workersMetal + MetalBonus);
        Money += 2 * (workersMoney + MoneyBonus);
        Debug.Log("Hello: " + gameObject.name);
    }



}
