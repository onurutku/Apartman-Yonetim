﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Bu kod araç tarafından oluşturuldu.
'     Çalışma Zamanı Sürümü:4.0.30319.42000
'
'     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
'     kod yeniden oluşturulursa kaybolur.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    'sınıfı tarafından otomatik olarak oluşturuldu.
    'Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    'komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    '''<summary>
    '''  Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ApartmentManagement.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular
        '''  CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
