// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxPolicies
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the encryption and signing policies associates with an email mailbox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxPolicies : 
    IEmailMailboxPolicies,
    IEmailMailboxPolicies2,
    IEmailMailboxPolicies3
  {
    /// <summary>Gets or sets the allowable SMIME encryption algorithms for the purpose of negotiating with an app.</summary>
    /// <returns>The allowable SMIME encryption algorithms.</returns>
    public extern EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation AllowedSmimeEncryptionAlgorithmNegotiation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether software certificates are allowed.</summary>
    /// <returns>A Boolean value that indicates whether software certificates are allowed.</returns>
    public extern bool AllowSmimeSoftCertificates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the required SMIME encryption algorithm.</summary>
    /// <returns>The required SMIME encryption algorithm.</returns>
    public extern IReference<EmailMailboxSmimeEncryptionAlgorithm> RequiredSmimeEncryptionAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the required SMIME signing algorithm.</summary>
    /// <returns>The required SMIME signing algorithm.</returns>
    public extern IReference<EmailMailboxSmimeSigningAlgorithm> RequiredSmimeSigningAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether the sync provider that represents the email mailbox only accepts encrypted messages.</summary>
    /// <returns>The Boolean value that indicates whether the sync provider that represents the email mailbox only accepts encrypted messages.</returns>
    public extern bool MustEncryptSmimeMessages { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether the sync provider that represents the email mailbox only accepts signed messages.</summary>
    /// <returns>The Boolean value that indicates whether the sync provider that represents the email mailbox only accepts signed messages.</returns>
    public extern bool MustSignSmimeMessages { [MethodImpl] get; [MethodImpl] set; }
  }
}
