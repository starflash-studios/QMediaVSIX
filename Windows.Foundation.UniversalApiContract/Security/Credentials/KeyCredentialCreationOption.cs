// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialCreationOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the options for creating key credentials.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyCredentialCreationOption
  {
    /// <summary>Replace any existing key credentials.</summary>
    ReplaceExisting,
    /// <summary>Fail if a key credential already exists.</summary>
    FailIfExists,
  }
}
