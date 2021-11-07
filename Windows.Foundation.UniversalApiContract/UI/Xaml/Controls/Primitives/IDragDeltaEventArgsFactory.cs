// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1189585391, 44565, 17574, 138, 4, 149, 176, 191, 154, 184, 118)]
  [ExclusiveTo(typeof (DragDeltaEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragDeltaEventArgsFactory
  {
    DragDeltaEventArgs CreateInstanceWithHorizontalChangeAndVerticalChange(
      double horizontalChange,
      double verticalChange,
      object baseInterface,
      out object innerInterface);
  }
}
