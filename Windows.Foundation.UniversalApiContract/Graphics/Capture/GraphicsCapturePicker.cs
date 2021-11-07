// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.GraphicsCapturePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  /// <summary>A system picker UI control that allows the customer to select an item on the screen to capture.</summary>
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class GraphicsCapturePicker : IGraphicsCapturePicker
  {
    /// <summary>Constructs an instance of a capture picker.</summary>
    [MethodImpl]
    public extern GraphicsCapturePicker();

    /// <summary>Opens the capture picker and allows the customer to pick a target on the screen to capture.</summary>
    /// <returns>The capture item representing the target that the customer picked.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GraphicsCaptureItem> PickSingleItemAsync();
  }
}
