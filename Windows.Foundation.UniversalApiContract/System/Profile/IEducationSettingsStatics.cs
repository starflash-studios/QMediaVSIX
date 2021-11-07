// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IEducationSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (EducationSettings))]
  [Guid(4233359599, 19774, 19987, 155, 35, 80, 95, 77, 9, 30, 146)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IEducationSettingsStatics
  {
    bool IsEducationEnvironment { get; }
  }
}
