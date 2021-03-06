﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The ressource manager
public class DropPoint : MonoBehaviour
{

    private int woodQuantity;
    private int animalQuantity;
    private int vegetalQuantity;

    public int woodMaxCapacity;
    public int animalMaxCapacity;
    public int vegetalMaxCapacity;

    public int maxCapacity;
    private int totalCapacity;

    private bool isFull = false;
    
    // Start is called before the first frame update
    void Start()
    {
        maxCapacity = woodMaxCapacity + animalMaxCapacity + vegetalMaxCapacity;
    }

    // Update is called once per frame
    void Update()
    {
        CheckCapacity();
        LimitCapacity();
    }

    private void CheckCapacity()
    {
        totalCapacity = 0;
        totalCapacity = woodQuantity + animalQuantity + vegetalQuantity;
        
        if(totalCapacity >= maxCapacity)
        {
            isFull = true;
        }
        else 
        {
            isFull = false;
        }
    }

    private void LimitCapacity()
    {
        woodQuantity = Mathf.Clamp(woodQuantity, 0, woodMaxCapacity);
        animalQuantity = Mathf.Clamp(animalQuantity, 0, animalMaxCapacity);
        vegetalQuantity = Mathf.Clamp(vegetalQuantity, 0, vegetalQuantity);
    }

    public void SetRessource(int[] ressources)
    {
        this.woodQuantity += ressources[0];
        this.animalQuantity += ressources[1];
        this.vegetalQuantity += ressources[2];
        CheckCapacity();
    }

    public bool IsFull()
    {
        return isFull;
    }

    public int GetTotalCapacity()
    {
        totalCapacity = woodQuantity + animalQuantity + vegetalQuantity;
        return totalCapacity;
    }

    public int GetMaxCapacity()
    {
        maxCapacity = woodMaxCapacity + animalMaxCapacity + vegetalMaxCapacity;
        return this.maxCapacity;
    }

    public int GetWood()
    {
        return this.woodQuantity;
    }

    public int GetMaxWood()
    {
        return this.woodMaxCapacity;
    }

    public int GetAnimal()
    {
        return this.animalQuantity;
    }

    public int GetMaxAnimal()
    {
        return this.animalMaxCapacity;
    }

    public int GetVegetal()
    {
        return this.vegetalQuantity;
    }

    public int GetMaxVegetal()
    {
        return this.vegetalMaxCapacity;
    }

    public void ChangeWoodMaxCapacity(int d)
    {
        this.woodMaxCapacity += d;
        maxCapacity = woodMaxCapacity + animalMaxCapacity + vegetalMaxCapacity;
    }

    public void ChangeAnimalMaxCapacity(int d)
    {
        this.animalMaxCapacity += d;
        maxCapacity = woodMaxCapacity + animalMaxCapacity + vegetalMaxCapacity;
    }

    public void ChangeVegetalMaxCapacity(int d)
    {
        this.vegetalMaxCapacity += d;
        maxCapacity = woodMaxCapacity + animalMaxCapacity + vegetalMaxCapacity;
    }

    public void DecrementWood(int d)
    {
        this.woodQuantity -= d;
    }

    public void DecrementAnimal(int d)
    {
        this.animalQuantity -= d;
    }

    public void DecrementVegetal(int d)
    {
        this.vegetalQuantity -= d;
    }
}
