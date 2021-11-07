// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherOptions3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4034332245, 19299, 20026, 145, 7, 78, 104, 120, 65, 146, 58)]
  [ExclusiveTo(typeof (LauncherOptions))]
  internal interface ILauncherOptions3
  {
    bool IgnoreAppUriHandlers { get; set; }
  }
}
