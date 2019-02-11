using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public TMP_Text textElement;
    public float lettersPerSecond;
    public float autoCloseDelaySeconds;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ShowDialog(string dialogText)
    {
        animator.SetBool("open", true);
        //StopCoroutine(AnimateLetters(dialogText));
        StopAllCoroutines();
        StartCoroutine(AnimateLetters(dialogText));
    }

    private IEnumerator AnimateLetters(string text)
    {
        textElement.text = "";
        foreach(char c in text.ToCharArray())
        {
            textElement.text += c;
            yield return new WaitForSeconds(1 / lettersPerSecond);
        }
        StartCoroutine(HideDialog());
    }

    private IEnumerator HideDialog()
    {
        yield return new WaitForSeconds(autoCloseDelaySeconds);
        animator.SetBool("open", false);
    }
}
