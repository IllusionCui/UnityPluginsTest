# Unity的Managed Plugins学习

## 非含有Unity相关的代码

### 建立项目
> 1.使用Unity自带的MonoDevelop，新建Solution，项目类型为library。

> 2.编译生成.dll文件。

### 导入Unity
将对应的.dll文件导入到项目的Asset/Plugins／文件夹下，即可使用。

如果调试也需要将生成的.dll.mdb文件导入到项目的Asset/Plugins／文件夹下。

## 含有Unity相关代码

### 建立项目
> 1.上述过程1

> 2.将对应UnityEngine.dll等Unity相关的.dll文件导入到项目中，可以点击Reference的设置添加本地库。

> 3.编辑生成.dll文件。

### 导入Unity
将对应的.dll文件（不需要导入之前已经链接的相关Unity的.dll文件）导入到项目的Asset/Plugins／文件夹下，即可使用。

如果调试也需要将生成的.dll.mdb文件导入到项目的Asset/Plugins／文件夹下。

对应MonoBehave文件可以直接拖到游戏内组建总使用的。


## Test项目
###UnityManagedPluginsTest
非含有Unity的.dll项目

###UnityManagedPulginsMonoTest
含有Unity的.dll项目

###UnityPluginsTest
使用UnityManagedPluginsTest和UnityManagedPulginsMonoTest生成的.dll的unity项目
	
