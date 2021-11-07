// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ExclusiveTo(typeof (AppExtensionPackageStatusChangedEventArgs))]
  [Guid(484537395, 4435, 17661, 135, 177, 138, 225, 5, 3, 3, 223)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppExtensionPackageStatusChangedEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }
  }
}
