using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterNPCRandomizer : MonoBehaviour
{
    public GameObject player;

    public GameObject bodySlim;
    public GameObject bodyMuscled;

    public GameObject face1;
    public GameObject face2;
    public GameObject face3;
    public GameObject face4;
    public GameObject face5;

    public GameObject faceSkin1;
    public GameObject faceSkin2;
    public GameObject faceSkin3;
    public GameObject faceSkin4;
    public GameObject faceSkin5;

    public GameObject clothes1;
    public GameObject clothes2;

    public Material clothesColor1;
    public Material clothesColor2;
    public Material clothesColor3;
    public Material clothesColor4;
    public Material clothesColor5;

    public GameObject eyes1;

    public Material skinColor1;
    public Material skinColor2;
    public Material skinColor3;
    public Material skinColor4;
    public Material skinColor5;

    public Material eyeColor1;
    public Material eyeColor2;
    public Material eyeColor3;
    public Material eyeColor4;
    public Material eyeColor5;

    public GameObject hairStyle1;
    public GameObject hairStyle2;
    public GameObject hairStyle3;
    public GameObject hairStyle4;
    public GameObject hairStyle5;

    public Material hairColor1;
    public Material hairColor2;
    public Material hairColor3;
    public Material hairColor4;
    public Material hairColor5;

    public static int faceType;
    
    public static int skinColorType;

    public static int eyeColorType;

    public static int hairStyleType;

    public static int hairColorType;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        randomizeCharacters();
    }

    public void Update()
    {

    }

    public void resetBodyType()
    {
        bodySlim.SetActive(false);
        bodyMuscled.SetActive(false);    
    }

    public void resetFace()
    {
        face1.SetActive(false);
        face2.SetActive(false);
        face3.SetActive(false);
        face4.SetActive(false);
        face5.SetActive(false);
    }
    public void resetSkinColor()
    {
        faceSkin1.GetComponent<Renderer>().material = skinColor1;
        faceSkin2.GetComponent<Renderer>().material = skinColor1;
        faceSkin3.GetComponent<Renderer>().material = skinColor1;
        faceSkin4.GetComponent<Renderer>().material = skinColor1;
        faceSkin5.GetComponent<Renderer>().material = skinColor1;


    }

    public void resetClothesColor()
    {
        clothes1.GetComponent<Renderer>().material = skinColor1;
        clothes2.GetComponent<Renderer>().material = skinColor1;
    }

    public void resetEyeColor()
    {
        eyes1.GetComponent<Renderer>().material = eyeColor1;
    }
    public void resetHairStyle()
    {
        hairStyle1.SetActive(false);
        hairStyle2.SetActive(false);
        hairStyle3.SetActive(false);
        hairStyle4.SetActive(false);
        hairStyle5.SetActive(false);
    }
    
    public void resetHairColor()
    {
        hairStyle1.GetComponent<Renderer>().material = hairColor1;
        hairStyle2.GetComponent<Renderer>().material = hairColor1;
        hairStyle3.GetComponent<Renderer>().material = hairColor1;
        hairStyle4.GetComponent<Renderer>().material = hairColor1;
        hairStyle5.GetComponent<Renderer>().material = hairColor1;
    }

    public void SetPhysique()
    {
            resetBodyType();
            var bodyPhysiqueChosen = Random.Range(0, 1);
            if (bodyPhysiqueChosen == 0)
            {
                bodySlim.SetActive(true);

            }
            else if (bodyPhysiqueChosen == 1)
            {
                bodyMuscled.SetActive(true);
            }                           
        }
    
    public void SetFace()
    {
        
            resetFace();
            var faceType = Random.Range(0, 4);

            if (faceType == 0)
            {                
                face1.SetActive(true);
            }
            if (faceType == 1)
            {
                face2.SetActive(true);
            }
            if (faceType == 2)
            {
                face3.SetActive(true);
            }
            if (faceType == 3)
            {
                face4.SetActive(true);
            }
            if (faceType == 4)
            {
                face5.SetActive(true);
            }
        }

    public void SetSkinColor()
    {
        var bodyColorChosen = Random.Range(0, 4);

        if (bodyColorChosen == 0)
        {
            faceSkin1.GetComponent<Renderer>().material = skinColor1;
            faceSkin2.GetComponent<Renderer>().material = skinColor1;
            faceSkin3.GetComponent<Renderer>().material = skinColor1;
            faceSkin4.GetComponent<Renderer>().material = skinColor1;
            faceSkin5.GetComponent<Renderer>().material = skinColor1;
        }
        else if (bodyColorChosen == 1)
        {
            faceSkin1.GetComponent<Renderer>().material = skinColor2;
            faceSkin2.GetComponent<Renderer>().material = skinColor2;
            faceSkin3.GetComponent<Renderer>().material = skinColor2;
            faceSkin4.GetComponent<Renderer>().material = skinColor2;
            faceSkin5.GetComponent<Renderer>().material = skinColor2;
        }
        else if (bodyColorChosen == 2)
        {
            faceSkin1.GetComponent<Renderer>().material = skinColor3;
            faceSkin2.GetComponent<Renderer>().material = skinColor3;
            faceSkin3.GetComponent<Renderer>().material = skinColor3;
            faceSkin4.GetComponent<Renderer>().material = skinColor3;
            faceSkin5.GetComponent<Renderer>().material = skinColor3;
        }
        else if (bodyColorChosen == 3)
        {
            faceSkin1.GetComponent<Renderer>().material = skinColor4;
            faceSkin2.GetComponent<Renderer>().material = skinColor4;
            faceSkin3.GetComponent<Renderer>().material = skinColor4;
            faceSkin4.GetComponent<Renderer>().material = skinColor4;
            faceSkin5.GetComponent<Renderer>().material = skinColor4;
        }
        else if (bodyColorChosen == 4)
        {
            faceSkin1.GetComponent<Renderer>().material = skinColor5;
            faceSkin2.GetComponent<Renderer>().material = skinColor5;
            faceSkin3.GetComponent<Renderer>().material = skinColor5;
            faceSkin4.GetComponent<Renderer>().material = skinColor5;
            faceSkin5.GetComponent<Renderer>().material = skinColor5;
        }
    }

    public void SetClothesColor()
    {
        var clothesColorChosen = Random.Range(0, 4);

        if (clothesColorChosen == 0)
        {
            clothes1.GetComponent<Renderer>().material = clothesColor1;
            clothes2.GetComponent<Renderer>().material = clothesColor1;
        }
        else if (clothesColorChosen == 1)
        {
            clothes1.GetComponent<Renderer>().material = clothesColor2;
            clothes2.GetComponent<Renderer>().material = clothesColor2;
        }
        else if (clothesColorChosen == 2)
        {
            clothes1.GetComponent<Renderer>().material = clothesColor3;
            clothes2.GetComponent<Renderer>().material = clothesColor3;
        }
        else if (clothesColorChosen == 3)
        {
            clothes1.GetComponent<Renderer>().material = clothesColor4;
            clothes2.GetComponent<Renderer>().material = clothesColor4;
        }
        else if (clothesColorChosen == 4)
        {
            clothes1.GetComponent<Renderer>().material = clothesColor5;
            clothes2.GetComponent<Renderer>().material = clothesColor5;
        }
    }

    public void SetEyeColor()
    {
        var eyeColorType = Random.Range(0, 4);
        resetEyeColor();
        if (eyeColorType == 0)
        {
            eyes1.GetComponent<Renderer>().material = eyeColor1;
        }
        if (eyeColorType == 1)
        {
            eyes1.GetComponent<Renderer>().material = eyeColor2;
        }
        if (eyeColorType == 2)
        {
            eyes1.GetComponent<Renderer>().material = eyeColor3;
        }
        if (eyeColorType == 3)
        {
            eyes1.GetComponent<Renderer>().material = eyeColor4;
        }
        if (eyeColorType == 4)
        {
            eyes1.GetComponent<Renderer>().material = eyeColor5;
        }
    }

    public void SetHairStyle()
    {
        var hairStyleType = Random.Range(0, 4);
        resetHairStyle();
        if (hairStyleType == 0)
        {            
            hairStyle1.SetActive(true);
        }
        if (hairStyleType == 1)
        {
            hairStyle2.SetActive(true);
        }
        if (hairStyleType == 2)
        {
            hairStyle3.SetActive(true);
        }
        if (hairStyleType == 3)
        {
            hairStyle4.SetActive(true);
        }
        if (hairStyleType == 4)
        {
            hairStyle5.SetActive(true);
        }
    }

    public void SetHairColor()
    {        
        var hairColorType = Random.Range(0, 4);

        if (hairColorType == 0)
        {
            resetHairColor();
            hairStyle1.GetComponent<Renderer>().material = hairColor1;
            hairStyle2.GetComponent<Renderer>().material = hairColor1;
            hairStyle3.GetComponent<Renderer>().material = hairColor1;
            hairStyle4.GetComponent<Renderer>().material = hairColor1;
            hairStyle5.GetComponent<Renderer>().material = hairColor1;
        }
        if (hairColorType == 1)
        {
            resetHairColor();
            hairStyle1.GetComponent<Renderer>().material = hairColor2;
            hairStyle2.GetComponent<Renderer>().material = hairColor2;
            hairStyle3.GetComponent<Renderer>().material = hairColor2;
            hairStyle4.GetComponent<Renderer>().material = hairColor2;
            hairStyle5.GetComponent<Renderer>().material = hairColor2;
        }
        if (hairColorType == 2)
        {
            resetHairColor();
            hairStyle1.GetComponent<Renderer>().material = hairColor3;
            hairStyle2.GetComponent<Renderer>().material = hairColor3;
            hairStyle3.GetComponent<Renderer>().material = hairColor3;
            hairStyle4.GetComponent<Renderer>().material = hairColor3;
            hairStyle5.GetComponent<Renderer>().material = hairColor3;
        }
        if (hairColorType == 3)
        {
            resetHairColor();
            hairStyle1.GetComponent<Renderer>().material = hairColor4;
            hairStyle2.GetComponent<Renderer>().material = hairColor4;
            hairStyle3.GetComponent<Renderer>().material = hairColor4;
            hairStyle4.GetComponent<Renderer>().material = hairColor4;
            hairStyle5.GetComponent<Renderer>().material = hairColor4;
        }
        if (hairColorType == 4)
        {
            resetHairColor();
            hairStyle1.GetComponent<Renderer>().material = hairColor5;
            hairStyle2.GetComponent<Renderer>().material = hairColor5;
            hairStyle3.GetComponent<Renderer>().material = hairColor5;
            hairStyle4.GetComponent<Renderer>().material = hairColor5;
            hairStyle5.GetComponent<Renderer>().material = hairColor5;
        }

    }

    public void randomizeCharacters()
    {
        SetFace();
        SetPhysique();
        SetClothesColor();
        SetSkinColor();
        SetEyeColor();
        SetHairStyle();
        SetHairColor();
    }
}

