// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.ITargetFileRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TargetFileRequestedEventArgs))]
  [Guid(2976111553, 6993, 19593, 165, 145, 15, 212, 11, 60, 87, 201)]
  internal interface ITargetFileRequestedEventArgs
  {
    TargetFileRequest Request { get; }
  }
}
