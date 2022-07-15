using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//[System.Serializable]

public static class SaveSystem
{

    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "player.save";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = (PlayerData)formatter.Deserialize(stream);
            stream.Close();
            return data;
        }
        else 
        {
            Debug.LogError("Save file wasn't found in " + path);
            return null;
        }
    }

    /*

    float fuel;
    int cartridges;

    string path = "Assets/SaveFile/Save#2.txt";

    StreamWriter writer = new StreamWriter("Assets/SaveFile/Save#2.txt");

    StreamReader reader = new StreamReader("Assets/SaveFile/Save#2.txt");

    //File

    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/SaveFile/Save#2.txt";

        //writer = new StreamWriter(path);

        //reader = new StreamReader(path);

        //print(writer);
        //Debug.Log(writer);

        ReadTheSaveFile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReadTheSaveFile()
    {
        string textFule = reader.ReadLine();
        Debug.Log(textFule);
    }
    */
}
