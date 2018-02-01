using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveData {

    public static CharContainer charContainer = new CharContainer();

    public delegate void SerializeAction();
    public static event SerializeAction OnLoaded;
    public static event SerializeAction OnBeforeSave;

    public static void Load(string path) {

        charContainer = LoadChar(path);

    }

    public static void Save(string path, CharContainer chars) {

        OnBeforeSave();
        SaveChar(path, chars);
        ClearCharList();

    }

    public static void AddCharData(CharData data) {
        charContainer.chars.Add(data);
    }

    public static void ClearCharList(){
        charContainer.chars.Clear();
    }

    private static CharContainer LoadChar(string path) {

        string json = File.ReadAllText(path);

        return JsonUtility.FromJson<CharContainer>(json);

    }

    private static void SaveChar(string path, CharContainer chars) {
        string json = JsonUtility.ToJson(chars);

        StreamWriter sw = File.CreateText(path);
        sw.Close();

        File.WriteAllText(path, json);
    }

}
