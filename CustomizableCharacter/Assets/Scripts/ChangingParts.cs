using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangingParts : MonoBehaviour
{
    //TODO: Create a generic fuction that recive these parameters and the game controller has a vector of this

    private CharacterSetup character;

    [Header("Mounth")]
    [SerializeField] private GameObject L_MounthArrow = null;
    [SerializeField] private GameObject R_MounthArrow = null;
    [SerializeField] private TextMeshProUGUI mouthNumber = null;
    private int mounthMax = 0;
    private int mouthIndex = 0;

    [Header("Hair")]
    [SerializeField] private GameObject L_HairArrow = null;
    [SerializeField] private GameObject R_HairArrow = null;
    [SerializeField] private TextMeshProUGUI hairNumber = null;
    private int hairMax = 0;
    private int hairIndex = 0;

    [Header("Weapon")]
    [SerializeField] private GameObject L_WeaponArrow = null;
    [SerializeField] private GameObject R_WeaponArrow = null;
    [SerializeField] private TextMeshProUGUI weaponNumber = null;
    private int weaponMax = 0;
    private int weaponIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterSetup>();

        L_MounthArrow.SetActive(false);
        L_HairArrow.SetActive(false);
        L_WeaponArrow.SetActive(false);

        mounthMax = character.GetMounths() -1;
        hairMax = character.GetHairs() -1;
        weaponMax = character.GetWepons() -1;
    }


    public void NextObject(string obj)
    {
        switch (obj)
        {
            case "mounth":
                NextMouth();
                break;
            case "hair":
                NextHair();
                break;
            case "weapon":
                NextWeapon();
                break;
        }
    }

    private void NextMouth()
    {
        mouthIndex++;

        //if the left arrow is disable, make it able
        if (!L_MounthArrow.active)
            L_MounthArrow.SetActive(true);
        //if the index is the maximum it can be, the button is desable
        if (mouthIndex == mounthMax)
            R_MounthArrow.SetActive(false);
        //set the text
        mouthNumber.text = (mouthIndex+1).ToString();
        //set the sprite
        character.SetMounth(mouthIndex);
    }

    private void NextHair()
    {
        hairIndex++;

        //if the left arrow is disable, make it able
        if (!L_HairArrow.active)
            L_HairArrow.SetActive(true);
        //if the index is the maximum it can be, the button is desable
        if (hairIndex == hairMax)
            R_HairArrow.SetActive(false);
        //set the text
        hairNumber.text = (hairIndex+1).ToString();
        //set the sprite
        character.SetHair(hairIndex);
    }

    private void NextWeapon()
    {
        weaponIndex++;

        //if the left arrow is disable, make it able
        if (!L_WeaponArrow.active)
            L_WeaponArrow.SetActive(true);
        //if the index is the maximum it can be, the button is desable
        if (weaponIndex == weaponMax)
            R_WeaponArrow.SetActive(false);
        //set the text
        weaponNumber.text = (weaponIndex+1).ToString();
        //set the sprite
        character.SetWeapon(weaponIndex);
    }

    public void BackObject(string obj)
    {
        switch (obj)
        {
            case "mounth":
                BackMouth();
                break;
            case "hair":
                BackHair();
                break;
            case "weapon":
                BackWeapon();
                break;
        }
    }

    private void BackMouth()
    {
        mouthIndex--;

        //if the right arrow is disable, make it able
        if (!R_MounthArrow.active)
            R_MounthArrow.SetActive(true);
        //if the index is the minimun it can be, the button is desable
        if (mouthIndex == 0)
            L_MounthArrow.SetActive(false);
        //set the text
        mouthNumber.text = (mouthIndex+1).ToString();
        //set the sprite
        character.SetMounth(mouthIndex);
    }

    private void BackHair()
    {
        hairIndex--;

        //if the right arrow is disable, make it able
        if (!R_HairArrow.active)
            R_HairArrow.SetActive(true);
        //if the index is the minimun it can be, the button is desable
        if (hairIndex == 0)
            L_HairArrow.SetActive(false);
        //set the text
        hairNumber.text = (hairIndex+1).ToString();
        //set the sprite
        character.SetHair(hairIndex);
    }

    private void BackWeapon()
    {
        weaponIndex--;

        //if the right arrow is disable, make it able
        if (!R_WeaponArrow.active)
            R_WeaponArrow.SetActive(true);
        //if the index is the maximum it can be, the button is desable
        if (weaponIndex == 0)
            L_WeaponArrow.SetActive(false);
        //set the text
        weaponNumber.text = (weaponIndex+1).ToString();
        //set the sprite
        character.SetWeapon(weaponIndex);
    }
}
