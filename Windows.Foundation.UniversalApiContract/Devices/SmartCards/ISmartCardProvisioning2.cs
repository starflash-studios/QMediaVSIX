// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioning2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(285026539, 16249, 19302, 155, 124, 17, 193, 73, 183, 208, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  internal interface ISmartCardProvisioning2
  {
    [RemoteAsync]
    IAsyncOperation<string> GetAuthorityKeyContainerNameAsync();
  }
}
