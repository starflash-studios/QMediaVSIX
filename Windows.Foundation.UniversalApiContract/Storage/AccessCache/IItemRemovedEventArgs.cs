// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IItemRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemRemovedEventArgs))]
  [Guid(1499954780, 21950, 19558, 186, 102, 94, 174, 167, 157, 38, 49)]
  internal interface IItemRemovedEventArgs
  {
    AccessListEntry RemovedEntry { get; }
  }
}
