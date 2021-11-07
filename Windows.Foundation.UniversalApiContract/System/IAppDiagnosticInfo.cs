// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3813189274, 34953, 19619, 190, 7, 213, 255, 255, 95, 8, 4)]
  internal interface IAppDiagnosticInfo
  {
    AppInfo AppInfo { get; }
  }
}
