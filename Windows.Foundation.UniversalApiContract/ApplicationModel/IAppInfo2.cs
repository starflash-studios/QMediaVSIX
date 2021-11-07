// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (AppInfo))]
  [Guid(3192594266, 8344, 17179, 189, 37, 179, 8, 120, 116, 141, 71)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IAppInfo2
  {
    Package Package { get; }
  }
}
