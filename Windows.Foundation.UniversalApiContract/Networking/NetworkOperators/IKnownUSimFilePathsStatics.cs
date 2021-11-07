// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownUSimFilePathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (KnownUSimFilePaths))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2083841409, 7963, 17396, 149, 48, 139, 9, 45, 50, 215, 31)]
  internal interface IKnownUSimFilePathsStatics
  {
    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> EFOpl { get; }

    IVectorView<uint> EFPnn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
