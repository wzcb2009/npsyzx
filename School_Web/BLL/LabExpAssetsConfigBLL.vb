Imports Wzsckj.com.Common
Imports DAL
Public Class LabExpAssetsConfigBLL
 shared  Function  insert(LEC As Model.LabExpAssetsConfig) As Model.LabExpAssetsConfig
        Return LabExpAssetsConfigDAL.insert(LEC)
    End Function
    Shared Function Update(LEC As Model.LabExpAssetsConfig) As Model.LabExpAssetsConfig
        Return LabExpAssetsConfigDAL.Update(LEC)
    End Function
    Shared Function del(ID As Integer) As Boolean
        Return LabExpAssetsConfigDAL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return LabExpAssetsConfigDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return LabExpAssetsConfigDAL.dt()
    End Function

    Shared Function Entity(ID As Integer) As Model.LabExpAssetsConfig
        Return LabExpAssetsConfigDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return LabExpAssetsConfigDAL.PagerDt(pi)
    End Function

End Class
