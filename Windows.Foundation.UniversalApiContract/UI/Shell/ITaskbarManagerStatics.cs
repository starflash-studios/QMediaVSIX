// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.ITaskbarManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [ExclusiveTo(typeof (TaskbarManager))]
  [Guid(3677530996, 56914, 20454, 183, 182, 149, 255, 159, 131, 149, 223)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITaskbarManagerStatics
  {
    TaskbarManager GetDefault();
  }
}
