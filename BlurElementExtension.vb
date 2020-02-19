Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects

Module BlurElementExtension
    <Extension()>
    Sub BlurApply(ByVal element As UIElement, ByVal blurRadius As Double, ByVal duration As TimeSpan, ByVal beginTime As TimeSpan)
        Dim blur As BlurEffect = New BlurEffect() With {
            .Radius = 0
        }
        Dim blurEnable As DoubleAnimation = New DoubleAnimation(0, blurRadius, duration) With {
            .BeginTime = beginTime
        }
        element.Effect = blur
        blur.BeginAnimation(BlurEffect.RadiusProperty, blurEnable)
    End Sub

    <Extension()>
    Sub BlurDisable(ByVal element As UIElement, ByVal duration As TimeSpan, ByVal beginTime As TimeSpan)
        Dim blur As BlurEffect = TryCast(element.Effect, BlurEffect)

        If blur Is Nothing OrElse blur.Radius = 0 Then
            Return
        End If

        Dim blurDisable As DoubleAnimation = New DoubleAnimation(blur.Radius, 0, duration) With {
            .BeginTime = beginTime
        }
        blur.BeginAnimation(BlurEffect.RadiusProperty, blurDisable)
    End Sub
End Module
