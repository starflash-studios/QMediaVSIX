// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Deferral
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Stores a DeferralCompletedHandler to be invoked upon completion of the deferral and manipulates the state of the deferral.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IDeferralFactory), 65536, "Windows.Foundation.FoundationContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class Deferral : IDeferral, IClosable
  {
    /// <summary>Initializes a new Deferral object and specifies a DeferralCompletedHandler to be called upon completion of the deferral.</summary>
    /// <param name="handler">A DeferralCompletedHandler to be called upon completion of the deferral.</param>
    [MethodImpl]
    public extern Deferral(DeferralCompletedHandler handler);

    /// <summary>If the DeferralCompletedHandler has not yet been invoked, this will call it and drop the reference to the delegate.</summary>
    [MethodImpl]
    public extern void Complete();

    [MethodImpl]
    public extern void Close();
  }
}
