// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingStackPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (VirtualizingStackPanel))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1969737114, 41908, 19946, 187, 17, 84, 158, 44, 47, 145, 157)]
  internal interface IVirtualizingStackPanel
  {
    bool AreScrollSnapPointsRegular { get; set; }

    Orientation Orientation { get; set; }

    event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;
  }
}
