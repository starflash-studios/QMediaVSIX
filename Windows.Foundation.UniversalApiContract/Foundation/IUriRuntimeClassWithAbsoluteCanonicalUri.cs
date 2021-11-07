// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClassWithAbsoluteCanonicalUri
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1972213345, 8732, 18447, 163, 57, 80, 101, 102, 115, 244, 111)]
  [ExclusiveTo(typeof (Uri))]
  internal interface IUriRuntimeClassWithAbsoluteCanonicalUri
  {
    string AbsoluteCanonicalUri { get; }

    string DisplayIri { get; }
  }
}
