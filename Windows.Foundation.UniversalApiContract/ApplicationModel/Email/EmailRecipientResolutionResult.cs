// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailRecipientResolutionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the result of an attempt to resolve an email recipient.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class EmailRecipientResolutionResult : 
    IEmailRecipientResolutionResult,
    IEmailRecipientResolutionResult2
  {
    /// <summary>Instantiates a new instance of the EmailRecipientResolutionResult class.</summary>
    [MethodImpl]
    public extern EmailRecipientResolutionResult();

    /// <summary>Gets or sets the state of an attempt to resolve an email recipient.</summary>
    /// <returns>The state of an attempt to resolve an email recipient.</returns>
    public extern EmailRecipientResolutionStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the public key for an email recipient.</summary>
    /// <returns>The public key for an email recipient.</returns>
    public extern IVectorView<Certificate> PublicKeys { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPublicKeys(IIterable<Certificate> value);
  }
}
