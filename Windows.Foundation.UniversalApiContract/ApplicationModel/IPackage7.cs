// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(2264894769, 41700, 17888, 151, 50, 40, 58, 109, 136, 253, 225)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage7
  {
    StorageFolder MutableLocation { get; }

    StorageFolder EffectiveLocation { get; }
  }
}
