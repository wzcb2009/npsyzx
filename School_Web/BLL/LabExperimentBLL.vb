Imports Wzsckj.com.Common

Public Class LabExperimentBLL
     Shared Function SaveAndUpdate(le As Model.LabExperiment) As Model.LabExperiment
        If le.ID > 0 Then
            Return DAL.LabExperimentDAL.Update(le)
        Else

            Return DAL.LabExperimentDAL.insert(le)

        End If
    End Function

    Shared Function del(ID As Integer) As Boolean
        Return DAL.LabExperimentDAL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return DAL.LabExperimentDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return DAL.LabExperimentDAL.dt()
    End Function
    Shared Function Entity(ID As Integer) As Model.LabExperiment
        Return DAL.LabExperimentDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.LabExperimentDAL.PagerDt(pi)
    End Function
    Shared Function getId(le As Model.LabExperiment) As Integer
        Return DAL.LabExperimentDAL.GetId(le)
    End Function
End Class
