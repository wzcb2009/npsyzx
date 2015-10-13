Imports log4net
Public Class flog_class
    Private Shared LOGGER As ILog = LogManager.GetLogger("Test")
    Public Shared Sub Debug(p_meessage As Object)
        LOGGER.Debug(p_meessage)
    End Sub


End Class
