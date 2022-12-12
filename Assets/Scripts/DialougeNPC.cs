// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class DialougeNPC : MonoBehaviour
// {
//     public GameObject dialougePanel;
//     public Text DialougeText;
//     public string[] dialouge;
//     private int index;

//     public float wordSpeed;
//     public bool playerIsClose;

//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.E) && playerIsClose)
//         {
//             if(dialougePanel.activeInHierarchy)
//             {
//                 zeroText();
//             }
//             else
//             {
//                 dialougePanel.SetActive(true);
//                 StartCoroutine(Typing());
//             }
//         }
//     }

//     public void zeroText()
//     {
//         DialougeText.text = "";
//         index = 0;
//         dialougePanel.SetActive(false);
//     }

//     IEnumerator Typing()
//     {
//         foreach(char letter in dialouge[index].ToCharArray())
//         {
//             DialougeText = DialougeText + letter;
//             yield return new WaitForSeconds(wordSpeed);
//         }
//     }

//     public void NextLine()
//     {
//         if(index < dialouge.Length - 1)
//         {
//             index++;
//             DialougeText.text = "";
//             StartCoroutine(Typing());
//         }
//         else
//         {
//             zeroText();
//         }
//     }

//     private void OnTriggerEnter2D(Collider2D other) 
//     {
//         if(other.CompareTag("Fighter"))
//         {
//             playerIsClose = true;
//         }
//     }

//      private void OnTriggerExit2D(Collider2D other) 
//     {
//         if(other.CompareTag("Fighter"))
//         {
//             playerIsClose = false;
//             zeroText();
//         }
//     }
// }
