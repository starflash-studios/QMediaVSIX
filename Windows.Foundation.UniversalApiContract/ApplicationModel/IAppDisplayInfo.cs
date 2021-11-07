// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppDisplayInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppDisplayInfo))]
  [Guid(451612931, 58580, 16810, 164, 246, 196, 162, 118, 231, 158, 172)]
  internal interface IAppDisplayInfo
  {
    string DisplayName { get; }

    string Description { get; }

    RandomAccessStreamReference GetLogo(Size size);
  }
}
