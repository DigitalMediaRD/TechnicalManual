using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MySql.Data.MySqlClient;

public class MySQLLink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Connection();
    }

    // Update is called once per frame
    void Connection()
    {
        string sqlSer = "server = 192.168.10.19;" +
            "port = 3306;" +
            "user= root;" +
            "database = test;" +
            "password =root;";
        MySqlConnection con = new MySqlConnection(sqlSer);
        try
        {
            con.Open();
            Debug.Log("------���ӳɹ�------");
            //sql���
            Query(con);
        }
        catch (System.Exception e)
        {
            Debug.Log("Error:" + e.Message);
        }
        finally
        {
            con.Close();
        }

    }

    void Query(MySqlConnection con) {
        try
        {
            Debug.Log("------��ʼ��ѯ------");
            //sql���
            string useDatabaseQuery = "SELECT * FROM test;";
            Debug.Log(useDatabaseQuery);
            MySqlCommand comd = new MySqlCommand(useDatabaseQuery, con);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                //ͨ��reader������ݿ���Ϣ
                Debug.Log(reader.GetString("name"));
            }
            Debug.Log("------��ѯ�ɹ�------");
        }
        catch (System.Exception e)
        {
            Debug.Log("Error:" + e.Message);
            CreateTable(con);
        }
        finally
        {
            con.Close();
            Debug.Log("------��ѯ����------");
        }
    }
    void CreateTable(MySqlConnection con)
    {
        try
        {
            Debug.Log("------��ʼ����------");
            //sql���
            string createTable = "CREATE TABLE test (id int PRIMARY KEY AUTO_INCREMENT," +
                "name VARCHAR(30)," +
                "age INT);";
            Debug.Log(createTable);
            MySqlCommand comd = new MySqlCommand(createTable, con);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                //ͨ��reader������ݿ���Ϣ
                Debug.Log(reader.GetString("name"));
            }
            Debug.Log("------�����ɹ�------");
        }
        catch (System.Exception e)
        {
            Debug.Log("Error:" + e.Message);
        }
        finally
        {
            con.Close();
            
        }
    }
}
