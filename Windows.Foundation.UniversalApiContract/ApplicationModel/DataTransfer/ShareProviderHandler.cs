// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareProviderHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>A delegate that handles share providers.</summary>
  /// <param name="operation"># Windows.ApplicationModel.DataTransfer.ShareProviderHandler</param>
  [Guid(3891911098, 57786, 20045, 189, 101, 212, 56, 69, 211, 33, 47)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public delegate void ShareProviderHandler(ShareProviderOperation operation);
}
