// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(2185774664, 48574, 17531, 162, 238, 122, 254, 106, 3, 42, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileUpdateRequest))]
  internal interface IFileUpdateRequest2 : IFileUpdateRequest
  {
    string UserInputNeededMessage { get; set; }
  }
}
