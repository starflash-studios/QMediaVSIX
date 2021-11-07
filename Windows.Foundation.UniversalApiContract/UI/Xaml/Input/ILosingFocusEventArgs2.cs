// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ILosingFocusEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(76806873, 49791, 18079, 142, 98, 82, 179, 164, 247, 205, 84)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LosingFocusEventArgs))]
  internal interface ILosingFocusEventArgs2
  {
    bool TryCancel();

    bool TrySetNewFocusedElement(DependencyObject element);
  }
}
