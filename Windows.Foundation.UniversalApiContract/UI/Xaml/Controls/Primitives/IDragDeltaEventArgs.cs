// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (DragDeltaEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(741201724, 10246, 18940, 170, 233, 109, 121, 43, 87, 43, 106)]
  internal interface IDragDeltaEventArgs
  {
    double HorizontalChange { get; }

    double VerticalChange { get; }
  }
}
