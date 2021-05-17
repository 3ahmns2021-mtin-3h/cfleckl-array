using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    private int[] array1 = new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    private string[] array4 = new string[10];
    [SerializeField]
    private GameObject[] arrayColorImagesRed;

    private void Start()
    {
        arrayColorImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        Debug.Log(arrayColoredImagesRed);
    }
}