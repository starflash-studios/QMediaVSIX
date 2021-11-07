// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherOptions4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(4017082638, 59131, 18452, 164, 78, 87, 232, 185, 217, 160, 27)]
  [ExclusiveTo(typeof (LauncherOptions))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILauncherOptions4
  {
    bool LimitPickerToCurrentAppAndAppUriHandlers { get; set; }
  }
}
