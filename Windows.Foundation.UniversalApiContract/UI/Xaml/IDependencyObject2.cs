// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObject2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(704567389, 15650, 17313, 173, 208, 23, 2, 124, 8, 178, 18)]
  [ExclusiveTo(typeof (DependencyObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDependencyObject2
  {
    long RegisterPropertyChangedCallback(
      DependencyProperty dp,
      DependencyPropertyChangedCallback callback);

    void UnregisterPropertyChangedCallback(DependencyProperty dp, long token);
  }
}
