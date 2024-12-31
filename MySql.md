# MySql
在使用CMD窗口进行相关配置或者启动数据库的时候，打开CMD窗口要右键选择```以管理员身份```启动，否则会由于用户权限问题导致设置失败
<!-- 
## 完整参考
[网络配置教程](https://cloud.tencent.com/developer/article/1998427)
-->
## 参考
解压并安装[MySql&Unity3D相关配置安装包](https://kdocs.cn/l/cbDUd1og4jCz)，在configer窗口配置管理员账户密码。

将```mysql-9.0.1-winx64.msi```的安装地址如 ```C:\Program Files\MySQL\MySQL Server 9.0\bin```添加到到环境变量，以管理员权限打开```CMD```窗口后依次输入
    
    mysqld --install //成功代表安装相关服务
    mysqld --initialize --console //初始化并生成随机密码如下
    

上述的输出结果包含一条包含密码结构的语句
    
    2024-12-14T11:59:37.175976Z 6 [Note] [MY-010454] [Server] A temporary password is generated for root@localhost: khRS?0irOfSM

留存好句末的密码```khRS?0irOfSM```。之后开启数据库服务的指令如下

    net start mysql //成功启动服务

一般来说在安装配置环节设置好了用户名密码之后，此处可直接成功启动。再直接输入下列指令验证是否成功

    mysql -u root -p
输入上文生成的随机密码，无误后进入数据库服务管理模式，此时修改数据库登陆密码

    alter user 'root'@'localhost' identified by '20241214';

修改后的新密码为```20241214```，可自行替换成自己熟悉的密码，在修改后同样记得保存

查询数据库服务所占用的端口号命令，一般默认端口为3306
    
    show global variables like 'port';

## 配置VisualStudio
测试版本是VisualStudio 2022，新建一个空白工程，在最上方的工具栏处依次选择```项目-管理NuGet程序包```，在打开的新标签页中搜索```MySQL.Data```并安装。成功后如下图所示

## 配置Unity3D

在完成上文的配置操作后，Unity3D要使用MySql需要导入相关配置文件，文件版本不宜过高。目前测试是可以[安装](https://downloads.mysql.com/archives/c-net/)```mysql-connector-net-6.10.9.msi```，然后从安装目录下找到```MySql.Data.dll```文件。将该文件复制进Unity3D项目内的```Assets/Plugins```内

<!-- 
## 配置VisualStudio 2022

[VS2022链接Mysql教程](https://blog.csdn.net/qq_48515185/article/details/131841349)


-->