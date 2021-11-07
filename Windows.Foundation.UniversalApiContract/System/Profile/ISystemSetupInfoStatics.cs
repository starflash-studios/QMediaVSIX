// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISystemSetupInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(748036264, 7560, 24109, 163, 36, 165, 67, 175, 66, 71, 238)]
  [ExclusiveTo(typeof (SystemSetupInfo))]
  internal interface ISystemSetupInfoStatics
  {
    SystemOutOfBoxExperienceState OutOfBoxExperienceState { get; }

    event EventHandler<object> OutOfBoxExperienceStateChanged;
  }
}
