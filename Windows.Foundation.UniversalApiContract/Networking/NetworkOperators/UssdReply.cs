// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UssdReply
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the network response after sending a USSD message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class UssdReply : IUssdReply
  {
    /// <summary>Gets the result code for the USSD response.</summary>
    /// <returns>The result code for the USSD response.</returns>
    public extern UssdResultCode ResultCode { [MethodImpl] get; }

    /// <summary>Gets the message for the USSD response.</summary>
    /// <returns>The message for the USSD response.</returns>
    public extern UssdMessage Message { [MethodImpl] get; }
  }
}
