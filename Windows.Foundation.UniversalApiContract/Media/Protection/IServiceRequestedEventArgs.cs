// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IServiceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ExclusiveTo(typeof (ServiceRequestedEventArgs))]
  [Guid(875051951, 43956, 20417, 189, 137, 147, 241, 6, 87, 58, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IServiceRequestedEventArgs
  {
    IMediaProtectionServiceRequest Request { get; }

    MediaProtectionServiceCompletion Completion { get; }
  }
}
