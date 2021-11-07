// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayStoredBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents an object used to store a bitmap via the LineDisplayWindow.StoreBitmapAsync method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  public sealed class LineDisplayStoredBitmap : ILineDisplayStoredBitmap
  {
    /// <summary>Gets the UnifiedPOS escape sequence that is used to print images inline with text.</summary>
    /// <returns>A string that, when printed to the line display device, displays this bitmap at the cursor position.</returns>
    public extern string EscapeSequence { [MethodImpl] get; }

    /// <summary>Attempts to asynchronously delete the stored bitmap.</summary>
    /// <returns>Returns True if the bitmap was successfully deleted; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDeleteAsync();
  }
}
