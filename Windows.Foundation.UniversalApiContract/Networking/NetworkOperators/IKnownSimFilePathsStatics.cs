// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownSimFilePathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownSimFilePaths))]
  [Guid(2160925283, 14245, 17363, 128, 163, 204, 210, 62, 143, 236, 238)]
  internal interface IKnownSimFilePathsStatics
  {
    IVectorView<uint> EFOns { get; }

    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
