// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(2727179668, 35905, 19987, 151, 25, 81, 100, 121, 111, 228, 199)]
  internal interface IApplicationViewStatics3
  {
    ApplicationViewWindowingMode PreferredLaunchWindowingMode { get; set; }

    Size PreferredLaunchViewSize { get; set; }
  }
}
