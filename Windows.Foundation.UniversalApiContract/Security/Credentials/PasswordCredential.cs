// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.PasswordCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the password credential store.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICredentialFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PasswordCredential : IPasswordCredential
  {
    /// <summary>Creates and initializes a new instance of the PasswordCredential object that contains the provided credential data.</summary>
    /// <param name="resource">The resource for which the credentials are used.</param>
    /// <param name="userName">The user name that must be present in the credentials. This value must not be null or empty, otherwise an exception will be thrown.</param>
    /// <param name="password">The password for the created credentials. This value must not be null or empty, otherwise an exception will be thrown.</param>
    [MethodImpl]
    public extern PasswordCredential(string resource, string userName, string password);

    /// <summary>Creates and initializes a new, empty instance of the PasswordCredential object.</summary>
    [MethodImpl]
    public extern PasswordCredential();

    /// <summary>Gets or sets the resource of the credential.</summary>
    /// <returns>The resource of the credential.</returns>
    public extern string Resource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the user name of the credential. This value must not be null or empty, otherwise an exception will be thrown.</summary>
    /// <returns>The user name of the credential.</returns>
    public extern string UserName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the password string of the credential. This value must not be null or empty, otherwise an exception will be thrown. You must call **RetrievePassword ** first to set the initial value of this property.</summary>
    /// <returns>The password string of the credential.</returns>
    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Populates the password for the credential. After the operation returns successfully, you can get the password from the Password property.</summary>
    [MethodImpl]
    public extern void RetrievePassword();

    /// <summary>This API is intended for internal use only should not be used in your code.</summary>
    /// <returns>This API is intended for internal use only and should not be used in your code.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
