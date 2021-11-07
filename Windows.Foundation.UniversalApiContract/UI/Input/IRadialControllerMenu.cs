// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenu
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerMenu))]
  [Guid(2231808861, 63040, 17426, 171, 160, 186, 208, 119, 229, 234, 138)]
  internal interface IRadialControllerMenu
  {
    IVector<RadialControllerMenuItem> Items { get; }

    bool IsEnabled { get; set; }

    RadialControllerMenuItem GetSelectedMenuItem();

    void SelectMenuItem(RadialControllerMenuItem menuItem);

    bool TrySelectPreviouslySelectedMenuItem();
  }
}
