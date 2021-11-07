// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IGettingFocusEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(2289388923, 46265, 18777, 139, 206, 137, 191, 33, 46, 212, 235)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (GettingFocusEventArgs))]
  internal interface IGettingFocusEventArgs2
  {
    bool TryCancel();

    bool TrySetNewFocusedElement(DependencyObject element);
  }
}
