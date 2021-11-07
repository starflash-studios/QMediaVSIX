// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DependencyObject))]
  [Guid(1548904037, 62990, 18706, 175, 89, 95, 224, 104, 15, 8, 157)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDependencyObject
  {
    object GetValue(DependencyProperty dp);

    void SetValue(DependencyProperty dp, object value);

    void ClearValue(DependencyProperty dp);

    object ReadLocalValue(DependencyProperty dp);

    object GetAnimationBaseValue(DependencyProperty dp);

    CoreDispatcher Dispatcher { get; }
  }
}
