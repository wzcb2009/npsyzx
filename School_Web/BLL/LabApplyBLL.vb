Imports Wzsckj.com.Common

Public Class LabApplyBLL
    Shared Function insert(L As Model.LabApply) As Model.LabApply
        Return DAL.LabApplyDAL.insert(L)
    End Function
    Shared Function Update(L As Model.LabApply) As Model.LabApply
        Return DAL.LabApplyDAL.Update(L)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.LabApplyDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.LabApplyDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.LabApplyDAL.dt()
    End Function

    Shared Function Entity(Id As Integer) As Model.LabApply
        Return DAL.LabApplyDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.LabApplyDAL.PagerDt(pi)
    End Function
    Shared Function isExit(L As Model.LabApply) As Boolean
        Return DAL.LabApplyDAL.isExit(L)
    End Function
    Shared Function UpdateAssetsChecked(id As Integer, AssetsChecked As Object, AssetsCheckedDate As DateTime) As Boolean
        Return DAL.LabApplyDAL.UpdateAssetsChecked(id, AssetsChecked, AssetsCheckedDate)
    End Function

End Class
