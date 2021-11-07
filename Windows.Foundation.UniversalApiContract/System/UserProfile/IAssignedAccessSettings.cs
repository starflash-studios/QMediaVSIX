// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAssignedAccessSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (AssignedAccessSettings))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(465927964, 59761, 22359, 184, 224, 81, 47, 139, 140, 70, 210)]
  internal interface IAssignedAccessSettings
  {
    bool IsEnabled { get; }

    bool IsSingleAppKioskMode { get; }

    User User { get; }
  }
}
