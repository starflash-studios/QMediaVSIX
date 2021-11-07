// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (Uri))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2654363223, 18610, 16736, 149, 111, 199, 56, 81, 32, 187, 252)]
  internal interface IUriRuntimeClass
  {
    string AbsoluteUri { get; }

    string DisplayUri { get; }

    string Domain { get; }

    string Extension { get; }

    string Fragment { get; }

    string Host { get; }

    string Password { get; }

    string Path { get; }

    string Query { get; }

    WwwFormUrlDecoder QueryParsed { get; }

    string RawUri { get; }

    string SchemeName { get; }

    string UserName { get; }

    int Port { get; }

    bool Suspicious { get; }

    bool Equals(Uri pUri);

    Uri CombineUri(string relativeUri);
  }
}
