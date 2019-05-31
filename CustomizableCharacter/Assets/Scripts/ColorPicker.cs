using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    [Header ("Panels")]
    [SerializeField] private GameObject skinPanel = null;
    [SerializeField] private GameObject bodyPanel = null;
    [SerializeField] private GameObject hairPanel = null;


    // TODO: create a way to recive the object that has the color
    // easier way to add new objects
    [Header("Colors")]
    [SerializeField] private Image SelectedSkinColor = null;
    [SerializeField] private Color[] skinColors = null;

    [SerializeField] private Image SelectedBodyColor = null;
    [SerializeField] private Color[] bodyColors = null;

    [SerializeField] private Image SelectedHairColor = null;
    [SerializeField] private Color[] hairColors = null;

    private int skinColor = 0;
    private int bodyColor = 0;
    private int hairColor = 0;

    private CharacterSetup character;

    private void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterSetup>();

        skinPanel.SetActive(false);
        bodyPanel.SetActive(false);
        hairPanel.SetActive(false);

        character.SetSkinColor(skinColors[skinColor]);
        character.SetBodyColor(bodyColors[bodyColor]);
        character.SetHairColor(hairColors[hairColor]);

        SelectedSkinColor.color = skinColors[skinColor];
        SelectedBodyColor.color = bodyColors[bodyColor];
        SelectedHairColor.color = hairColors[hairColor];
    }

    // Open the panel to enable the player to choose the color he wants
    // Parameter
    // panel = the name of the panel it will be opened
    public void OpenPanel(string panel)
    {
        switch(panel)
        {
            case "skin":
                skinPanel.SetActive(true);
                break;
            case "body":
                bodyPanel.SetActive(true);
                break;
            case "hair":
                hairPanel.SetActive(true);
                break;
        }
    }

    // Close the panel of the color picker
    // Parameter
    // panel = the name of the panel it will be closed
    public void ClosePanel(string panel)
    {
        switch (panel)
        {
            case "skin":
                skinPanel.SetActive(false);
                break;
            case "body":
                bodyPanel.SetActive(false);
                break;
            case "hair":
                hairPanel.SetActive(false);
                break;
        }
    }


    // Set the skin color choose in the character and in the color pick
    public void SetSkinColor(int index)
    {
        skinColor = index;

        SelectedSkinColor.color = skinColors[skinColor];
        character.SetSkinColor(skinColors[skinColor]);
    }

    // Set the body color choose in the character and in the color pick
    public void SetBodyColor(int index)
    {
        bodyColor = index;

        SelectedBodyColor.color = bodyColors[bodyColor];
        character.SetBodyColor(bodyColors[bodyColor]);
    }

    // Set the hair color choose in the character and in the color pick
    public void SetHairColor(int index)
    {
        hairColor = index;

        SelectedHairColor.color = hairColors[hairColor];
        character.SetHairColor(hairColors[hairColor]);
    }
}
