using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialog : MonoBehaviour
{
    public float maxDistance = 10;
    [TextArea(3,5)]
    public string dialogText;

    private DialogManager dialogManager;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        dialogManager = GameObject.Find("Canvas").GetComponent<DialogManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void OnMouseDown()
    {
        float d = Vector3.Distance(transform.position, player.transform.position);
        if(d < maxDistance)
        {
            dialogManager.ShowDialog(dialogText);
        }
    }
}
