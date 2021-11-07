// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareCompletedEventArgs))]
  [Guid(1165280322, 63763, 20320, 157, 247, 204, 64, 96, 171, 25, 22)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareCompletedEventArgs
  {
    ShareTargetInfo ShareTarget { get; }
  }
}
