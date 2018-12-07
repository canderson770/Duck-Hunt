using UnityEngine;
using System.Collections;

public class DogLayerSwitch : MonoBehaviour
{
    public int sortingOrder = 0;
    private SpriteRenderer sprite;

    //void Start () {}

    //void Update () {}

    void SwitchLayerBack()
	{
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Dog";
    }

    void SwitchLayerFront()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Foreground";
    }
}
