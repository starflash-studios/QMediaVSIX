// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ExclusiveTo(typeof (AppExtensionPackageUpdatingEventArgs))]
  [Guid(2127926057, 6757, 18432, 167, 0, 179, 33, 0, 158, 48, 106)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppExtensionPackageUpdatingEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }
  }
}
