using UnityEngine;

public class CharacterSetup : MonoBehaviour
{
    [SerializeField] private SpriteRenderer skin;
    [SerializeField] private SpriteRenderer body;
    [SerializeField] private SpriteRenderer hair;
    [SerializeField] private SpriteRenderer weapon;
    [SerializeField] private SpriteRenderer mounth;

    [SerializeField] private Sprite[] mounthType = null;
    [SerializeField] private Sprite[] hairType = null;
    [SerializeField] private Sprite[] weaponType = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // BEGIN SET COLORS

    public void SetSkinColor(Color color)
    {
        skin.color = color;
    }

    public void SetBodyColor(Color color)
    {
        body.color = color;
    }

    public void SetHairColor(Color color)
    {
        hair.color = color;
    }

    // END COLORS

    // BEGIN SET PARTS

    public void SetMounth(int index)
    {
        mounth.sprite = mounthType[index];
    }

    public int GetMounths()
    {
        return mounthType.Length;
    }

    public void SetHair(int index)
    {
        hair.sprite = hairType[index];
    }

    public int GetHairs()
    {
        return hairType.Length;
    }

    public void SetWeapon(int index)
    {
        weapon.sprite = weaponType[index];
    }

    public int GetWepons()
    {
        return weaponType.Length;
    }

    // END PARTS
}
