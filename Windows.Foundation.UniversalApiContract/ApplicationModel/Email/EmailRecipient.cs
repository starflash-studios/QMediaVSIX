// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailRecipient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email recipient.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IEmailRecipientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EmailRecipient : IEmailRecipient
  {
    /// <summary>Initializes an instance of the EmailRecipient class.</summary>
    /// <param name="address">The address of the recipient.</param>
    [MethodImpl]
    public extern EmailRecipient(string address);

    /// <summary>Initializes an instance of the EmailRecipient class.</summary>
    /// <param name="address">The address of the recipient.</param>
    /// <param name="name">The name of the recipient.</param>
    [MethodImpl]
    public extern EmailRecipient(string address, string name);

    /// <summary>Initializes an instance of the EmailRecipient class.</summary>
    [MethodImpl]
    public extern EmailRecipient();

    /// <summary>Gets or sets the name of the email recipient.</summary>
    /// <returns>The name of the email recipient.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the address of the email recipient.</summary>
    /// <returns>The address of the email recipient.</returns>
    public extern string Address { [MethodImpl] get; [MethodImpl] set; }
  }
}
