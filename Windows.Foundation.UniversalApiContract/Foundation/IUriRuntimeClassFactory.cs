// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClassFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1151957359, 29246, 20447, 162, 24, 3, 62, 117, 176, 192, 132)]
  [ExclusiveTo(typeof (Uri))]
  internal interface IUriRuntimeClassFactory
  {
    Uri CreateUri(string uri);

    Uri CreateWithRelativeUri(string baseUri, string relativeUri);
  }
}
