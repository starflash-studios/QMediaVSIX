// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.RcsEndUserMessageAvailableTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task when a new Rich Communication Services (RCS) message is available.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RcsEndUserMessageAvailableTrigger : 
    IBackgroundTrigger,
    IRcsEndUserMessageAvailableTrigger
  {
    /// <summary>Initializes a new instance of the RcsEndUserMessageAvailableTrigger class.</summary>
    [MethodImpl]
    public extern RcsEndUserMessageAvailableTrigger();
  }
}
