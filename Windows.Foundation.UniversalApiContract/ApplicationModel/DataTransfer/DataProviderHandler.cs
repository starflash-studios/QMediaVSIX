// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataProviderHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Provides data when the target app requests it, instead of including the data in the DataPackage ahead of time. [ DataProviderHandler is used when the source app wants to avoid unnecessary work that is resource intensive, such as performing format conversions.</summary>
  /// <param name="request">Contains the data that the user wants to share.</param>
  [Guid(3891058464, 62196, 18989, 146, 14, 23, 10, 47, 72, 42, 39)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void DataProviderHandler(DataProviderRequest request);
}
