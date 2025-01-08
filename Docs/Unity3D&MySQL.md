# 说明

Unity3D&MySQL数据库的基础案例，复现案例的前提是掌握一种面向对象编程语言、MySQL数据库的概念及语法。并按照[该文档](https://github.com/DigitalMediaRD/TechnicalManual/blob/main/MySql.md)配置好相关工具。

# 案例

## Unity3D连接本地数据库

[源码文件](https://github.com/DigitalMediaRD/TechnicalManual/blob/main/Examples/MySQL/MySQLLink.cs)包含连接数据库、查询数据库中的数据表以及创建数据表三个基础功能，文件UML结构如下图
![]()

其中```sqlSer```中的字符串意义如下表，查看自己计算机的相关配置，修改列标为值的数据

|字符串|值|功能|
|---|---|---|
|server|192.168.10.19;|运行数据库设备的IP地址|
|port|3306;|系统分配给数据库的端口号|
|user|root;|访问数据库的账户|
|database|test;|访问数据库的具体数据表|
|password|root;|与账户对应的密码|

配置正确的情况下会在Unity3D的控制台输出相关的提示