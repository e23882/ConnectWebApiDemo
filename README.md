# ConnectWebApiDemo

## C# 連接WebApi範例
* Post(新增)
>     ConnectWebApiDemo/Program.cs
>     public static void PostAction()

* Get(查詢)、Delete(刪除)
>     查詢/刪除 共用 CommonFunction/APIConnector.cs
>     CommonFunction/APIConnector.Get()，修改程式Delete為Get就變成查詢
>     APIConnector.Get(url)

* Put(更新)
>     ConnectWebApiDemo/Program.cs
>     public static void PutAction()
