// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragStartedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1592780153, 50950, 18305, 163, 8, 201, 231, 244, 198, 161, 215)]
  [ExclusiveTo(typeof (DragStartedEventArgs))]
  internal interface IDragStartedEventArgsFactory
  {
    DragStartedEventArgs CreateInstanceWithHorizontalOffsetAndVerticalOffset(
      double horizontalOffset,
      double verticalOffset,
      object baseInterface,
      out object innerInterface);
  }
}
