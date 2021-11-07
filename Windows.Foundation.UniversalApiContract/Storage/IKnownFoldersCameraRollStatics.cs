// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersCameraRollStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1561419366, 10216, 18735, 184, 229, 47, 144, 137, 108, 212, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownFolders))]
  internal interface IKnownFoldersCameraRollStatics
  {
    StorageFolder CameraRoll { get; }
  }
}
