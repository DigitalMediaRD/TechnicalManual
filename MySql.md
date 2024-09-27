# MySql

官方下载，在configer窗口配置管理员账户密码

添加安装地址如 ```C:\Program Files\MySQL\MySQL Server 9.0\bin```到环境变量，打开```cmd```窗口后直接输入```mysql -u root -p```并回车，输入密码后进入数据库服务管理模式

查询数据库服务所占用的端口号命令
    
    show global variables like 'port';