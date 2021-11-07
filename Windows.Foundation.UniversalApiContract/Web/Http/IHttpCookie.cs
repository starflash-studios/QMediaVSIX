// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookie
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(525633762, 52269, 18297, 134, 167, 136, 241, 6, 135, 210, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCookie))]
  internal interface IHttpCookie
  {
    string Name { get; }

    string Domain { get; }

    string Path { get; }

    IReference<DateTime> Expires { get; set; }

    bool HttpOnly { get; set; }

    bool Secure { get; set; }

    string Value { get; set; }
  }
}
