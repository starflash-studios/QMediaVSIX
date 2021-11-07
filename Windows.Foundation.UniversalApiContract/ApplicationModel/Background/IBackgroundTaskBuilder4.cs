// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1196811554, 52130, 20021, 189, 22, 166, 218, 127, 28, 25, 170)]
  internal interface IBackgroundTaskBuilder4 : IBackgroundTaskBuilder
  {
    BackgroundTaskRegistrationGroup TaskGroup { get; set; }
  }
}
