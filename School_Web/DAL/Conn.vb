Public Module Conn
    ' Public ConnStr As String = "Data Source=(local);Initial Catalog=schoolweb_hczx;Persist Security Info=True;User ID=sa;Password=hczx;Enlist=true;Pooling=true;Max Pool Size=2000;Min Pool Size=300;Connection Lifetime=300;packet size=3000"
    Public ConnStr As String = System.Configuration.ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    Public ConnStr2 As String '= System.Configuration.ConfigurationManager.ConnectionStrings("AccessConnectionString").ConnectionString
End Module
