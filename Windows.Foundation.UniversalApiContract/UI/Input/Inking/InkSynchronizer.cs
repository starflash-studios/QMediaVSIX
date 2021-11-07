// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkSynchronizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages the synchronization of ink input and provides methods for rendering it to the Direct2D device context of your Universal Windows app, instead of the default InkCanvas control. This requires an IInkD2DRenderer object to manage the ink input (see the Complex ink sample ).</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class InkSynchronizer : IInkSynchronizer
  {
    /// <summary>Initiates a custom "dry" of ink input to the Direct2D device context of your app, instead of the default InkCanvas control. This requires an IInkD2DRenderer object to manage the ink input (see the Complex ink sample ).</summary>
    /// <returns>The collection of "wet" ink strokes to pass to the IInkD2DRenderer object .</returns>
    [MethodImpl]
    public extern IVectorView<InkStroke> BeginDry();

    /// <summary>Finalizes a custom "dry" of ink input to the Direct2D device context of your app, instead of the default InkCanvas control, and notifies the system that "wet" ink can be removed. This requires an IInkD2DRenderer object to manage the ink input (see the Complex ink sample ).</summary>
    [MethodImpl]
    public extern void EndDry();
  }
}
