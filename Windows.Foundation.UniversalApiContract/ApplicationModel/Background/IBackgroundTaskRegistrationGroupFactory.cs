// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationGroupFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2212047721, 17615, 17969, 151, 64, 3, 199, 216, 116, 27, 197)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BackgroundTaskRegistrationGroup))]
  internal interface IBackgroundTaskRegistrationGroupFactory
  {
    BackgroundTaskRegistrationGroup Create(string id);

    BackgroundTaskRegistrationGroup CreateWithName(
      string id,
      string name);
  }
}
