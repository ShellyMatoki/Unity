using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;

public class MySaveDataScript : MonoBehaviour
{
/*    static public void Save(HeartCounter heartCounter)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/MySharedData.dat");

        HeartCounter sharedData = new HeartCounter();

        sharedData.counterText.text = heartCounter.counterText.;
       

        bf.Serialize(file, sharedData);
        file.Close();
    }

    static public HeartCounter Load()
    {
        if (File.Exists(Application.persistentDataPath + "/MySharedData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Application.persistentDataPath + "/MySharedData.dat", FileMode.Open);
            HeartCounter sharedData = bf.Deserialize(fs) as HeartCounter;
            fs.Close();

            if (sharedData != null)
            {
                Debug.Log("heart num: " + sharedData.ToString());
              
            }
            return sharedData;
        }
        return null;
    }
*/

}
