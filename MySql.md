# MySql

官方下载，在configer窗口配置管理员账户密码

添加安装地址如 ```C:\Program Files\MySQL\MySQL Server 9.0\bin```到环境变量，打开```cmd```窗口后直接输入```mysql -u root -p```并回车，输入密码后进入数据库服务管理模式

查询数据库服务所占用的端口号命令，一般默认端口为3306
    
    show global variables like 'port';

## 配置Unity3D

官方下载完整包，安装路径默认 ```C:\Program Files (x86)\MySQL\MySQL Connector NET 9.0\```
，或直接下载[MySql.Data.dll](https://kdocs.cn/l/cspGSFIt561d)。将文件导入到Unity3D项目内