// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IPasswordCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1790019977, 50976, 16807, 166, 193, 254, 173, 179, 99, 41, 160)]
  [ExclusiveTo(typeof (PasswordCredential))]
  internal interface IPasswordCredential
  {
    string Resource { get; set; }

    string UserName { get; set; }

    string Password { get; set; }

    void RetrievePassword();

    IPropertySet Properties { get; }
  }
}
