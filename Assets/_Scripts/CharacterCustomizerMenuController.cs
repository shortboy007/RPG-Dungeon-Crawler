using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCustomizerMenuController : MonoBehaviour
{
    public GameObject player;

    public GameObject thisBody;

    public GameObject maleBodySlim;
    public GameObject maleBodyMuscled;

    public GameObject femaleBodySlim;
    public GameObject femaleBodyMuscled;

    public GameObject faceM1;
    public GameObject faceM2;
    public GameObject faceM3;
    public GameObject faceM4;
    public GameObject faceM5;

    public GameObject faceF1;
    public GameObject faceF2;
    public GameObject faceF3;
    public GameObject faceF4;
    public GameObject faceF5;

    //Male
    public GameObject faceSkin1;
    public GameObject faceSkin2;
    public GameObject faceSkin3;
    public GameObject faceSkin4;
    public GameObject faceSkin5;

    //Female
    public GameObject faceSkin6;
    public GameObject faceSkin7;
    public GameObject faceSkin8;
    public GameObject faceSkin9;
    public GameObject faceSkin10;

    public GameObject bodySkin1;
    public GameObject bodySkin2;
    public GameObject bodySkin3;
    public GameObject bodySkin4;

    public GameObject eyes;

    public Material clothes;

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
    
    public Transform CharacterCustomizerExitSpawn;

    public static int faceType;
    
    public static int skinColorType;

    public static int eyeColorType;

    public static int hairStyleType;

    public static int hairColorType;

    public InputField nameInput;

    public GameObject nameTextBox;
    public Text nameText;

    public static bool maleBodyChosen;

    public static bool femaleBodyChosen;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        nameTextBox = GameObject.FindWithTag("NameText");

        Time.timeScale = 0;

        maleBodyChosen = true;
        maleBodyMuscled.GetComponent<Animator>().enabled = false;
        femaleBodySlim.GetComponent<Animator>().enabled = false;
        femaleBodyMuscled.GetComponent<Animator>().enabled = false;
    }

    public void Update()
    {
        if (faceType == 0 && maleBodyChosen)
        {
            resetFace();
            faceM1.SetActive(true);
        }
        if (faceType == 1 && maleBodyChosen)
        {
            resetFace();
            faceM2.SetActive(true);
        }
        if (faceType == 2 && maleBodyChosen)
        {
            resetFace();
            faceM3.SetActive(true);
        }
        if (faceType == 3 && maleBodyChosen)
        {
            resetFace();
            faceM4.SetActive(true);
        }
        if (faceType == 4 && maleBodyChosen)
        {
            resetFace();
            faceM5.SetActive(true);
        }

        if (faceType == 0 && femaleBodyChosen)
        {
            resetFace();
            faceF1.SetActive(true);
        }
        if (faceType == 1 && femaleBodyChosen)
        {
            resetFace();
            faceF2.SetActive(true);
        }
        if (faceType == 2 && femaleBodyChosen)
        {
            resetFace();
            faceF3.SetActive(true);
        }
        if (faceType == 3 && femaleBodyChosen)
        {
            resetFace();
            faceF4.SetActive(true);
        }
        if (faceType == 4 && femaleBodyChosen)
        {
            resetFace();
            faceF5.SetActive(true);
        }

        if (skinColorType == 0)
        {
            resetSkinColor();
            faceSkin1.GetComponent<Renderer>().material = skinColor1;
            faceSkin2.GetComponent<Renderer>().material = skinColor1;
            faceSkin3.GetComponent<Renderer>().material = skinColor1;
            faceSkin4.GetComponent<Renderer>().material = skinColor1;
            faceSkin5.GetComponent<Renderer>().material = skinColor1;
            faceSkin6.GetComponent<Renderer>().material = skinColor1;
            faceSkin7.GetComponent<Renderer>().material = skinColor1;
            faceSkin8.GetComponent<Renderer>().material = skinColor1;
            faceSkin9.GetComponent<Renderer>().material = skinColor1;
            faceSkin10.GetComponent<Renderer>().material = skinColor1;
            bodySkin1.GetComponent<Renderer>().material = skinColor1;
            bodySkin2.GetComponent<Renderer>().material = skinColor1;
            bodySkin3.GetComponent<Renderer>().material = skinColor1;
            bodySkin4.GetComponent<Renderer>().material = skinColor1;
        }
        if (skinColorType == 1)
        {
            resetSkinColor();
            faceSkin1.GetComponent<Renderer>().material = skinColor2;
            faceSkin2.GetComponent<Renderer>().material = skinColor2;
            faceSkin3.GetComponent<Renderer>().material = skinColor2;
            faceSkin4.GetComponent<Renderer>().material = skinColor2;
            faceSkin5.GetComponent<Renderer>().material = skinColor2;
            faceSkin6.GetComponent<Renderer>().material = skinColor2;
            faceSkin7.GetComponent<Renderer>().material = skinColor2;
            faceSkin8.GetComponent<Renderer>().material = skinColor2;
            faceSkin9.GetComponent<Renderer>().material = skinColor2;
            faceSkin10.GetComponent<Renderer>().material = skinColor2;
            bodySkin1.GetComponent<Renderer>().material = skinColor2;
            bodySkin2.GetComponent<Renderer>().material = skinColor2;
            bodySkin3.GetComponent<Renderer>().material = skinColor2;
            bodySkin4.GetComponent<Renderer>().material = skinColor2;
        }
        if (skinColorType == 2)
        {
            resetSkinColor();
            faceSkin1.GetComponent<Renderer>().material = skinColor3;
            faceSkin2.GetComponent<Renderer>().material = skinColor3;
            faceSkin3.GetComponent<Renderer>().material = skinColor3;
            faceSkin4.GetComponent<Renderer>().material = skinColor3;
            faceSkin5.GetComponent<Renderer>().material = skinColor3;
            faceSkin6.GetComponent<Renderer>().material = skinColor3;
            faceSkin7.GetComponent<Renderer>().material = skinColor3;
            faceSkin8.GetComponent<Renderer>().material = skinColor3;
            faceSkin9.GetComponent<Renderer>().material = skinColor3;
            faceSkin10.GetComponent<Renderer>().material = skinColor3;
            bodySkin1.GetComponent<Renderer>().material = skinColor3;
            bodySkin2.GetComponent<Renderer>().material = skinColor3;
            bodySkin3.GetComponent<Renderer>().material = skinColor3;
            bodySkin4.GetComponent<Renderer>().material = skinColor3;
        }
        if (skinColorType == 3)
        {
            resetSkinColor();
            faceSkin1.GetComponent<Renderer>().material = skinColor4;
            faceSkin2.GetComponent<Renderer>().material = skinColor4;
            faceSkin3.GetComponent<Renderer>().material = skinColor4;
            faceSkin4.GetComponent<Renderer>().material = skinColor4;
            faceSkin5.GetComponent<Renderer>().material = skinColor4;
            faceSkin6.GetComponent<Renderer>().material = skinColor4;
            faceSkin7.GetComponent<Renderer>().material = skinColor4;
            faceSkin8.GetComponent<Renderer>().material = skinColor4;
            faceSkin9.GetComponent<Renderer>().material = skinColor4;
            faceSkin10.GetComponent<Renderer>().material = skinColor4;
            bodySkin1.GetComponent<Renderer>().material = skinColor4;
            bodySkin2.GetComponent<Renderer>().material = skinColor4;
            bodySkin3.GetComponent<Renderer>().material = skinColor4;
            bodySkin4.GetComponent<Renderer>().material = skinColor4;
        }
        if (skinColorType == 4)
        {
            resetSkinColor();
            faceSkin1.GetComponent<Renderer>().material = skinColor5;
            faceSkin2.GetComponent<Renderer>().material = skinColor5;
            faceSkin3.GetComponent<Renderer>().material = skinColor5;
            faceSkin4.GetComponent<Renderer>().material = skinColor5;
            faceSkin5.GetComponent<Renderer>().material = skinColor5;
            faceSkin6.GetComponent<Renderer>().material = skinColor5;
            faceSkin7.GetComponent<Renderer>().material = skinColor5;
            faceSkin8.GetComponent<Renderer>().material = skinColor5;
            faceSkin9.GetComponent<Renderer>().material = skinColor5;
            faceSkin10.GetComponent<Renderer>().material = skinColor5;
            bodySkin1.GetComponent<Renderer>().material = skinColor5;
            bodySkin2.GetComponent<Renderer>().material = skinColor5;
            bodySkin3.GetComponent<Renderer>().material = skinColor5;
            bodySkin4.GetComponent<Renderer>().material = skinColor5;
        }

        if (eyeColorType == 0)
        {
            resetEyeColor();
            eyes.GetComponent<Renderer>().material = eyeColor1;
        }
        if (eyeColorType == 1)
        {
            resetEyeColor();
            eyes.GetComponent<Renderer>().material = eyeColor2;
        }
        if (eyeColorType == 2)
        {
            resetEyeColor();
            eyes.GetComponent<Renderer>().material = eyeColor3;
        }
        if (eyeColorType == 3)
        {
            resetEyeColor();
            eyes.GetComponent<Renderer>().material = eyeColor4;
        }
        if (eyeColorType == 4)
        {
            resetEyeColor();
            eyes.GetComponent<Renderer>().material = eyeColor5;
        }

        if (hairStyleType == 0)
        {
            resetHairStyle();
            hairStyle1.SetActive(true);
        }
        if (hairStyleType == 1)
        {
            resetHairStyle();
            hairStyle2.SetActive(true);
        }
        if (hairStyleType == 2)
        {
            resetHairStyle();
            hairStyle3.SetActive(true);
        }
        if (hairStyleType == 3)
        {
            resetHairStyle();
            hairStyle4.SetActive(true);
        }
        if (hairStyleType == 4)
        {
            resetHairStyle();
            hairStyle5.SetActive(true);
        }

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

    public void ReturnToGame()
    {        
        player.transform.position = CharacterCustomizerExitSpawn.transform.position;

        Time.timeScale = 1;
    }

    public void resetGender()
    {
        maleBodyChosen = false;
        femaleBodyChosen = false;
    }

    public void resetBodyType()
    {
        maleBodySlim.SetActive(false);
        maleBodyMuscled.SetActive(false);
        femaleBodySlim.SetActive(false);
        femaleBodyMuscled.SetActive(false);
        maleBodySlim.GetComponent<Animator>().enabled = false;
        maleBodyMuscled.GetComponent<Animator>().enabled = false;
        femaleBodySlim.GetComponent<Animator>().enabled = false;       
        femaleBodyMuscled.GetComponent<Animator>().enabled = false;
    }

    public void resetFace()
    {
        faceM1.SetActive(false);
        faceM2.SetActive(false);
        faceM3.SetActive(false);
        faceM4.SetActive(false);
        faceM5.SetActive(false);
        faceF1.SetActive(false);
        faceF2.SetActive(false);
        faceF3.SetActive(false);
        faceF4.SetActive(false);
        faceF5.SetActive(false);
    }
    public void resetSkinColor()
    {
        faceSkin1.GetComponent<Renderer>().material = skinColor1;
        faceSkin2.GetComponent<Renderer>().material = skinColor1;
        faceSkin3.GetComponent<Renderer>().material = skinColor1;
        faceSkin4.GetComponent<Renderer>().material = skinColor1;
        faceSkin5.GetComponent<Renderer>().material = skinColor1;
        faceSkin6.GetComponent<Renderer>().material = skinColor1;
        faceSkin7.GetComponent<Renderer>().material = skinColor1;
        faceSkin8.GetComponent<Renderer>().material = skinColor1;
        faceSkin9.GetComponent<Renderer>().material = skinColor1;
        faceSkin10.GetComponent<Renderer>().material = skinColor1;
        bodySkin1.GetComponent<Renderer>().material = skinColor1;
        bodySkin2.GetComponent<Renderer>().material = skinColor1;
        bodySkin3.GetComponent<Renderer>().material = skinColor1;
        bodySkin4.GetComponent<Renderer>().material = skinColor1;

    }

    public void resetEyeColor()
    {
        eyes.GetComponent<Renderer>().material = eyeColor1;
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

    public void setBodyColor()
    {
        thisBody = GameObject.FindGameObjectWithTag("ThisBody");

        bodySkin1.GetComponent<Renderer>().material = clothes;
        bodySkin2.GetComponent<Renderer>().material = clothes;
        bodySkin3.GetComponent<Renderer>().material = clothes;
        bodySkin4.GetComponent<Renderer>().material = clothes;

        thisBody.GetComponent<Renderer>().material = clothes;

        skinColorType = -1;
    }
    public void SetName()
    {
        if (nameInput.text != "")
        {
            nameText = nameTextBox.GetComponent<Text>();
            nameText.text = nameInput.text;
        }
        else
        {
            nameText = nameTextBox.GetComponent<Text>();
            nameText.text = "Hero";
        }
        ReturnToGame();
        setBodyColor();
        
    }

    public void SetMale()
    {
        //resetGender();
        resetBodyType();
        maleBodyChosen = true;
        femaleBodyChosen = false;
        maleBodySlim.SetActive(true);
        maleBodySlim.GetComponent<Animator>().enabled = true;
    }

    public void SetFemale()
    {
        //resetGender();
        resetBodyType();
        maleBodyChosen = false;
        femaleBodyChosen = true;
        femaleBodySlim.SetActive(true);
        femaleBodySlim.GetComponent<Animator>().enabled = true;
    }

    public void SetSlimPhysique()
    {
        if (maleBodyChosen)
        {
                resetBodyType();
                maleBodySlim.SetActive(true);
                maleBodySlim.GetComponent<Animator>().enabled = true;

        }
        if (femaleBodyChosen)
        {
                resetBodyType();
                femaleBodySlim.SetActive(true);
                femaleBodySlim.GetComponent<Animator>().enabled = true;

        }
    }

    public void SetMuscledPhysique()
    {
        if (maleBodyChosen)
        {
                resetBodyType();
                maleBodyMuscled.SetActive(true);
                maleBodyMuscled.GetComponent<Animator>().enabled = true;

        }
        if (femaleBodyChosen)
        {
                resetBodyType();
                femaleBodyMuscled.SetActive(true);
                femaleBodyMuscled.GetComponent<Animator>().enabled = true;
        }
    }

    public void NextFace()
    {
        faceType = faceType + 1;
        if (faceType >= 5)
        {
            faceType = 5;
        }
    }

    public void PreviousFace()
    {
        faceType = faceType - 1;
        if (faceType <= 0)
        {
            faceType = 0;
        }
    }

    public void NextSkinColor()
    {
        skinColorType = skinColorType + 1;
        if (skinColorType >= 5)
        {
            skinColorType = 5;
        }
    }

    public void PreviousSkinColor()
    {
        skinColorType = skinColorType - 1;
        if (skinColorType <= 0)
        {
            skinColorType = 0;
        }
    }

    public void NextEyeColor()
    {
        eyeColorType = eyeColorType + 1;
        if (eyeColorType >= 5)
        {
            eyeColorType = 5;
        }
    }

    public void PreviousEyeColor()
    {
        eyeColorType = eyeColorType - 1;
        if (eyeColorType <= 0)
        {
            eyeColorType = 0;
        }
    }

    public void NextHairStyle()
    {
        hairStyleType = hairStyleType + 1;
        if(hairStyleType >= 5)
        {
            hairStyleType = 0;
        }
    }

    public void PreviousHairStyle()
    {
        hairStyleType = hairStyleType - 1;
        if (hairStyleType <= 0)
        {
            hairStyleType = 0;
        }
    }

    public void NextHairColor()
    {
        hairColorType = hairColorType + 1;
        if (hairColorType >= 5)
        {
            hairColorType = 5;
        }
    }

    public void PreviousHairColor()
    {
        hairColorType = hairColorType - 1;
        if (hairColorType <= 0)
        {
            hairColorType = 0;
        }
    }
}

