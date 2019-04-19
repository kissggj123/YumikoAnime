## YumikoAnime番剧数据工具

因为感觉经常在各视频网站找番有点浪费时间，于是就突然萌生了一个想法：如果能快速的找到想要的番剧的话多好。然后在github上找到了一个airAnime的项目。

airAnime链接：https://github.com/txperl/airAnime 感谢原作者

但是因为懒得手动按照作者的方法更新番剧数据 故 写出了该工具。。。

## 代码文件说明

```
.
├── .Yumiko Json数据更新
    ├── .bin - 生成的exe文件目录
    ├── CSkin.dll - 皮肤控件
    ├── Form1.cs - 窗体的代码文件
    ├── bitbug_favicon.ico - 程序logo
    ├── ic_launcher.ico - 备用logo
```

写的很垃圾 反正能用就行

## 程序BUG
1.更新数据后如果需要再次更新数据需要退出程序再次运行
2.上传目前没有太好的办法


## 程序准备工作

- clone https://github.com/txperl/airAnime 并上传项目文件到服务器
- 做好解析并记录下anime1.php agefans.php calibur.php的网址路径
- 修改String amine1url Calibururl ageurl的值即可
- 在upload方法内修改为你自己的ftp地址 用户名 密码（当然欢迎重写方法）

编译后去bin文件夹下找exe运行即可。

### 额外说明

##### 编译环境
visual studio 2017
windows 10


## 想说的

本程序源代码可任意修改并使用 也欢迎重构整个项目
