using UnityEngine;

public class CharacterSetup : MonoBehaviour
{
    [SerializeField] private SpriteRenderer skin;
    [SerializeField] private SpriteRenderer body;
    [SerializeField] private SpriteRenderer hair;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
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
}
