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
            Debug.Log("------链接成功------");
            //sql语句
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
            Debug.Log("------开始查询------");
            //sql语句
            string useDatabaseQuery = "SELECT * FROM test;";
            Debug.Log(useDatabaseQuery);
            MySqlCommand comd = new MySqlCommand(useDatabaseQuery, con);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                //通过reader获得数据库信息
                Debug.Log(reader.GetString("name"));
            }
            Debug.Log("------查询成功------");
        }
        catch (System.Exception e)
        {
            Debug.Log("Error:" + e.Message);
            CreateTable(con);
        }
        finally
        {
            con.Close();
            Debug.Log("------查询结束------");
        }
    }
    void CreateTable(MySqlConnection con)
    {
        try
        {
            Debug.Log("------开始创建------");
            //sql语句
            string createTable = "CREATE TABLE test (id int PRIMARY KEY AUTO_INCREMENT," +
                "name VARCHAR(30)," +
                "age INT);";
            Debug.Log(createTable);
            MySqlCommand comd = new MySqlCommand(createTable, con);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                //通过reader获得数据库信息
                Debug.Log(reader.GetString("name"));
            }
            Debug.Log("------创建成功------");
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
